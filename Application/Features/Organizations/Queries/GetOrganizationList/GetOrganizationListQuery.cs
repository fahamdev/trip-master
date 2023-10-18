using Application.Features.Organizations.Queries.GetOrganizationList.DTOs;
using MediatR;

namespace Application.Features.Organizations.Queries.GetOrganizationList
{
    public class GetOrganizationListQuery : IRequest<List<OrganizationListResponse>>
    {
    }
}
