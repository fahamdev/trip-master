using Application.Contracts.Persistence;
using Application.Features.Trips.DTOs;
using AutoMapper;
using MediatR;

namespace Application.Features.Trips.Queries
{
    public class GetTripsListQueryhandler : IRequestHandler<GetTripsListQuery, List<TripsListResponse>>
    {
        private readonly ITripRepository _tripRepository;
        private readonly IMapper _mapper;

        public GetTripsListQueryhandler(ITripRepository tripRepository, IMapper mapper)
        {
            _tripRepository = tripRepository;
            _mapper = mapper;
        }

        public async Task<List<TripsListResponse>> Handle(GetTripsListQuery request, CancellationToken cancellationToken)
        {
            var trips = (await _tripRepository.GetAllAsync()).OrderBy(x => x.StartDate);
            return _mapper.Map<List<TripsListResponse>>(trips);
        }
    }
}
