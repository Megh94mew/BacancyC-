public class SystemService : ILogging, IAuditing
{
    void ILogging.Log()
    {
        Console.WriteLine("Logging system activity.");
    }
    void IAuditing.Log()
    {
        Console.WriteLine("Auditing system operation.");
    }
}