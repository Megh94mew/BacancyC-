using System;
using System.Runtime.InteropServices.Marshalling;

namespace PrimeNumberProjecet
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Write("Entre the number you want to check:");
            int number;
            number = Convert.ToInt32(Console.ReadLine
                ());
            int divisors = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisors++;
                }
            }

            if (divisors == 2)
            {
                Console.WriteLine("The entered number is a prime number");
            }
            else
            {
                Console.WriteLine("The entred number is not a prime number");
            }
            Console.ReadLine();

        }
        static void Guess()

        {
            int secret = 7;
            int num = 0;


            while (num != secret)
            {
                Console.Write("Enter your guess: ");
                num = int.Parse(Console.ReadLine());

                if (num > secret)
                    Console.WriteLine("Too high");
                else if (num < secret)
                    Console.WriteLine("Too low");
                else
                    Console.WriteLine($"Your guess is correct: {num}");
            }
        }
        static void coll()
        {
            List<string> names = new List<string>()
        {
            "abc", "bcd", "cde"
        };

            Console.WriteLine("Names in collection:");
            foreach (string i in names)
            {
                Console.WriteLine(i);
            }
        }
    }
}






