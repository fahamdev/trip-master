using Domain.Base;

namespace Domain.Entities
{
    public class Trip : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; } = default!;
        public ICollection<Package>? Packages { get; set; }
        public ICollection<Image>? Images { get; set; }


    }
}
