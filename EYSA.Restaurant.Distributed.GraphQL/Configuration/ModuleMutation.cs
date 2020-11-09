using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.Domain.Entities;
using Common.Infr.Support.Pagination;
using EYSA.Restaurant.Distributed.GraphQL.Types;
using EYSA.Restaurant.Distributed.GraphQL.InputTypes;
using EYSA.Restaurant.Domain;
using EYSA.Restaurant.Domain.Queries;
using Common.Distributed.GraphQL.Extension;
using Common.Infr.IoC;
using System.Threading.Tasks;
using Common.Infr.Support.Helpers;

namespace EYSA.Restaurant.Distributed.GraphQL.Configuration
{
    public class ModuleMutation : ObjectGraphType
    {
        public ModuleMutation()
        {
            AddFieldCreateOrUpdateAllergen();
            AddFieldCreateOrUpdateIngredient();
            AddFieldCreateOrUpdateDish();
        }

        private void AddFieldCreateOrUpdateAllergen()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<NonNullGraphType<AllergenInputType>> { Name = "values", Description = "Alergeno" });
            arguments.Add(new QueryArgument<IntGraphType> { Name = "id", Description = "Id del Alergeno" });

            FieldAsync<AllergenType>("allergen",
                arguments: arguments,
                resolve: async context =>
                {
                    int? id = context.GetArgument<int?>("id");
                    Allergen allergen;
                    using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                    {
                        if (id.HasValue)
                        {
                            FindAllergenSpecification filter = new FindAllergenSpecification(id.Value);
                            allergen = await uow.AllergenRepository.FindAllergen(filter);

                            allergen = await UpdateAllergen(uow, allergen, context.GetArgument<Dictionary<string, object>>("values"));
                        }
                        else
                        {
                            allergen = context.GetArgument<Allergen>("values");
                            await uow.AllergenRepository.CreateAllergen(allergen);
                        }
                        
                        await uow.CommitAsync();
                    }
                    return allergen;
                });
        }

        private async Task<Allergen> UpdateAllergen(IModuleUoW uow, Allergen entity, Dictionary<string, object> properties)
        {
            var propertyVariableSetter = new PropertyVariableSetter<Allergen>(entity, properties);
            propertyVariableSetter.Assign("name", i => i.Name);
            return entity;
        }

        private void AddFieldCreateOrUpdateIngredient()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<NonNullGraphType<IngredientInputType>> { Name = "values", Description = "Ingrediente" });
            arguments.Add(new QueryArgument<IntGraphType> { Name = "id", Description = "Id del Ingrediente" });

            FieldAsync<IngredientType>("ingredient",
                arguments: arguments,
                resolve: async context =>
                {
                    int? id = context.GetArgument<int?>("id");
                    Ingredient ingredient;
                    using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                    {
                        if (id.HasValue)
                        {
                            FindIngredientSpecification filter = new FindIngredientSpecification(id.Value);
                            ingredient = await uow.IngredientRepository.FindIngredient(filter);

                            ingredient = await UpdateIngredient(uow, ingredient, context.GetArgument<Dictionary<string, object>>("values"));
                        }
                        else
                        {
                            ingredient = context.GetArgument<Ingredient>("values");
                            await uow.IngredientRepository.CreateIngredient(ingredient);
                        }

                        await uow.CommitAsync();
                    }
                    return ingredient;
                });
        }

        private async Task<Ingredient> UpdateIngredient(IModuleUoW uow, Ingredient entity, Dictionary<string, object> properties)
        {
            var propertyVariableSetter = new PropertyVariableSetter<Ingredient>(entity, properties);
            propertyVariableSetter.Assign("name", i => i.Name);
            return entity;
        }

        private void AddFieldCreateOrUpdateDish()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<NonNullGraphType<DishInputType>> { Name = "values", Description = "Plato" });
            arguments.Add(new QueryArgument<IntGraphType> { Name = "id", Description = "Id del Plato" });

            FieldAsync<DishType>("dish",
                arguments: arguments,
                resolve: async context =>
                {
                    int? id = context.GetArgument<int?>("id");
                    Dish dish;
                    using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                    {
                        if (id.HasValue)
                        {
                            FindDishSpecification filter = new FindDishSpecification(id.Value);
                            dish = await uow.DishRepository.FindDish(filter);

                            dish = await UpdateDish(uow, dish, context.GetArgument<Dictionary<string, object>>("values"));
                        }
                        else
                        {
                            dish = context.GetArgument<Dish>("values");
                            await uow.DishRepository.CreateDish(dish);
                        }

                        await uow.CommitAsync();
                    }
                    return dish;
                });
        }

        private async Task<Dish> UpdateDish(IModuleUoW uow, Dish entity, Dictionary<string, object> properties)
        {
            var propertyVariableSetter = new PropertyVariableSetter<Dish>(entity, properties);
            propertyVariableSetter.Assign("name", i => i.Name);

            if (properties.ContainsKey("ingredients"))
            {
                var dishIngredientProperties = (List<object>)properties["ingredients"];
                var dishIngredients = new List<DishIngredient>();
                foreach (var dishIngredientObj in dishIngredientProperties)
                {
                    var dishIngredient = new DishIngredient
                    {
                        DishId = entity.Id,
                        Dish = entity
                    };

                    var repStoreDetailProjectionsVariableSetter = new PropertyVariableSetter<DishIngredient>(dishIngredient, (Dictionary<string, object>)dishIngredientObj);
                    repStoreDetailProjectionsVariableSetter.Assign("id", i => i.IngredientId);

                    dishIngredients.Add(dishIngredient);
                }                
            }

            return entity;
        }
    }
}
