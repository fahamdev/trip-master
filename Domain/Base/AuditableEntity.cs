namespace Domain.Base
{
    public class AuditableEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? LastUpdateddBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
