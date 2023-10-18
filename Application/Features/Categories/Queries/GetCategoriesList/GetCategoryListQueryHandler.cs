using Application.Contracts.Persistence;
using Application.Features.Categories.Queries.GetCategoriesList.DTOs;
using AutoMapper;
using MediatR;

namespace Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoryListQueryHandler : IRequestHandler<GetCategoryListQuery, List<CategoryListResponse>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoryListQueryHandler(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public async Task<List<CategoryListResponse>> Handle(GetCategoryListQuery request, CancellationToken cancellationToken)
        {
            var catagories = (await _categoryRepository.GetAllAsync()).OrderBy(x => x.Name);
            return _mapper.Map<List<CategoryListResponse>>(catagories);
        }
    }
}
