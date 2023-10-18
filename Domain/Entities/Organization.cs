using Domain.Base;

namespace Domain.Entities
{
    public class Organization : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNo { get; set; } = string.Empty;
        public string AlternateEmail { get; set; } = string.Empty;
        public string AlternatePhoneNo { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public ICollection<Trip>? Trips { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
