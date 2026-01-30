using SOLIDApp.Interfaces;
using SOLIDApp.Models;

namespace SOLIDApp.Business
{
    public class OrderService
    {
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly INotificationService _notificationService;
        private readonly IOrderRepository _orderRepository;

        public OrderService(
            IPaymentProcessor paymentProcessor,
            INotificationService notificationService,
            IOrderRepository orderRepository)

        {
            _paymentProcessor = paymentProcessor;
            _notificationService = notificationService;
            _orderRepository = orderRepository;
        }

        public void PlaceOrder(Order order)
        {
            _orderRepository.Save(order);
            _paymentProcessor.ProcessPayment(order.Amount);
            _notificationService.Send("Order has been placed successfully.");
        }
    }
}