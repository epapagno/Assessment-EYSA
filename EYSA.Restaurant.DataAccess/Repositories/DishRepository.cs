using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Domain.Entities;
using Common.DataAccess;
using Common.Infr.Support.Pagination;
using EYSA.Restaurant.DataAccess.Context;
using EYSA.Restaurant.Domain.Contracts;
using EYSA.Restaurant.Domain.Queries;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Common.Domain.CursorResult;

namespace EYSA.Restaurant.DataAccess.Repositories
{
    public class DishRepository : IDishRepository
    {
        private readonly IModuleContext context;

        public DishRepository(IModuleContext context)
        {
            this.context = context;
        }

        public async Task<Dish> FindDish(FindDishSpecification filter)
        {
            IEnumerable<Dish> result = await this.context.Dish.Include(dd => dd.Ingredients).Where(filter.SatisfiedBy()).ToListAsync();

            return result.OrderBy(i => i.Name).FirstOrDefault();
        }

    }
}
