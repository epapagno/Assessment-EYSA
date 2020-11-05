using System;
using Common.Infr.IoC;
using EYSA.Restaurant.DataAccess.Context;
using EYSA.Restaurant.DataAccess.Core;
using EYSA.Restaurant.DataAccess.Repositories;
using EYSA.Restaurant.Domain;
using EYSA.Restaurant.Domain.Contracts;

namespace EYSA.Restaurant.Infr.Bootstrapper
{
    public class Module
    {
        private IContainer container;
        public static Module App { get; } = new Module();
        public void Init(IContainer container)
        {
            this.container = container ?? throw new ArgumentNullException(nameof(container));
            RegisterIoC();
            //RegisterTasks();
        }

        public void RegisterIoC()
        {
            this.container.Register<IModuleContext, ModuleContext>().InTransientScope();
            this.container.Register<IModuleUoW, ModuleUoW>().InTransientScope();
            this.container.Register<IDishRepository, DishRepository>().InTransientScope();
        }
    }
}
