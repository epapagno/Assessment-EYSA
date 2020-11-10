using GraphQL.Types;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Distributed.GraphQL.Types
{
    public class AllergenType : ObjectGraphType<Allergen>
    {
        public AllergenType()
        {
            Field(i => i.Id);
            Field(i => i.Name);
            Field(i => i.Ingredient, type: typeof(IngredientAllergenType));
        }
    }
}
