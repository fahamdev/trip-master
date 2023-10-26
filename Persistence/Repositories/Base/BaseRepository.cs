using Application.Contracts.Persistence.Base;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories.Base
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : class
    {
        protected readonly TripMasterDbContext _dbcontext;

        public BaseRepository(TripMasterDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _dbcontext.Set<T>().AddAsync(entity);
            await _dbcontext.SaveChangesAsync();

            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _dbcontext.Set<T>().Remove(entity);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbcontext.Set<T>().ToListAsync();
        }

        public virtual async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbcontext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _dbcontext.Entry(entity).State = EntityState.Modified;
            await _dbcontext.SaveChangesAsync();
        }
    }
}
