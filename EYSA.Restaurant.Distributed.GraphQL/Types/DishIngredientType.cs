using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Distributed.GraphQL.Types
{
    public class DishIngredientType : ObjectGraphType<DishIngredient>
    {
        public DishIngredientType()
        {
            // Generación ObjectGraphType: SYS_USERS_NOTIFICATIONS
            Field(i => i.DishId);
            Field(i => i.IngredientId);
            Field(i => i.Dish, type: typeof(DishType));
            Field(i => i.Ingredient, type: typeof(IngredientType));
        }
    }
}
