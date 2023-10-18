using Application.Contracts.Persistence;
using Application.Features.Trips.Queries.GetTripDetail.DTOs;
using AutoMapper;
using MediatR;

namespace Application.Features.Trips.Queries.TripDetail
{
    public class GetTripDetailQueryHandler : IRequestHandler<GetTripDetailQuery, TripDetailResponse>
    {
        private readonly ITripRepository _tripRepository;
        private readonly IMapper _mapper;

        public GetTripDetailQueryHandler(IMapper mapper, ITripRepository tripRepository)
        {
            _mapper = mapper;
            _tripRepository = tripRepository;
        }

        public async Task<TripDetailResponse> Handle(GetTripDetailQuery request, CancellationToken cancellationToken)
        {
            var trip = await _tripRepository.GetTripWithDetails(request.Id);
            return _mapper.Map<TripDetailResponse>(trip);
        }
    }
}
