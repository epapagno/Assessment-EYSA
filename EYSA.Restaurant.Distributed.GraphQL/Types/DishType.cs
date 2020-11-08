using GraphQL.Types;
using System.Linq;
using Common.Infr.IoC;
using Common.Infr.Support.Pagination;
using EYSA.Restaurant.Domain;
using EYSA.Restaurant.Domain.Contracts;
using Common.Domain.Entities;
using EYSA.Restaurant.Domain.Queries;

namespace EYSA.Restaurant.Distributed.GraphQL.Types
{
    public class DishType : ObjectGraphType<Dish>
    {
        public DishType()
        {
            // Generación ObjectGraphType: Dish
            Field(i => i.Id);
            Field(i => i.Name);
            Field(i => i.Ingredients, type: typeof(ListGraphType<DishIngredientType>));
        }
    }
}
