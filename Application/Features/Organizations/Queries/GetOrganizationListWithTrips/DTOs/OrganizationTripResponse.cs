namespace Application.Features.Organizations.Queries.GetOrganizationListWithTrips.DTOs
{
    internal class OrganizationTripResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
