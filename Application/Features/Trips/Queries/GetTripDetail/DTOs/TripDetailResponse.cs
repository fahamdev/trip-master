namespace Application.Features.Trips.Queries.GetTripDetail.DTOs
{
    public class TripDetailResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CategoryId { get; set; }
        public TripCategoryResponse Category { get; set; } = default!;
        public Guid OrganizationId { get; set; }
        public TripOrganizationResponse Organization { get; set; } = default!;
        public ICollection<TripImageResponse>? Images { get; set; }
        public ICollection<TripPackageResponse>? Packages { get; set; }
    }
}
