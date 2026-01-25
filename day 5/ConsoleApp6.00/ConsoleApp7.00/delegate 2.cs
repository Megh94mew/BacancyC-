using System;

class Calculator
{
    public static void Add(int x, int y)
    {
        Console.WriteLine($"Addition: {x + y}");
    }

    public static void Subtract(int x, int y)
    {
        Console.WriteLine($"Subtraction: {x - y}");
    }

    public static void Multiply(int x, int y)
    {
        Console.WriteLine($"Multiplication: {x * y}");
    }
}