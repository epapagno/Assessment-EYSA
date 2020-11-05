using Common.Infr.Support.Pagination;
using Common.Domain.Entities;
using EYSA.Restaurant.Domain.Queries;
using System.Threading.Tasks;
using Common.Domain.CursorResult;

namespace EYSA.Restaurant.Domain.Contracts
{
    public interface IDishRepository
    {
        Task<Dish> FindDish(FindDishSpecification filter);
        Task<IPagedResult<Ingredient>> FindIngredients(FindIngredient filter, IPaginationParams<Ingredient> paginationParams);
    }
}
