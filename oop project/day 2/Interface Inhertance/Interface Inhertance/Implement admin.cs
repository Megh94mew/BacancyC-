public class AdminUser : IAdminUser
{
    public int Id { get; private set; }
    public string Username { get; private set; }

    public AdminUser(int id, string username)
    {
               Id = id;
        Username = username;

    }

    public void Login()
    {
        Console.WriteLine($"{Username} logged in as Admin.");
    }
    public void ManageUsers()
    {
        Console.WriteLine("Admin is managing users.");
    }
}