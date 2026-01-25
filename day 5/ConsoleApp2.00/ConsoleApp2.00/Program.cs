using System;

class Program
{
    static void Main()
    {
        //Enum usage//
        OrderStatus status = OrderStatus.Processing;
        Console.WriteLine("Order Status: " + status);

        //Struct behavior (Value Type)//
        Coordinate c1 = new Coordinate(10, 20);
        Coordinate c2 = c1;

        c2.X = 50;

        Console.WriteLine("Struct Values:");
        c1.Display();
        c2.Display()


        PointClass p1 = new PointClass { X = 10, Y = 20 };
        PointClass p2 = p1;

        p2.X = 50

        Console.WriteLine("Class Values:");
        Console.WriteLine($"p1 -> X: {p1.X},Y:{p1.Y}");
        Console.WriteLine($"p2 -")
    }

}
