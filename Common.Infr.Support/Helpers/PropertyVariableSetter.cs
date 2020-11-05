using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Common.Infr.Support.Helpers
{
    public class PropertyVariableSetter<TEntity>
    {
        private readonly TEntity entity;
        private readonly IDictionary<string, object> properties = new Dictionary<string, object>();

        public PropertyVariableSetter(TEntity entity, IDictionary<string, object> properties)
        {
            this.entity = entity;
            this.properties = properties;
        }
        public void Assign<TResult>(string propertyName, Expression<Func<TEntity, TResult>> propertyEntity)
        {
            if (properties.ContainsKey(propertyName))
            {
                var valueParameterExpression = Expression.Parameter(typeof(object));
                var targetExpression = propertyEntity.Body is UnaryExpression ? ((UnaryExpression)propertyEntity.Body).Operand : propertyEntity.Body;
                var assignOperation = Expression.Assign(targetExpression, Expression.Convert(valueParameterExpression, targetExpression.Type));
                var assign = Expression.Lambda<Action<TEntity, object>>(
                                assignOperation,
                                propertyEntity.Parameters.Single(),
                                valueParameterExpression);

                var targetType = IsNullableType(propertyEntity.ReturnType) ? Nullable.GetUnderlyingType(propertyEntity.ReturnType) : propertyEntity.ReturnType;

                assign.Compile().Invoke(entity, properties[propertyName] == null ? null : Convert.ChangeType(properties[propertyName], targetType));
            }
        }
        private static bool IsNullableType(Type type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition().Equals(typeof(Nullable<>));
        }
    }
}
