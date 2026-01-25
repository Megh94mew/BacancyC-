
using System;
using Emp1 = Project1.Model.Employee;
using Emp2 = Project2.Model.Employee;       

class Program
{
    static void Main()
    {
           Emp1 emp1 = new Emp1();
        emp1.Dispaly();
        Emp2 emp2 = new Emp2();
        emp2.Display();
    }
}