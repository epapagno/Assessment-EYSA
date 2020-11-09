using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Distributed.GraphQL.Types
{
    public class IngredientType : ObjectGraphType<Ingredient>
    {
        public IngredientType()
        {
            Field(i => i.Id);
            Field(i => i.Name);
            Field(i => i.Allergens, type: typeof(ListGraphType<AllergenType>));
            Field(i => i.Dishes, type: typeof(ListGraphType<DishIngredientType>));
        }        
    }
}
