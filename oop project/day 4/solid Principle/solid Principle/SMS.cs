using SOLIDApp.Interfaces;

namespace SOLIDApp.Services
{
    public class SmsNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}