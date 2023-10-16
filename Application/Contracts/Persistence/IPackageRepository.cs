using Application.Contracts.Persistence.Base;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IPackageRepository : IAsyncRepository<Package>
    {
    }
}
