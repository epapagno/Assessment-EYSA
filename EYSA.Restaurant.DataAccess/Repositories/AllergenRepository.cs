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
    public class AllergenRepository : IAllergenRepository
    {
        private readonly IModuleContext context;

        public AllergenRepository(IModuleContext context)
        {
            this.context = context;
        }

        public async Task<Allergen> FindAllergen(FindAllergenSpecification filter)
        {
            IEnumerable<Allergen> result = await this.context.Allergen.Where(filter.SatisfiedBy()).ToListAsync();

            return result.OrderBy(i => i.Name).FirstOrDefault();
        }

    }
}
