public class ApplicationUser
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; } //Admin, Organizer, Attendee

    public ICollection<EventRegistration> Registrations { get; set; }
}