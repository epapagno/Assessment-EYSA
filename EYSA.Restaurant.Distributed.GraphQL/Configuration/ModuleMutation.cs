using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.Domain.Entities;
using Common.Infr.Support.Pagination;
using EYSA.Restaurant.Distributed.GraphQL.Types;
using EYSA.Restaurant.Domain;
using EYSA.Restaurant.Domain.Queries;
using Common.Distributed.GraphQL.Extension;
using Common.Infr.IoC;

namespace EYSA.Restaurant.Distributed.GraphQL.Configuration
{
    public class ModuleMutation : ObjectGraphType
    {
        public ModuleMutation()
        {
        }


    }
}
