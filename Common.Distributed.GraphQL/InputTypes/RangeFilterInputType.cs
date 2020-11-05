using GraphQL.Types;
using System;
using Common.Infr.Support.Filter;

namespace Common.Distributed.GraphQL.InputTypes
{
    public abstract class RangeFilterInputType<T, K> : InputObjectGraphType<RangeFilter<K>>
    {
        public RangeFilterInputType()
        {
            Name = GetName();
            Field(i => i.MinValue, nullable: true);
            Field(i => i.MaxValue, nullable: true);
            Field(i => i.ExcludeNulls);
        }

        public abstract string GetName();
    }
}
