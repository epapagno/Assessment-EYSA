using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Entities;

namespace EYSA.Restaurant.DataAccess.Context
{
    public interface IModuleContext
    {
        DbSet<Dish> Dish { get; }
        DbSet<Ingredient> Ingredient { get; }
        DbSet<Allergen> Allergen { get; }
        DbSet<DishIngredient> DishIngredient { get; }

    }
}
