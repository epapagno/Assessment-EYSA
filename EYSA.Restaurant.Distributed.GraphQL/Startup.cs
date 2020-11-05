using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphiQl;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Common.Infr.IoC;
using Common.Infr.Logger;
using EYSA.Restaurant.Distributed.GraphQL.Configuration;
using EYSA.Restaurant.Distributed.GraphQL.Types;
using EYSA.Restaurant.Domain;
using EYSA.Restaurant.Domain.Contracts;
using EYSA.Restaurant.Infr.Bootstrapper;

namespace EYSA.Restaurant.Distributed.GraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            IoCFactory.Instance.Container = new AutofacContainer(services);

            IoCFactory.Instance.Container.Register<ISchema, ModuleSchema>().InSingletonScope();
            IoCFactory.Instance.Container.Register<ModuleQuery, ModuleQuery>().InSingletonScope();
            IoCFactory.Instance.Container.Register<IDocumentExecuter, DocumentExecuter>().InSingletonScope();
            IoCFactory.Instance.Container.Register<DishType, DishType>().InSingletonScope();
            IoCFactory.Instance.Container.Register<DishIngredientType, DishIngredientType>().InSingletonScope();
            IoCFactory.Instance.Container.Register<IngredientType, IngredientType>().InSingletonScope();
            IoCFactory.Instance.Container.Register<ModuleMutation, ModuleMutation>().InSingletonScope();
            Module.App.Init(IoCFactory.Instance.Container);

            return IoCFactory.Instance.Container;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddProvider(new Log4netProvider("log4net.config"));

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQl("/api/graphql");

            app.UseMvc();
        }
    }
}
