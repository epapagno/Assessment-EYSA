using EYSA.Restaurant.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Common.Domain.Core;

namespace EYSA.Restaurant.Domain
{
    public interface IModuleUoW : IUnitOfWork
    {
        IDishRepository DishRepository { get; }
        IIngredientRepository IngredientRepository { get; }
        IAllergenRepository AllergenRepository { get; }
    }
}
