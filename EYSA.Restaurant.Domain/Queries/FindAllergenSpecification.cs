
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Common.Domain.Entities;
using Common.Infr.Specification;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Domain.Queries
{
    public class FindAllergenSpecification : Specification<Allergen>, ISpecification<Allergen>
    {
        public FindAllergenSpecification(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public override Expression<Func<Allergen, bool>> SatisfiedBy()
        {
            Expression<Func<Allergen, bool>> filter =
                i => i.Id == Id;

            return filter;
        }
    }
}
