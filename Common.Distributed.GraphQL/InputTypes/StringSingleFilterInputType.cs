using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Distributed.GraphQL.InputTypes
{
    public class StringSingleFilterInputType : SingleFilterInputType<StringGraphType, string>
    {
        public override string GetName() => "StringSingleFilterInputType";
    }
}
