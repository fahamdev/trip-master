using Domain.Base;

namespace Domain.Entities
{
    public class User : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public Guid OrganizationId { get; set; }
        public Organization Organization { get; set; } = default!;
    }
}
