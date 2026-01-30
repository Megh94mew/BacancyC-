using SOLIDApp.Interfaces;

namespace SOLIDApp.Services
{
    public class CreditCardPaymetProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Credit Card payment processed: {amount}");
        }
    }
}