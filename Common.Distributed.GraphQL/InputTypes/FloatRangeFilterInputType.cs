using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Distributed.GraphQL.InputTypes
{
    public class FloatRangeFilterInputType : RangeFilterInputType<FloatGraphType, float?>
    {
        public override string GetName() => "FloatRangeFilterInputType";
    }
}
