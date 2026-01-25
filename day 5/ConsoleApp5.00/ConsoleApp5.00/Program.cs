using System;

class BoxingUnboxing
{
    static void Main()
    {
        //Value type
        int number = 100;
        Console.WriteLine("Original value type:");
        Console.WriteLine($"Number = {number}");

        //Boxing: int -> object
        object boxedNumber = number;
        Console.WriteLine("\nAfter Boxing:");
        Console.WriteLine($"boxedNumber = {boxedNumber}");

        //Modify original value type
        number = 350;
        Console.WriteLine("\nAfter modifying original value type:");
        Console.WriteLine($"number = {number}");
        Console.WriteLine($"BoxedNumber (unchanged) = {boxedNumber}");

        //Unboxing:object -> int
        int unboxedNumber = (int)boxedNumber;
        Console.WriteLine("\nAfter Unboxing:");
        Console.WriteLine($"unboxedNumber = {unboxedNumber}");

        Console.ReadLine();
    }   
}