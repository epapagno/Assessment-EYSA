
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
    public class FindIngredient : Specification<Ingredient>, ISpecification<Ingredient>
    {
        public FindIngredient(string ingredientName)
        {
            IngredientName = ingredientName;
        }

        public string IngredientName { get; set; }

        public override Expression<Func<Ingredient, bool>> SatisfiedBy()
        {
            Expression<Func<Ingredient, bool>> filter =
                i => i.Name.ToLower().Equals(IngredientName.ToLower());

            return filter;
        }
    }
}
