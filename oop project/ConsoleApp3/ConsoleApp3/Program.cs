using System;

namespace BankAccountOOP
{
    class BankAccount
    {
        // Fields //
        private int accountNumber;
        private string holderName;
        private decimal balance;

        //constructor//
        public BankAccount(int accNo, string name, decimal initialBalance)
        {
            accountNumber = accNo;
            holderName = name;
            balance = initialBalance;
        }

        // Deposit method//
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
                return;
            }

            balance += amount;
            Console.WriteLine("Deposit successful.");
        }
        
        // Withdraw method //
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return;
            }

            balance -= amount;
            Console.WriteLine("Withdrawal successful.");
        }
        //display method //
        public void DisplayAccount()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine($"Account Number : {accountNumber}");
            Console.WriteLine($"Holder Name    : {holderName}");
            Console.WriteLine($"Balance        : {balance}");
        }
    }
    class Program
    {
        static void Main()
        {
            Console.Write("Entre Account Number: ");
            int accNo = int.Parse(Console.ReadLine());

            Console.Write("Entre Account Holder Name: ");
            string name = Console.ReadLine();

            Console.Write("Entre Initial Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            // Create object//
            BankAccount account = new BankAccount(accNo, name, balance);

            int choice;
            do
            {
                Console.WriteLine("\n--- Bank Menu ---");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Entre your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Entre amount to deposit: ");
                        account.Deposit(decimal.Parse(Console.ReadLine()));
                        break;

                    case 2:
                        Console.Write("Entre amount to withdraw: ");
                        account.Withdraw(decimal.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        account.DisplayAccount();
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
    }
}