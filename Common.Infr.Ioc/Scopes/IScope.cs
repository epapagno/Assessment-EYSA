using System;

namespace Common.Infr.IoC.Scopes
{
    public interface IScope
    {
        void InScope(Func<object, object> scope);
        void InSingletonScope();
        void InTransientScope();
        void InHTTPRequestScope();
    }
}
