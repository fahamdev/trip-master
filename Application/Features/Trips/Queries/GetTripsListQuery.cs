using Application.Features.Trips.DTOs;
using MediatR;

namespace Application.Features.Trips.Queries
{
    public class GetTripsListQuery : IRequest<List<TripsListResponse>>
    {
    }
}
