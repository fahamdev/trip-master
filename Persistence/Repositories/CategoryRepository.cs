using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Repositories.Base;

namespace Persistence.Repositories
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TripMasterDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Category>> GetCategoriesWithTrips(bool includePassedTrips)
        {
            var allCategories = await _dbcontext.Categories.Include(c => c.Trips).ToListAsync();

            if (!includePassedTrips)
            {
                allCategories.ForEach(c => c.Trips.ToList().RemoveAll(t => t.StartDate < DateTime.Today));
            }
            return allCategories;
        }
    }
}
