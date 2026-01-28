class Program
{
    static void Main()
    {
        IUser user = new NormalUser(1, "Mewada");
        user.Login();

        IAdminUser admin = new AdminUser(2, "admin_Ronaldo");
        admin.Login();
        admin.ManageUsers();
    }
}