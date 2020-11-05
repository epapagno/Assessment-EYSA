using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Distributed.GraphQL.InputTypes
{
    public class LongSingleFilterInputType : SingleFilterInputType<ULongGraphType, long?>
    {
        public override string GetName() => "LongSingleFilterInputType";
    }
}
