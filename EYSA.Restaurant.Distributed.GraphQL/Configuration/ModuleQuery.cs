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
        }

        private void AddFieldDish()
        {
            QueryArguments arguments = new QueryArguments();

            arguments.Add(new QueryArgument<StringGraphType> { Name = "name", Description = "Nombre del Plato" });
            arguments.Add(new QueryArgument<StringGraphType> { Name = "id", Description = "Identificador del Plato" });

            FieldAsync<DishType>(name: "dish", description: "Dishes", resolve: async (ResolveFieldContext<object> context) =>
            {
                FindDishSpecification filter = new FindDishSpecification(context.GetArgument<string>("username"), context.GetArgument<int>("id"));
                using (var uow = IoCFactory.Instance.Container.Resolve<IModuleUoW>())
                {
                    return await uow.DishRepository.FindDish(filter);
                }
            }, arguments: arguments);
        }

    }
}
