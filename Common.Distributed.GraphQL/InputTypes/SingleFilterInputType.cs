using GraphQL.Types;
using System;
using Common.Infr.Support.Filter;

namespace Common.Distributed.GraphQL.InputTypes
{
    public abstract class SingleFilterInputType<T, K> : InputObjectGraphType<SingleFilter<K>>
    {
        public SingleFilterInputType()
        {
            Name = GetName();
            Field(i => i.Value, nullable: true);
            Field(i => i.ExcludeNulls);
        }

        public abstract string GetName();        
    }
}
