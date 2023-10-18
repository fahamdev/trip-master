using Application.Contracts.Persistence.Base;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IOrganizationRepository : IAsyncRepository<Organization>
    {
        Task<List<Organization>> GetOrganizationssWithTrips(bool includePassedTrips);
    }
}
