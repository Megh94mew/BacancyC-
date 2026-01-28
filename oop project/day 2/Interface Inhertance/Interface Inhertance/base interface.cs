public interface IUser
{
    int Id { get; }
    string Username { get; }

    void Login();
}