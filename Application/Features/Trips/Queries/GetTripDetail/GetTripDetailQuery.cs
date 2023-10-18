using Application.Features.Trips.Queries.GetTripDetail.DTOs;
using MediatR;

namespace Application.Features.Trips.Queries.TripDetail
{
    public class GetTripDetailQuery : IRequest<TripDetailResponse>
    {
        public Guid Id { get; set; }
    }
}
