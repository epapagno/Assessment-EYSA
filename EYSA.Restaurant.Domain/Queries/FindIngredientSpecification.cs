﻿
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
    public class FindIngredientSpecification : Specification<Ingredient>, ISpecification<Ingredient>
    {
        public FindIngredientSpecification(string name, int id)
        {
            Name = name;
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public override Expression<Func<Ingredient, bool>> SatisfiedBy()
        {
            Expression<Func<Ingredient, bool>> filter =
                i => i.Name.ToLower().Equals(Name.ToLower());

            return filter;
        }
    }
}
