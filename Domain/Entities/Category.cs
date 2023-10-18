using Domain.Base;

namespace Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Trip>? Trips { get; set; }
    }
}
