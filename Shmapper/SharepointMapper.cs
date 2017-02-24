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

        private object ReadFieldValueFromComplexType(object fieldValue, SharepointFieldAttribute SpAttr)
        {
            if (fieldValue is FieldLookupValue)
            {
                if (SpAttr.BindData == MapData.LookupId)
                    fieldValue = ((FieldLookupValue)fieldValue).LookupId;

                if (SpAttr.BindData == MapData.LookupValue || SpAttr.BindData == MapData.Default)
                    fieldValue = ((FieldLookupValue)fieldValue).LookupValue;
            }

            if (fieldValue is FieldLookupValue[])
            {
                if (SpAttr.BindData == MapData.LookupId)
                    fieldValue = ((FieldLookupValue[])fieldValue).Select(v => v.LookupId).ToList();

                if (SpAttr.BindData == MapData.LookupValue || SpAttr.BindData == MapData.Default)
                    fieldValue = ((FieldLookupValue[])fieldValue).Select(v => v.LookupValue).ToList();
            }

            if (fieldValue is FieldUserValue)
            {
                if (SpAttr.BindData == MapData.LookupId)
                    fieldValue = ((FieldUserValue)fieldValue).LookupId;

                if (SpAttr.BindData == MapData.LookupValue || SpAttr.BindData == MapData.Default)
                    fieldValue = ((FieldUserValue)fieldValue).LookupValue;
            }

            if (fieldValue is FieldUserValue[])
            {
                if (SpAttr.BindData == MapData.LookupId)
                    fieldValue = ((FieldUserValue[])fieldValue).Select(v => v.LookupId).ToList();

                if (SpAttr.BindData == MapData.LookupValue || SpAttr.BindData == MapData.Default)
                    fieldValue = ((FieldUserValue[])fieldValue).Select(v => v.LookupValue).ToList();
            }

            if (fieldValue is FieldCalculatedErrorValue)
            {
                fieldValue = "Calculated field contains error.";
            }

            if (fieldValue is FieldUrlValue)
                fieldValue = ((FieldUrlValue)fieldValue).Url;

            return fieldValue;
        }

        /// <summary>
        /// Build Sharepoint object for mapped type. 
        /// </summary>
        public T BuildObject<T>(ListItem item) where T : new()
        {
            var obj = new T();
            var objType = typeof(T);
            var objProperties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty);
            var fieldsOfItem = item.FieldValues.Select(f => f.Key).ToList();

            foreach (var objProperty in objProperties.Where(p => p.IsDefined(typeof(SharepointFieldAttribute))))
            {
                var SpAttr = objProperty.GetCustomAttribute<SharepointFieldAttribute>();
                var SharepointFieldName = SpAttr.InternalName;
                if (fieldsOfItem.Contains(SharepointFieldName))
                {
                    object fieldValue = item.FieldValues[SharepointFieldName];
                    if (fieldValue != null && !fieldValue.GetType().IsPrimitive && !(fieldValue is string) && !(fieldValue is string[]))
                        fieldValue = ReadFieldValueFromComplexType(fieldValue, SpAttr);

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
