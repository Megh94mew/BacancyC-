using System;

// Custom Exception
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException(string message) : base(message)
    {
    }
}

// Bank Account Class
public class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        try
        {
            if (amount > Balance)
            {
                throw new InsufficientBalanceException(
                    "Withdrawal failed: Insufficient balance."
                );
            }

            Balance -= amount;
            Console.WriteLine("Withdrawal successful.");
            Console.WriteLine("Amount withdrawn: " + amount);
            Console.WriteLine("Remaining balance: " + Balance);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed. Logged at: " + DateTime.Now);
        }
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(5000);

        Console.WriteLine("Initial Balance: " + account.Balance);

        Console.WriteLine("\nAttempting withdrawal of 3000");
        account.Withdraw(3000);

        Console.WriteLine("\nAttempting withdrawal of 3000");
        account.Withdraw(3000);
    }
}

