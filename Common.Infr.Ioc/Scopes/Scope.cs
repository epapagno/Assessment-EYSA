using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Autofac.Builder;

namespace Common.Infr.IoC.Scopes
{
    internal class Scope<TIService, TActivatorData, TRegistrationStyle> : IScope
    {
        private IRegistrationBuilder<TIService, TActivatorData, TRegistrationStyle> registrationBuilder;

        public Scope(IRegistrationBuilder<TIService, TActivatorData, TRegistrationStyle> registrationBuilder)
        {
            this.registrationBuilder = registrationBuilder;
        }

        public void InScope(Func<object, object> scope)
        {
            throw new NotImplementedException();
        }

        public void InSingletonScope()
        {
            this.registrationBuilder.SingleInstance();
        }

        public void InHTTPRequestScope()
        {
            this.registrationBuilder.InstancePerLifetimeScope();
        }

        public void InTransientScope()
        {
            this.registrationBuilder.InstancePerDependency();
        }
    }
}
