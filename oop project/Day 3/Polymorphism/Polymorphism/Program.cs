using System;
#region Base Class 
public class PaymentProcessor
{
    public virtual void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing generic payment of {amount}");
    }

    public virtual void ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Processing payment of {amount} {currency}");
    }
}
#endregion

#region Credit Card Payment
public class CreditCardPayment : PaymentProcessor
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Credit Card payment of {amount} processed successfully.");
    }
    public override void ProcessPayment(decimal amount, string currency)
    {
        Console.WriteLine($"Credit Card payment of {amount} {currency} processed.");
    }
}
#endregion

class Program
{
    static void Main()
    {
        PaymentProcessor creditCard = new CreditCardPayment();
        PaymentProcessor upi = new UPIPayment();

        creditCard.ProcessPayment(500);
        creditCard.ProcessPayment(1000, "INR");

        upi.ProcessPayment(2000);  
    }
}