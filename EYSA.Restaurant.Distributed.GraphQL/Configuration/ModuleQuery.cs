using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Domain.Entities;
using Common.Infr.Support.Pagination;
using EYSA.Restaurant.Distributed.GraphQL.Types;
using EYSA.Restaurant.Domain;
using EYSA.Restaurant.Domain.Queries;
using Common.Distributed.GraphQL.Extension;
using Common.Infr.IoC;

namespace EYSA.Restaurant.Distributed.GraphQL.Configuration
{
    public class ModuleQuery : ObjectGraphType
    {
        public ModuleQuery()
        {
            AddFieldDish();
            AddFieldIngredient();
            AddFieldAllergen();
        }

        private void AddFieldDish()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<StringGraphType> { Name = "name", Description = "Nombre del Plato" });
            arguments.Add(new QueryArgument<IntGraphType> { Name = "id", Description = "Identificador del Plato" });

            FieldAsync<DishType>(name: "dish", description: "Dishes", resolve: async (ResolveFieldContext<object> context) =>
            {
                FindDishSpecification filter = new FindDishSpecification(context.GetArgument<string>("name"), context.GetArgument<int>("id"));
                using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                {
                    return await uow.DishRepository.FindDish(filter);
                }
            }, arguments: arguments);
        }

        private void AddFieldIngredient()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<StringGraphType> { Name = "name", Description = "Nombre del Ingredient" });
            arguments.Add(new QueryArgument<IntGraphType> { Name = "id", Description = "Identificador del Ingrediente" });

            FieldAsync<IngredientType>(name: "ingredient", description: "Ingredient", resolve: async (ResolveFieldContext<object> context) =>
            {
                FindIngredientSpecification filter = new FindIngredientSpecification(context.GetArgument<string>("name"), context.GetArgument<int>("id"));
                using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                {
                    return await uow.IngredientRepository.FindIngredient(filter);
                }
            }, arguments: arguments);
        }

        private void AddFieldAllergen()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<StringGraphType> { Name = "name", Description = "Nombre del Alergeno" });
            arguments.Add(new QueryArgument<IntGraphType> { Name = "id", Description = "Identificador del Plato" });

            FieldAsync<AllergenType>(name: "allergen", description: "Allergens", resolve: async (ResolveFieldContext<object> context) =>
            {
                FindAllergenSpecification filter = new FindAllergenSpecification(context.GetArgument<string>("name"), context.GetArgument<int>("id"));
                using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                {
                    return await uow.AllergenRepository.FindAllergen(filter);
                }
            }, arguments: arguments);
        }

    }
}
