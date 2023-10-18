using Application.Contracts.Persistence.Base;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithTrips(bool includePassedTrips);
    }
}
