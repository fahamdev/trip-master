namespace Application.Features.Trips.DTOs
{
    public class TripsListResponse
    {
        public Guid TripId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CategoryId { get; set; }
        public Guid OrganizationId { get; set; }
    }
}
