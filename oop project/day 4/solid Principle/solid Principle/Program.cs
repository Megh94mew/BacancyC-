//using SOLIDApp.Business;
//using SOLIDApp.Models;
//using SOLIDApp.Repositories;
//using SOLIDApp.Services;

//class Program
//{
//    static void Main()
//    {
//        var paymentProcessor = new CreditCardPaymetProcessor();
//        var notificationService = new EmailNotificationService();
//        var repository = new OrderRepository();

//        var orderService = new OrderService(
//            paymentProcessor, 
//            notificationService, 
//            repository);

//        var order = new Order(1, 3600);
//        orderService.PlaceOrder(order);
//    }
//}