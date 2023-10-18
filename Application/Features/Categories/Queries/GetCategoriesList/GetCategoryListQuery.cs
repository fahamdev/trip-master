using Application.Features.Categories.Queries.GetCategoriesList.DTOs;
using MediatR;

namespace Application.Features.Categories.Queries.GetCategoriesList
{
    public class GetCategoryListQuery : IRequest<List<CategoryListResponse>>
    {
    }
}
