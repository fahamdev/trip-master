using Application.Contracts.Persistence.Base;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface ITripRepository : IAsyncRepository<Trip>
    {
        Task<List<Trip>> GetTripWithDetails(Guid id);
    }
}
