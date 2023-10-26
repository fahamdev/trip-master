using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories.Base;

namespace Persistence.Repositories
{
    public class OrganizationRepository : BaseRepository<Organization>, IOrganizationRepository
    {
        public OrganizationRepository(TripMasterDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<Organization>> GetOrganizationssWithTrips(bool includePassedTrips)
        {
            var allOrganizations = await _dbcontext.Organizations.Include(o => o.Trips).ToListAsync();
            if (!includePassedTrips)
            {
                allOrganizations.ForEach(o => o.Trips.ToList().RemoveAll(t => t.StartDate < DateTime.Today));
            }
            return allOrganizations;
        }
    }
}
