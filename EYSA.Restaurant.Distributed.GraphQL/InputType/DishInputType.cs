using GraphQL.Types;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Distributed.GraphQL.InputTypes
{
    public class DishInputType : InputObjectGraphType<Dish>
    {
        public DishInputType()
        {
            Name = "DishInput";
            Field(i => i.Id, nullable: true);
            Field(i => i.Name);
            Field(i => i.Ingredients, type: typeof(ListGraphType<IngredientInputType>), nullable: true);
        }
    }
}
