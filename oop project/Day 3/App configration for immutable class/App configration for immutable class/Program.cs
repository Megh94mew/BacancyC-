using System;

public class Appconfig
{
    public string AppName { get; }
    public string Version { get; }
    public DateTime CreatedDate { get; }

    //Constructor initializes values onece//

    public Appconfig(string appName, string version, DateTime createdDate)
    {
        AppName = appName;
        Version = version;
        CreatedDate = createdDate;
    }
}
class Program
{
    static void Main()
    {
        Appconfig config = new Appconfig(
            "EmployeeManagementSystem", 
            "1.0.0",
            DateTime.Now
         );

        Console.WriteLine(config.AppName);
        Console.WriteLine(config.Version);
        Console.WriteLine(config.CreatedDate);

    }
}