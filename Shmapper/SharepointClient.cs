using CamlexNET;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;

// TODO: check mapping method
// TODO: exception handling ?
// TODO: test with Sharepoint 2016

namespace Shmapper
{
    public class SharepointClient
    {   private ClientContext Context;
        private SharepointMapper Mapper;

        public SharepointClient(string SiteUrl, ICredentials Credentials)
        {
            Context = new ClientContext(SiteUrl);
            Context.Credentials = Credentials;
            Mapper = new SharepointMapper(Context);
        }


        /// <summary>
        /// Code generation for map entity classes
        /// </summary>
        /// <param name="recodeClassNames">human readable class name  for spList  name , if internal list name  is not valid  class name it should be added in this dictionary </param>
        /// <returns></returns>
        public string GeneratePocoClasses(Dictionary<string, string> recodeClassNames)
        {
            
          
            var web = Context.Web;
            Context.Load(web,w=>w.Lists);
            Context.ExecuteQuery();

            var lists = web.Lists.ToList().Where(l =>(!l.Hidden)).ToList();
            Dictionary<Guid,string> listNameByGuid= lists.ToDictionary(list => list.Id, list =>recodeClassNames.ContainsKey(list.Title) ? recodeClassNames[list.Title] : list.EntityTypeName);

            var stringBuilder = new StringBuilder();
            foreach (var list in lists)
            {
                stringBuilder.Append(PocoClassText(list, listNameByGuid));
            }
            return stringBuilder.ToString( );
        }

        private Type SpTypeToCSharp(Field field)
        {
             Dictionary<FieldType, Type> decode = new Dictionary<FieldType, Type>()
            {

                {FieldType.Counter,typeof(int)},
                {FieldType.Number,typeof(int)},
                {FieldType.Computed,typeof(string)},
                {FieldType.DateTime,typeof(DateTime)},
                {FieldType.Boolean,typeof(bool)},

            };
            return decode.ContainsKey(field.FieldTypeKind) ? decode[field.FieldTypeKind] : typeof(string);
           

        }


        private string RefineFieldName(string fieldname)
        {
            Dictionary<string, string> recodeFieldNames = new Dictionary<string, string>()
            {
                { "Начало мероприятия","Start"},
                { "Окончание мероприятия","End"},
            
            };
            if (recodeFieldNames.ContainsKey(fieldname)) return recodeFieldNames[fieldname];
            return fieldname;

        }

        private string PocoClassText(List list, Dictionary<Guid, string> listNameByGuid)
        {
            var sb = new StringBuilder();
            Context.Load(list, l => l.Fields);
            Context.ExecuteQuery();
            var generatedClassName = listNameByGuid[list.Id];
            sb.Append($@"
    /// <summary>
    ///  {list.Title} 
    ///  {list.Description.Replace("\n", String.Empty).Replace("\r", String.Empty)}
    ///  {list.EntityTypeName}
    /// </summary>
[SharepointList(""{list.Title}"")]
public partial class {generatedClassName}:ISharepointItem 
{{
");

            var counterField = list.Fields.First(f => f.TypeAsString == "Counter");
           
            // add Id property
            sb.Append($@"
                    [SharepointField(""{counterField.StaticName}"" )]
                        public int Id  {{get;set;}} //{counterField.EntityPropertyName}:{counterField.TypeAsString} , {counterField.Description}
                    ");
            // add All over properties
            var fields = list.Fields.ToList().Where(f=>(!f.Hidden)&&(f.TypeAsString!= "Computed") && (f.TypeAsString != "Counter"));
            foreach (Field field in fields)
            {
                string lookUp =  "";
                Type spTypeToCSharp = SpTypeToCSharp(field);
                string typeName = spTypeToCSharp.Name;
                string nullableModifier = spTypeToCSharp.IsValueType&& (!field.Required) ? "?" : "";

                if (field is FieldLookup)
                {
                    FieldLookup fieldLookup = field as FieldLookup;
                    string lookUpTypeId = "int";
                    if (fieldLookup.AllowMultipleValues)
                    {
                        lookUpTypeId = "List<int>";
                        typeName = $@"List<{typeName}>";
                    }
                    
                    Guid listGuid;
                    
                    lookUp = ",MapData.LookupValue";
                    sb.Append(
                        $@"
/// <summary>
///lookup Id(s) for {field.EntityPropertyName}:
///{field.TypeAsString} 
///{field.Description.Replace("/n"," ")}  
/// </summary>
                    [SharepointField(""{field.StaticName}"" , MapData.LookupId)]
                        public   {lookUpTypeId} {RefineFieldName(field.StaticName)}Id {{get;set;}}
 ");
                    //если можем проставить ссылку  прописанный  
                    if (Guid.TryParse(fieldLookup.LookupList, out listGuid) && listNameByGuid.ContainsKey(listGuid))
                    {
                        string lookUpValueStr = fieldLookup.AllowMultipleValues ? $@" public IEnumerable<{listNameByGuid[listGuid]}> {RefineFieldName(field.StaticName)}LookUp(ISpClient client) =>{RefineFieldName(field.StaticName)}Id.Select(l=> client.GetById<{listNameByGuid[listGuid]}>(l));" :
                             $@"  public  {listNameByGuid[listGuid]} {RefineFieldName(field.StaticName)}LookUp(ISpClient client) =>client.GetById<{listNameByGuid[listGuid]}>({RefineFieldName(field.StaticName)}Id );"
                            ;
                        sb.Append($@"
/// <summary> 
///lookup values for  {field.EntityPropertyName}:{field.TypeAsString} , {field.Description}  LookUp list {listNameByGuid[listGuid]}
//fieldLookup.AllowMultipleValues:{fieldLookup.AllowMultipleValues}
/// </summary>
                       {lookUpValueStr} 
                    ");   
                    }

                }
               
                sb.Append($@"
/// <summary>
///{field.EntityPropertyName}:{field.TypeAsString} , {field.Description}
/// </summary>
                    [SharepointField(""{field.StaticName}"" {lookUp})]
                        public {typeName }{nullableModifier} {field.EntityPropertyName}{{get;set;}} 
                    ");
            }
            sb.Append($@"
                }}//{list.Title}
");
            ; return sb.ToString();
        }

        public List<T> Test<T>() where T : ISharepointItem, new()
        {
            List<string> FieldsToLoad = Mapper.GetMappedFields<T>();
            string spQuery = Camlex.Query().Where(x=> (x["MontBlocks"]== (DataTypes.LookupMultiId)"1")).ViewFields(FieldsToLoad).ToString(true);

            return Query<T>(spQuery);
        }

        /// <summary>
        /// Get items of type <T> by lambda expression - filter
        /// </summary>
        public List<T> Query<T>(Expression<Func<T, bool>> filter) where T : ISharepointItem, new()
        {
            var CamlexEpressionFilter = new ExpressionConverter().Visit(filter) as Expression<Func<ListItem, bool>>;

            List<string> FieldsToLoad = Mapper.GetMappedFields<T>();
           // var compile = CamlexEpressionFilter.Compile();
            string spQuery = Camlex.Query().Where(CamlexEpressionFilter).ViewFields(FieldsToLoad).ToString(true);
            
            return Query<T>(spQuery);
        }

        /// <summary>
        /// Get items of type <T> by caml query string. Empty query returns all items.
        /// </summary>
        public List<T> Query<T>(string camlQueryString) where T : ISharepointItem, new()
        {
            CamlQuery query = new CamlQuery { ViewXml = camlQueryString };
            return Query<T>(query);
        }

        /// <summary>
        /// Get all items of type <T>.
        /// </summary>
        public List<T> GetAll<T>() where T : ISharepointItem, new()
        {
            CamlQuery query = new CamlQuery();
            return Query<T>(query);
        }

        private List<T> Query<T>(CamlQuery query) where T : ISharepointItem, new()
        {
            if (query.ViewXml == null)
            {
                List<string> FieldsToLoad = Mapper.GetMappedFields<T>();
                query.ViewXml = Camlex.Query().ViewFields(FieldsToLoad).ToString(true);
            }

            var list = Mapper.GetListForSharepointItem<T>();
            var items = list.GetItems(query);
            Context.Load(items);
            Context.ExecuteQuery();

            List<T> result = new List<T>();
            foreach (ListItem item in items)
                result.Add(Mapper.BuildEntityFromItem<T>(item));

            return result;
        }

        /// <summary>
        /// Get item by ID of type <T>.
        /// </summary>
        public T GetById<T>(int Id) where T : ISharepointItem, new()
        {
            var list = Mapper.GetListForSharepointItem<T>();
            var item = list.GetItemById(Id);
            Context.Load(item);
            Context.ExecuteQuery();

            return Mapper.BuildEntityFromItem<T>(item);
        }

        /// <summary>
        /// Update corresponding changed item in Sharepoint.
        /// </summary>
        public void Update<T>(T Entity) where T : ISharepointItem
        {
            Update((IEnumerable<T>)new[] { Entity });
        }

        /// <summary>
        /// Update corresponding items in Sharepoint.
        /// </summary>
        public void Update<T>(IEnumerable<T> Entities) where T : ISharepointItem
        {
            var list = Mapper.GetListForSharepointItem<T>();

            Context.Load(list.Fields);
            Context.ExecuteQuery();

            Mapper.UpdateItemsFromEntities(Entities, list);
            Context.ExecuteQuery();
        }

        /// <summary>
        /// Remove corresponding item from Sharepoint.
        /// </summary>
        public void Delete<T>(T Entity) where T : ISharepointItem
        {
            Delete((IEnumerable<T>)new[] { Entity });
        }

        /// <summary>
        /// Remove corresponding items from Sharepoint.
        /// </summary>
        public void Delete<T>(IEnumerable<T> Entities) where T : ISharepointItem
        {
            var list = Mapper.GetListForSharepointItem<T>();

            foreach (var itemToDelete in Entities)
            {
                var item = list.GetItemById(itemToDelete.Id);
                item.DeleteObject();
            }
            Context.ExecuteQuery();
        }

        /// <summary>
        /// Create new item in Sharepoint.
        /// </summary>
        public void Insert<T>(T Entitiy) where T : ISharepointItem
        {
            Insert((IEnumerable<T>)new[] { Entitiy });
        }

        /// <summary>
        /// Create new items in Sharepoint.
        /// </summary>
        public void Insert<T>(IEnumerable<T> Entity) where T : ISharepointItem
        {
            var list = Mapper.GetListForSharepointItem<T>();
            Context.Load(list.Fields);
            Context.ExecuteQuery();

            Mapper.CreateItemsFromEntities(Entity, list);
            Context.ExecuteQuery();
        }
    }
}