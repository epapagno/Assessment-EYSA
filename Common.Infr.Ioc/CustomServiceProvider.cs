using System;

namespace Common.Infr.IoC
{
    public class CustomServiceProvider : IServiceProvider
    {
        public CustomServiceProvider() { }

        public object GetService(Type serviceType) => IoCFactory.Instance.Container.Resolve(serviceType);
    }
}
