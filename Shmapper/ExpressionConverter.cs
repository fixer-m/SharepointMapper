using CamlexNET;
using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

// Converts lambda expression to camlex filter: Func<T, bool> => Func<ListItem, bool> (where T : ISharepointItem)
// 1. Changes lambda return type
// 2. Modify member access to get item from FieldValues, mapping used.
// 3. Convert type for field.
// Basic example : (x => x.Active == true) to (x => (bool?)x.ActiveIntrnal == true)
// Example for LookupId/LookupValue: (x => x.MaintainerId == 1000) to (x => x["MaintainerIdInternal"] == (DataTypes.LookupId)1000.ToString())

// TODO: is it possible make Lookup.StartsWith?
// TODO: not mapped properties ? (product.Active)

namespace Shmapper
{
    /// <summary>
    /// Converts lambda expression to camlex filter: Func<T, bool> => Func<ListItem, bool> (where T : ISharepointItem)
    /// </summary>
    public class ExpressionConverter : ExpressionVisitor
    {
        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            var NewParameters = new List<ParameterExpression>() { Expression.Parameter(typeof(ListItem), node.Parameters[0].Name) };
            return Expression.Lambda<Func<ListItem, bool>>(Visit(node.Body), node.Name, NewParameters);
        }

        /// <summary>
        /// Made for special case with transforming LookupId/LookupValue
        /// </summary>
        protected override Expression VisitBinary(BinaryExpression node)
        {
            // Special case for LookupId/LookupValue search
            if (node.Left is MemberExpression)
            {
                MemberExpression nodem = node.Left as MemberExpression;
                if (nodem.Member.MemberType == System.Reflection.MemberTypes.Property)
                {
                    SharepointFieldAttribute FieldAttribute = (SharepointFieldAttribute)Attribute.GetCustomAttribute(nodem.Member.ReflectedType.GetProperty(nodem.Member.Name), typeof(SharepointFieldAttribute));
                    if (FieldAttribute != null && (FieldAttribute.MapData == MapData.LookupId || FieldAttribute.MapData == MapData.LookupValue))
                        return Expression.MakeBinary(node.NodeType, ToMappedField(node.Left, FieldAttribute), ToLookupType(node.Right, FieldAttribute));
                }
            }

            return base.VisitBinary(node); // or return Expression.MakeBinary(node.NodeType, Visit(node.Left), Visit(node.Right));
        }

        /// <summary>
        /// Transform member access to mapped field access and convert to property type
        /// </summary>
        protected override Expression VisitMember(MemberExpression node)
        {
            if (node.Member.MemberType == System.Reflection.MemberTypes.Property)
            {
                SharepointFieldAttribute FieldAttribute = (SharepointFieldAttribute)Attribute.GetCustomAttribute(node.Member.ReflectedType.GetMember(node.Member.Name)[0], typeof(SharepointFieldAttribute));
                if (FieldAttribute != null)
                {
                    var NewParameter = Expression.Parameter(typeof(ListItem), ((ParameterExpression)node.Expression).Name);
                    var GetItemMethod = Expression.Call(NewParameter, typeof(ListItem).GetMethod("get_Item"), new[] { Expression.Constant(FieldAttribute.InternalName) });
                    var GetItemConverted = Expression.Convert(GetItemMethod, node.Member.ReflectedType.GetProperty(node.Member.Name).PropertyType);

                    return GetItemConverted;
                }
            }

            return node;
        }

        /// <summary>
        /// Transform member access to mapped field access
        /// </summary>
        private Expression ToMappedField(Expression e, SharepointFieldAttribute FieldAttribute)
        {
            MemberExpression node = e as MemberExpression;

            var NewParameter = Expression.Parameter(typeof(ListItem), ((ParameterExpression)node.Expression).Name);
            var GetItemMethod = Expression.Call(NewParameter, typeof(ListItem).GetMethod("get_Item"), new[] { Expression.Constant(FieldAttribute.InternalName) });

            return GetItemMethod;
        }

        /// <summary>
        /// Convert to string, then to Lookup Type
        /// </summary>
        private Expression ToLookupType(Expression e, SharepointFieldAttribute FieldAttribute)
        {
            var CallToStringMethod = Expression.Call(e, e.Type.GetMethod("ToString", Type.EmptyTypes));
            var ConvertedToBaseFieldType = Expression.Convert(CallToStringMethod, typeof(BaseFieldType));

            Expression ConvertedToLookupType = Expression.Empty();

            if (FieldAttribute.MapData == MapData.LookupId)
                ConvertedToLookupType = Expression.Convert(ConvertedToBaseFieldType, typeof(DataTypes.LookupId));

            if (FieldAttribute.MapData == MapData.LookupValue)
                ConvertedToLookupType = Expression.Convert(ConvertedToBaseFieldType, typeof(DataTypes.LookupValue));

            return ConvertedToLookupType;
        }
    }
}
