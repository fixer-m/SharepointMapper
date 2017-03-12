using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Shmapper
{
    internal class SharepointMapper
    {
        private ClientContext Context;

        public SharepointMapper(ClientContext Context)
        {
            this.Context = Context;
        }

        /// <summary>
        /// Returns Sharepoint List for item (via attribute SharepointList)
        /// </summary>
        public Microsoft.SharePoint.Client.List GetListForSharepointItem<T>()
        {
            Type SpEntityType = typeof(T);
            var SpAttr = SpEntityType.GetCustomAttribute<SharepointListAttribute>();

            if (SpAttr == null)
                throw new InvalidMappingExeption(String.Format("Type {0} doesn't have attribute [SharepointList].", SpEntityType));

            if (SpAttr.Title != null)
                return Context.Web.Lists.GetByTitle(SpAttr.Title);

            if (SpAttr.Id != default(Guid))
                return Context.Web.Lists.GetById(SpAttr.Id);

            if (SpAttr.SpecialList == SpecialList.UserInfoList)
                return Context.Web.SiteUserInfoList;

            return null;
        }

        /// <summary>
        /// Returns internal names of mapped fields for type T
        /// </summary>
        public List<string> GetMappedFields<T>()
        {
            List<string> MappedFields = new List<string>();
            Type SpItemType = typeof(T);
            var objProperties = SpItemType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty)
                .Where(p => p.IsDefined(typeof(SharepointFieldAttribute))).ToList();

            foreach (var objProperty in objProperties)
            {
                var SpAttr = objProperty.GetCustomAttribute<SharepointFieldAttribute>();
                if (!MappedFields.Contains(SpAttr.InternalName))
                    MappedFields.Add(SpAttr.InternalName);
            }

            return MappedFields;
        }

        private Type GetUnderlyingType(PropertyInfo objProperty)
        {
            if (objProperty.PropertyType.IsGenericType && objProperty.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
                return Nullable.GetUnderlyingType(objProperty.PropertyType);
            else
                return objProperty.PropertyType;
        }

        private object GetFieldValueFromComplexType(object fieldValue, SharepointFieldAttribute SpAttr)
        {
            if (fieldValue is FieldLookupValue)
            {
                if (SpAttr.MapData == MapData.LookupId)
                    fieldValue = ((FieldLookupValue)fieldValue).LookupId;

                if (SpAttr.MapData == MapData.LookupValue || SpAttr.MapData == MapData.Default)
                    fieldValue = ((FieldLookupValue)fieldValue).LookupValue;
            }

            if (fieldValue is FieldLookupValue[])
            {
                if (SpAttr.MapData == MapData.LookupId)
                    fieldValue = ((FieldLookupValue[])fieldValue).Select(v => v.LookupId).ToList();

                if (SpAttr.MapData == MapData.LookupValue || SpAttr.MapData == MapData.Default)
                    fieldValue = ((FieldLookupValue[])fieldValue).Select(v => v.LookupValue).ToList();
            }

            if (fieldValue is FieldCalculatedErrorValue)
                fieldValue = "Calculated field contains error.";

            if (fieldValue is FieldUrlValue)
                fieldValue = ((FieldUrlValue)fieldValue).Url;

            return fieldValue;
        }

        private List<string> GetWritableFieldsOfList(List list)
        {
            List<string> WritableFields = (list.Fields as IEnumerable<Field>).Where(f => !f.ReadOnlyField).Select(f => f.InternalName).ToList();
            WritableFields.Add("_ModerationStatus");
            return WritableFields;
        }

        public void UpdateItemsFromEntities<T>(IEnumerable<T> Entities, List list) where T : ISharepointItem
        {
            List<string> WritableFields = GetWritableFieldsOfList(list);
            List<PropertyInfo> EntityProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty)
                .Where(p => p.IsDefined(typeof(SharepointFieldAttribute))).ToList();

            foreach (var itemToUpdate in Entities)
            {
                var item = list.GetItemById(itemToUpdate.Id);

                foreach (var objProperty in EntityProperties)
                {
                    var SpFieldAttr = objProperty.GetCustomAttribute<SharepointFieldAttribute>();
                    if (WritableFields.Contains(SpFieldAttr.InternalName) && SpFieldAttr.MapData != MapData.LookupValue)
                        item[SpFieldAttr.InternalName] = objProperty.GetValue(itemToUpdate);
                }
                item.Update();
            }
        }

        /// <summary>
        /// Create items Build Sharepoint object for mapped type. 
        /// </summary>
        public void CreateItemsFromEntities<T>(IEnumerable<T> Entities, List list) where T : ISharepointItem
        {
            List<string> WritableFields = GetWritableFieldsOfList(list);
            List<PropertyInfo> EntityProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty)
               .Where(p => p.IsDefined(typeof(SharepointFieldAttribute))).ToList();

            var creatItemInfo = new ListItemCreationInformation();
            foreach (var itemToInsert in Entities)
            {
                var item = list.AddItem(creatItemInfo);

                foreach (var objProperty in EntityProperties)
                {
                    var SpFieldAttr = objProperty.GetCustomAttribute<SharepointFieldAttribute>();
                    if (WritableFields.Contains(SpFieldAttr.InternalName) && SpFieldAttr.MapData != MapData.LookupValue)
                    {
                        var newValue = objProperty.GetValue(itemToInsert);
                        item[SpFieldAttr.InternalName] = newValue;
                    }
                }
                item.Update();
            }
        }

        /// <summary>
        /// Build Sharepoint object for mapped type. 
        /// </summary>
        public T BuildEntityFromItem<T>(ListItem Item) where T : new()
        {
            var obj = new T();

            var fieldsOfItem = Item.FieldValues.Select(f => f.Key).ToList();
            List<PropertyInfo> EntityProperties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty)
               .Where(p => p.IsDefined(typeof(SharepointFieldAttribute))).ToList();

            foreach (var objProperty in EntityProperties)
            {
                var SpAttr = objProperty.GetCustomAttribute<SharepointFieldAttribute>();
                var SharepointFieldName = SpAttr.InternalName;
                if (fieldsOfItem.Contains(SharepointFieldName))
                {
                    object fieldValue = Item.FieldValues[SharepointFieldName];
                    if (fieldValue != null && !fieldValue.GetType().IsPrimitive && !(fieldValue is string) && !(fieldValue is string[]))
                        fieldValue = GetFieldValueFromComplexType(fieldValue, SpAttr);

                    if (fieldValue == null)
                    {
                        objProperty.SetValue(obj, null);
                    }
                    else
                    {
                        Type TypeToConvert = GetUnderlyingType(objProperty);
                        object settablePropertyValue = Convert.ChangeType(fieldValue, TypeToConvert);
                        objProperty.SetValue(obj, settablePropertyValue);
                    }
                }
            }

            return obj;
        }

    }
}
