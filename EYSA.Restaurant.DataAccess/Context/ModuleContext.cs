using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.Extensions.Logging;
using Common.Domain.Entities;
using Common.DataAccess.Context;
using Microsoft.Extensions.Configuration;

namespace EYSA.Restaurant.DataAccess.Context
{
    public class ModuleContext : DbContextBase, IModuleContext
    {
        public ModuleContext(ILoggerProvider loggerProvider, IConfiguration configuration)
            : base(loggerProvider, configuration)
        {
        }
        public DbSet<Dish> Dish { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<DishIngredient> DishIngredient { get; set; }
        public DbSet<Allergen> Allergen { get; set; }
        public DbSet<IngredientAllergen> IngredientAllergen { get; set; }
    }
}
