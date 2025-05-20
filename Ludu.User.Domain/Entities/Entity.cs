namespace Ludu.User.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            CreatedAt = DateTime.UtcNow;
        }
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public void UpdateTimestamp()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}
