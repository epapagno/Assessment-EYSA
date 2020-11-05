using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Common.Distributed.GraphQL.Types;

namespace Common.Distributed.GraphQL.Extension
{
    public static class ObjectGraphTypeExtension
    {
        public static void AddFieldPagedResult<TEntity, TEntityType>(this ObjectGraphType objectGraphType, string name, string description, Func<int, int, ResolveFieldContext<object>, object> resolve, IEnumerable<QueryArgument> extraArgs) where TEntityType : ObjectGraphType<TEntity>
        {
            QueryArguments arguments = new QueryArguments(extraArgs ?? new List<QueryArgument>());
            arguments.Add(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "page", Description = "Número de página" });
            arguments.Add(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "pageSize", Description = "Tamaño de página" });

            objectGraphType.Field<PageResultType<TEntity, TEntityType>>(
                description: description,
                name: name,
                arguments: arguments,
                resolve: context => resolve(context.GetArgument<int>("page"), context.GetArgument<int>("pageSize"), context));
        }
        public static void AddFieldPagedResultAsync<TEntity, TEntityType>(this ObjectGraphType objectGraphType, string name, string description, Func<int, int, ResolveFieldContext<object>, Task<object>> resolve, IEnumerable<QueryArgument> extraArgs) where TEntityType : ObjectGraphType<TEntity>
        {
            QueryArguments arguments = new QueryArguments(extraArgs ?? new List<QueryArgument>());
            arguments.Add(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "page", Description = "Número de página" });
            arguments.Add(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "pageSize", Description = "Tamaño de página" });

            
            var obj = objectGraphType.FieldAsync<PageResultType<TEntity, TEntityType>>(
                description: description,
                name: name,
                arguments: arguments,
                resolve: async context => await resolve(context.GetArgument<int>("page"), context.GetArgument<int>("pageSize"), context));
        }        
    }
}
