public class NormalUser : IUser
{
    public int Id { get; private set; }
    public string Username { get; private set; }

    public NormalUser(int id, string username)
    {
               Id = id;
        Username = username;

    }

    public void Login()
    {
        Console.WriteLine($"{Username} logged in as User");
    }
}