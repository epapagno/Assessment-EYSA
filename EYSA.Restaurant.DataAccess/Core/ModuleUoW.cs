using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Common.DataAccess;
using EYSA.Restaurant.DataAccess.Context;
using EYSA.Restaurant.Domain;
using EYSA.Restaurant.Domain.Contracts;

namespace EYSA.Restaurant.DataAccess.Core
{
    public class ModuleUoW : UnitOfWorkBase, IModuleUoW
    {
        public ModuleUoW(ILoggerProvider loggerProvider, IConfiguration configuration)
            : base(loggerProvider, configuration)
        {

        }

        public IDishRepository DishRepository => base.GetRepository<IDishRepository>();
        public IAllergenRepository AllergenRepository => base.GetRepository<IAllergenRepository>();
        public IIngredientRepository IngredientRepository => base.GetRepository<IIngredientRepository>();

        protected override DbContext CreateContext() => new ModuleContext(base.loggerProvider, base.configuration);
    }
}
