public class EventRegistration
{
    public int Id { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }

    public int UserId { get; set; }
    public ApplicationUser User { get; set; }

    public DateTime RegisteredAt { get; set; }
}