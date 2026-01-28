public class AppConfig
{
    public string AppName { get; }
    public string Version { get; }
    public DateTime CreatedDate { get; }

    public AppConfig(string appName, string version, DateTime createdDate)
    {
        AppName = appName;
        Version = version;
        CreatedDate = createdDate;
    }
}