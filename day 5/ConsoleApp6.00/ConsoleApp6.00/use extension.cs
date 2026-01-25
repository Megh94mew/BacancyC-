using System;

class Program
{
    static void Main()
    {
        string word = "Sir";

        // Calling extension method like a built - in string method//
        bool result = word.IsPalindrome();

        Console.WriteLine("Stirng value:");
        Console.WriteLine(word);

        Console.WriteLine("\nIs Palindrome?:");
        Console.WriteLine(result);

        Console.ReadLine();



    }
}