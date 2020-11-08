using Common.Infr.Support.Pagination;
using Common.Domain.Entities;
using EYSA.Restaurant.Domain.Queries;
using System.Threading.Tasks;
using Common.Domain.CursorResult;

namespace EYSA.Restaurant.Domain.Contracts
{
    public interface IIngredientRepository
    {
        Task<Ingredient> FindIngredient(FindIngredientSpecification filter);
    }
}
