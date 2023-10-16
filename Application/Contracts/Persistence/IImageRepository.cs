using Application.Contracts.Persistence.Base;
using Domain.Entities;

namespace Application.Contracts.Persistence
{
    public interface IImageRepository : IAsyncRepository<Image>
    {
    }
}
