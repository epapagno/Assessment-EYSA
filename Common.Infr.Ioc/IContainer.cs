using System;
using System.Collections.Generic;
using Common.Infr.IoC.Scopes;

namespace Common.Infr.IoC
{
    public interface IContainer : IServiceProvider
    {
        IScope Register<TIService, TService>() where TService : TIService;
        IScope Register(Type service, Type implementation);
        IScope RegisterGeneric(Type genericService, Type genericImplementation);
        IScope Register<TIService, TService>(Func<TService> func) where TService : TIService;

        TService Resolve<TService>();
        TService Resolve<TService>(IDictionary<string, object> args);
        object Resolve(Type typeService);
        IEnumerable<TService> ResolveAll<TService>();

    }
}
