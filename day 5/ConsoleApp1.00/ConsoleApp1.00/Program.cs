using System;
using System.Collections.Generic;
using System.Linq; 

class LambdaExpressions 
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 3, 7, 4, 12, 9, 6, 20 };

        // 1. Filteer even numbers//
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

        // 2. Find maximum value//
        int maxValue = numbers.Max();
        Console.WriteLine("Max Value: " + maxValue);

        // 3. Sort the collection (ascending)
        var sortedNumbers = numbers.OrderBy(n => n);
        Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));
    }
}