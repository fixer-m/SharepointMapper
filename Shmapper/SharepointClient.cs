using CamlexNET;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;

// TODO: check mapping method
// TODO: exception handling ?
// TODO: test with Sharepoint 2016

namespace Shmapper
{
    public class SharepointClient
    {
        private ClientContext Context;
        private SharepointMapper Mapper;

        public SharepointClient(string SiteUrl, ICredentials Credentials)
        {
            Context = new ClientContext(SiteUrl);
            Context.Credentials = Credentials;
            Mapper = new SharepointMapper(Context);
        }

        /// <summary>
        /// Get items of type <T> by lambda expression - filter
        /// </summary>
        public List<T> Query<T>(Expression<Func<T, bool>> filter) where T : ISharepointItem, new()
        {
            var CamlexEpressionFilter = new ExpressionConverter().Visit(filter) as Expression<Func<ListItem, bool>>;

            List<string> FieldsToLoad = Mapper.GetMappedFields<T>();
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