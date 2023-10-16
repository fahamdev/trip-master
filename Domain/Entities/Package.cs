using Domain.Base;

namespace Domain.Entities
{
    public class Package : AuditableEntity
    {
        public Guid PackageId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int MinQuantityPerBooking { get; set; }
        public int MaxQuantityPerBooking { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public Guid TripId { get; set; }
        public Trip Trip { get; set; } = default!;
    }
}
