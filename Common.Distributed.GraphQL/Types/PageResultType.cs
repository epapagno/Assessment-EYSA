using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Infr.Support.Pagination;

namespace Common.Distributed.GraphQL.Types
{
    public class PageResultType<T, K> : ObjectGraphType<IPagedResult<T>> where K : ObjectGraphType<T>
    {
        public PageResultType()
        {
            //WE NEED A DIFFERENT NAME FOR EACH TYPE
            Name = string.Concat("PageResultType", DateTime.Now.Ticks.ToString());

            Field(i => i.FirstItem);
            Field(i => i.HasNextPage);
            Field(i => i.HasPreviousPage);

            Field<ListGraphType<K>>(
                "items",
                resolve: context => context.Source.Items);

            Field(i => i.LastItem);
            Field(i => i.Page);
            Field(i => i.PageSize);
            Field(i => i.TotalItems);
            Field(i => i.TotalPages);
        }
    }
}
