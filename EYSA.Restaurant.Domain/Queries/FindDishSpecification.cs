
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
        public FindDishSpecification(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public override Expression<Func<Dish, bool>> SatisfiedBy()
        {
            Expression<Func<Dish, bool>> filter = 
                i => i.Id == Id;

            return filter;
        }
    }
}
