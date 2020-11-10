﻿using GraphQL.Types;
using Common.Domain.Entities;

namespace EYSA.Restaurant.Distributed.GraphQL.InputTypes
{
    public class IngredientInputType : InputObjectGraphType<Ingredient>
    {
        public IngredientInputType()
        {
            Name = "IngredientInput";
            Field(i => i.Id, nullable: true);
            Field(i => i.Name);
        }
    }
}
