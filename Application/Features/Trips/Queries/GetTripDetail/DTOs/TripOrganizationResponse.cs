namespace Application.Features.Trips.Queries.GetTripDetail.DTOs
{
    public class TripOrganizationResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
    }
}
