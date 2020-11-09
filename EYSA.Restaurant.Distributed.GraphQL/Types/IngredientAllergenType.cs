using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Distributed.GraphQL.Types
{
    public class IngredientAllergenType : ObjectGraphType<IngredientAllergen>
    {
        public IngredientAllergenType()
        {
            Field(i => i.AllergenId);
            Field(i => i.IngredientId);
            Field(i => i.Allergen, type: typeof(AllergenType));
            Field(i => i.Ingredient, type: typeof(IngredientType));
        }
    }
}
