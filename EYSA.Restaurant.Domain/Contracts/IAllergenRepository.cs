using Common.Infr.Support.Pagination;
using Common.Domain.Entities;
using EYSA.Restaurant.Domain.Queries;
using System.Threading.Tasks;
using Common.Domain.CursorResult;

namespace EYSA.Restaurant.Domain.Contracts
{
    public interface IAllergenRepository
    {
        Task<Allergen> FindAllergen(FindAllergenSpecification filter);
        Task<Allergen> CreateAllergen(Allergen allergen);
    }
}
