using Application.Contracts.Persistence;
using Application.Features.Organizations.Queries.GetOrganizationList.DTOs;
using AutoMapper;
using MediatR;

namespace Application.Features.Organizations.Queries.GetOrganizationList
{
    public class GetOrganizationListQueryHandler : IRequestHandler<GetOrganizationListQuery, List<OrganizationListResponse>>
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly IMapper _mapper;

        public GetOrganizationListQueryHandler(IMapper mapper, IOrganizationRepository organizationRepository)
        {
            _mapper = mapper;
            _organizationRepository = organizationRepository;
        }

        public async Task<List<OrganizationListResponse>> Handle(GetOrganizationListQuery request, CancellationToken cancellationToken)
        {
            var organizations = (await _organizationRepository.GetAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<OrganizationListResponse>>(organizations);
        }
    }
}
