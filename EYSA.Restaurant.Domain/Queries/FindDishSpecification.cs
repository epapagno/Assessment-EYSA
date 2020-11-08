
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Common.Domain.Entities;
using Common.Infr.Specification;

namespace EYSA.Restaurant.Domain.Queries
{
    public class FindDishSpecification : Specification<Dish>, ISpecification<Dish>
    {
        public FindDishSpecification(string name, int dishId)
        {
            Name = name;
            DishId = dishId;
        }

        public int DishId { get; set; }
        public string Name { get; set; }

        public override Expression<Func<Dish, bool>> SatisfiedBy()
        {
            Expression<Func<Dish, bool>> filter = 
                i => i.Id == DishId;

            if(!string.IsNullOrEmpty(Name))
            {
                filter.And(i => i.Name.ToLower().Equals(Name.ToLower()));
            }
            

            return filter;
        }
    }
}
