
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Common.Domain.Entities;
using Common.Infr.Specification;

namespace EYSA.Restaurant.Domain.Queries
{
    public class FindIngredientSpecification : Specification<Ingredient>, ISpecification<Ingredient>
    {
        public FindIngredientSpecification(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public override Expression<Func<Ingredient, bool>> SatisfiedBy()
        {
            Expression<Func<Ingredient, bool>> filter =
                i => i.Id == Id;

            return filter;
        }
    }
}
