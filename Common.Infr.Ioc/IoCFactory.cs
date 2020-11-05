using System;

namespace Common.Infr.IoC
{
    public sealed class IoCFactory
    {
        private static IContainer _container = null;
        private IoCFactory() { }

        public static IoCFactory Instance { get; } = new IoCFactory();

        public IContainer Container
        {
            get { return _container; }
            set
            {
                if (_container != null)
                {
                    throw new InvalidOperationException("El container ya fue establecido");
                }
                _container = value;
            }
        }
    }
}
