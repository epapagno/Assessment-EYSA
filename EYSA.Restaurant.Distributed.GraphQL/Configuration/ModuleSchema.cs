using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Infr.IoC;
using EYSA.Restaurant.Distributed.GraphQL.Support;

namespace EYSA.Restaurant.Distributed.GraphQL.Configuration
{
    public class ModuleSchema : Schema
    {
        public ModuleSchema() : base()        
        //public ModuleSchema() : base(new GraphQLDependencyResolver())
        {
            Query = IoCFactory.Instance.Container.Resolve<ModuleQuery>();
            Mutation = IoCFactory.Instance.Container.Resolve<ModuleMutation>();
        }
    }
}
