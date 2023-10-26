using Application.Features.Categories.Queries.GetCategoriesListWithTrips.DTOs;
using MediatR;

namespace Application.Features.Categories.Queries.GetCategoriesListWithTrips
{
    public class GetCategoryListWithTripsQuery : IRequest<List<CategoryTripListResponse>>
    {
        public bool IncludePassedTrips { get; set; }
    }
}
