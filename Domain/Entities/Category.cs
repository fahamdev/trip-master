using Domain.Base;

namespace Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Trip>? Trips { get; set; }
    }
}
