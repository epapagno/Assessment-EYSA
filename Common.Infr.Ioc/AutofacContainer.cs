using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Autofac.Builder;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Common.Infr.IoC.Scopes;

namespace Common.Infr.IoC
{
    public class AutofacContainer : IContainer
    {

        private readonly ContainerBuilder _builder;
        private Autofac.IContainer _autofactContainer;

        public AutofacContainer(IServiceCollection services)
        {
            _builder = new ContainerBuilder();

            if (services != null)
                _builder.Populate(services);
        }

        public IScope Register<TIService, TService>() where TService : TIService
        {
            return new Scope<TService, ConcreteReflectionActivatorData, SingleRegistrationStyle>(this._builder.RegisterType<TService>().As<TIService>());
        }

        public IScope Register(Type service, Type implementation)
        {
            return new Scope<object, ConcreteReflectionActivatorData, SingleRegistrationStyle>(this._builder.RegisterType(implementation).As(service));
        }

        public IScope RegisterGeneric(Type genericService, Type genericImplementation)
        {
            return new Scope<object, ReflectionActivatorData, DynamicRegistrationStyle>(this._builder.RegisterGeneric(genericImplementation).As(genericService));
        }

        public TService Resolve<TService>()
        {
            return GetAutofacContainer().Resolve<TService>();
        }

        public TService Resolve<TService>(IDictionary<string, object> args)
        {
            List<Autofac.Core.Parameter> parameters = new List<Autofac.Core.Parameter>();
            foreach (var item in args)
            {
                parameters.Add(new NamedParameter(item.Key, item.Value));
            }

            return GetAutofacContainer().Resolve<TService>(parameters);
        }
        public IScope Register<TIService, TService>(Func<TService> func) where TService : TIService
        {
            return new Scope<TService, SimpleActivatorData, SingleRegistrationStyle>(this._builder.Register<TService>(x => func()).As<TIService>());
        }

        public object GetService(Type serviceType)
        {
            return this.Resolve(serviceType);
        }

        public object Resolve(Type typeService)
        {
            return GetAutofacContainer().ResolveOptional(typeService);
        }

        public IEnumerable<TService> ResolveAll<TService>()
        {
            return GetAutofacContainer().Resolve<IEnumerable<TService>>();
        }

        private Autofac.IContainer GetAutofacContainer()
        {
            if (_autofactContainer == null)
                _autofactContainer = this._builder.Build();
            return _autofactContainer;

        }
    }
}
