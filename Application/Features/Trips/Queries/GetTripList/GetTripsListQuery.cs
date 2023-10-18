using Application.Features.Trips.Queries.GetTripList.DTOs;
using MediatR;

namespace Application.Features.Trips.Queries.TripList
{
    public class GetTripsListQuery : IRequest<List<TripsListResponse>>
    {
    }
}
