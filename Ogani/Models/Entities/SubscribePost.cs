namespace Ogani.Models.Entities
{
    public class SubscribePost
    {
        public required string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ApprovedAt { get; set; }
    }

}
