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

namespace EYSA.Restaurant.Distributed.GraphQL.Configuration
{
    public class ModuleMutation : ObjectGraphType
    {
        public ModuleMutation()
        {
            AddFieldCreateAllergen();
        }

        private void AddFieldCreateAllergen()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<NonNullGraphType<AllergenInputType>> { Name = "values", Description = "Alergeno" });
            arguments.Add(new QueryArgument<IntGraphType> { Name = "id", Description = "Id del Alergeno" });
            arguments.Add(new QueryArgument<StringGraphType> { Name = "name", Description = "nombre del Alergeno" });

            FieldAsync<AllergenType>("allergen",
                arguments: arguments,
                resolve: async context =>
                {
                    int? id = context.GetArgument<int?>("id");
                    Allergen allergen = new Allergen();
                    using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                    {
                        /*if (id.HasValue)
                        {
                            GetAllergenSpecification filter = new GetAllergenSpecification(id.Value);
                            allergen = await uow.AllergenRepository.GetAllergen(filter);

                            allergen = await UpdateRepStores(uow, repStores, context.GetArgument<Dictionary<string, object>>("values"));
                        }
                        else
                        {
                            allergen = context.GetArgument<Allergen>("values");
                            await uow.RepStoresRepository.CreateAllergen(repStores);
                        }
                        
                        await uow.CommitAsync();*/
                    }
                    return allergen;
                });
        }
    }
}
