using System;

class Program
{
    // Account variables (procedural style)
    static int accountNumber;
    static string holderName;
    static decimal balance;

    static void Main()
    {
        // Initialize account
        Console.Write("Enter Account Number: ");
        accountNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Account Holder Name: ");
        holderName = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        balance = decimal.Parse(Console.ReadLine());

        int choice;

        do
        {
            Console.WriteLine("\n--- Bank Menu ---");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Deposit();
                    break;

                case 2:
                    Withdraw();
                    break;

                case 3:
                    DisplayBalance();
                    break;

                case 4:
                    Console.WriteLine("Thank you for using the bank system.");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 4);
    }

    // Deposit function
    static void Deposit()
    {
        Console.Write("Enter amount to deposit: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be greater than zero.");
            return;
        }

        balance += amount;
        Console.WriteLine("Deposit successful.");
    }

    // Withdrawal function
    static void Withdraw()
    {
        Console.Write("Enter amount to withdraw: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        if (amount <= 0)
        {
            Console.WriteLine("Withdrawal amount must be greater than zero.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance!");
            return;
        }

        balance -= amount;
        Console.WriteLine("Withdrawal successful.");
    }

    // Display balance
    static void DisplayBalance()
    {
        Console.WriteLine("\n--- Account Details ---");
        Console.WriteLine($"Account Number : {accountNumber}");
        Console.WriteLine($"Holder Name    : {holderName}");
        Console.WriteLine($"Balance        : ₹{balance}");
    }
}
