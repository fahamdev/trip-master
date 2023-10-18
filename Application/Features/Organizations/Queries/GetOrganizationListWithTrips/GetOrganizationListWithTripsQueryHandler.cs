using Application.Contracts.Persistence;
using Application.Features.Organizations.Queries.GetOrganizationListWithTrips.DTOs;
using AutoMapper;
using MediatR;

namespace Application.Features.Organizations.Queries.GetOrganizationListWithTrips
{
    internal class GetOrganizationListWithTripsQueryHandler : IRequestHandler<GetOrganizationListWithTripsQuery, List<OrganizationTripListResponse>>
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;

        public GetOrganizationListWithTripsQueryHandler(IMapper mapper, IOrganizationRepository organizationRepository)
        {
            _mapper = mapper;
            _organizationRepository = organizationRepository;
        }

        public async Task<List<OrganizationTripListResponse>> Handle(GetOrganizationListWithTripsQuery request, CancellationToken cancellationToken)
        {
            var organizations = await _organizationRepository.GetOrganizationssWithTrips(request.includePassedTrips);
            return _mapper.Map<List<OrganizationTripListResponse>>(organizations);
        }
    }
}