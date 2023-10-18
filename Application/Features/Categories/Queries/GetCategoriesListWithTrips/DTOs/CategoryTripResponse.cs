namespace Application.Features.Categories.Queries.GetCategoriesListWithTrips.DTOs
{
    public class CategoryTripResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
