public class Event
{
    public int Id { get; set; }

    [Required]
    public string Title { get; set; }

    public string Description { get; set; }

    public DateTime EventDate { get; set; }

    public int OrganizerId { get; set; }
    public ApplicationUser Organizer { get; set; }

    public ICollection<EventRegistration> Registrations { get; set; }
}