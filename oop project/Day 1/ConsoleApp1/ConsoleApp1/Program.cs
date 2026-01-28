using System;

namespace BankAccountApp
{
    // Custom Exception//
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    // Bank Account Class //
    class BankAccount
    {
        public int AccountNumber { get; }
        public string HolderName { get; }
        public decimal Balance { get; private set; }

        public BankAccount(int accNo, string name, decimal initialBalance)
        {
            AccountNumber = accNo;
            HolderName = name;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero..");
                return;
            }
            Balance += amount;
            Console.WriteLine("Amount deposited successfully");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientBalanceException("Insufficient balance!");

            Balance -= amount;
            Console.WriteLine("Amount withdrawn successfully.");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"current Balance: rupees{Balance}");
        }

    }
    class Program
    {
        static void Main()
        {
            Console.Write("Entre Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            Console.Write("Entre Initial Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(accNo, name, balance);

            while(true)
            {
                Console.WriteLine("\n--- Bank Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Witdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option: ");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Entre amount to deposit: ");
                            account.Deposit(decimal.Parse(Console.ReadLine()));
                            break;

                        case 2:
                            Console.Write("Entre amount to withdraw:");
                            account.Withdraw(decimal.Parse(Console.ReadLine()));
                            break;

                        case 3:
                            account.DisplayBalance();
                            break;

                        case 4:
                            Console.WriteLine("Thank you for using the bank's system.");
                            return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;

                    }
                }
                catch (InsufficientBalanceException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("Transaction completed.\n");
                }
            }
        }
    }
}
