namespace Application.Features.Categories.Queries.GetCategoriesListWithTrips.DTOs
{
    public class CategoryTripListResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<CategoryTripResponse>? Trips { get; set; }
    }
}
