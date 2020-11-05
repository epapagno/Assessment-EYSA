using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Infr.IoC;

namespace EYSA.Restaurant.Distributed.GraphQL.Support
{
    public class GraphQLDependencyResolver : IDependencyResolver
    {
        public T Resolve<T>() => IoCFactory.Instance.Container.Resolve<T>();

        public object Resolve(Type type) => IoCFactory.Instance.Container.Resolve(type);
    }
}
