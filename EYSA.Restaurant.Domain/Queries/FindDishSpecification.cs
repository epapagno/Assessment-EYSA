
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
        public FindDishSpecification(string dishName, int dishId)
        {
            DishName = dishName;
            DishId = dishId;
        }

        public int DishId { get; set; }
        public string DishName { get; set; }

        public override Expression<Func<Dish, bool>> SatisfiedBy()
        {
            Expression<Func<Dish, bool>> filter = 
                i => i.Id == DishId;

            if(string.IsNullOrEmpty(DishName))
            {
                filter.And(i => i.Name.ToLower().Equals(DishName.ToLower()));
            }
            

            return filter;
        }
    }
}
