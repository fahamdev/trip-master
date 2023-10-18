namespace Application.Features.Organizations.Queries.GetOrganizationListWithTrips.DTOs
{
    internal class OrganizationTripListResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public ICollection<OrganizationTripResponse>? Trips { get; set; }
    }
}
