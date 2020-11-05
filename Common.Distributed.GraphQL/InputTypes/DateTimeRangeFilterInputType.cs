using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Distributed.GraphQL.InputTypes
{
    public class DateTimeRangeFilterInputType : RangeFilterInputType<DateTimeGraphType, DateTime?>
    {
        public override string GetName() => "DateTimeRangeFilterInputType";
    }
}
