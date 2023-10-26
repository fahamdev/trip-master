using Application.Contracts.Persistence;
using Domain.Entities;
using Persistence.Repositories.Base;

namespace Persistence.Repositories
{
    public class TripRepository : BaseRepository<Trip>, ITripRepository
    {
        public TripRepository(TripMasterDbContext dbContext) : base(dbContext)
        {
        }


        Task<Trip> ITripRepository.GetTripWithDetails(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
