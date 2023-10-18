namespace Application.Features.Trips.Queries.GetTripDetail.DTOs
{
    public class TripPackageResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int MinQuantityPerBooking { get; set; }
        public int MaxQuantityPerBooking { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
