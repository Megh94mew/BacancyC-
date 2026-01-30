using SOLIDApp.Interfaces;

namespace SOLIDApp.Services
{
    public class  PaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Payment processed: {amount}");
        }
    }
}