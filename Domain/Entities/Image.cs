using Domain.Base;

namespace Domain.Entities
{
    public class Image : AuditableEntity
    {
        public string Path { get; set; } = string.Empty;
        public bool IsUploaded { get; set; }
        public Guid TripId { get; set; }
        public Trip Trip { get; set; } = default!;


    }
}
