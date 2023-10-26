using Application.Contracts.Persistence.Base;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface ITripRepository : IAsyncRepository<Trip>
    {
        Task<Trip> GetTripWithDetails(Guid id);
    }
}
