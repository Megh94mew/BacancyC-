using System;

class Program
{
    static void MAin()
    {

        //Assign methods to delegate//
        Operation op = Calculator.Add;
        op += Calculator.Subtract;
        op += Calculator.Multiply;

        //Invoke delegate (dynamic method execution)//
        Console.WriteLine("Invoking delegate:\n");
        op(10, 5);

        Console.ReadLine();
    }
}