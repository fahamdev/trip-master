using Application.Contracts.Persistence;
using Application.Features.Categories.Queries.GetCategoriesListWithTrips.DTOs;
using AutoMapper;
using MediatR;

namespace Application.Features.Categories.Queries.GetCategoriesListWithTrips
{
    public class GetCategoryListWithTripsQueryHandler : IRequestHandler<GetCategoryListWithTripsQuery, List<CategoryTripListResponse>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryListWithTripsQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryTripListResponse>> Handle(GetCategoryListWithTripsQuery request, CancellationToken cancellationToken)
        {
            var categories = await _categoryRepository.GetCategoriesWithTrips(request.IncludePassedTrips);
            return _mapper.Map<List<CategoryTripListResponse>>(categories);
        }
    }
}
