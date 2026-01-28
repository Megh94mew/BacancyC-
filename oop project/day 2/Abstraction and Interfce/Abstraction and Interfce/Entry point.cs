class Program
{
    static void Main()
    {
        INotification email = new EmailNotification(); 
        NotificationService service1 = new NotificationService(email);
        service1.Notify("Welcome via Email");

        INotification sms = new SMSNotification();
        NotificationService service2 = new NotificationService(sms);
        service2.Notify("Welcome via SMS");
    }
}