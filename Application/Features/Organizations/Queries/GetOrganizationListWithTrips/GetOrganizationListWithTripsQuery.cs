using Application.Features.Organizations.Queries.GetOrganizationListWithTrips.DTOs;
using MediatR;

namespace Application.Features.Organizations.Queries.GetOrganizationListWithTrips
{
    public class GetOrganizationListWithTripsQuery : IRequest<List<OrganizationTripListResponse>>
    {
        public bool includePassedTrips { get; set; }
    }
}
