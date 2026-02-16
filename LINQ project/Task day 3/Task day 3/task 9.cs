using System;
using System.Collections.Generic;
using System.Linq;

// Employee class
public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        // Step 1: Create employee list
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Amit", Department = "IT" },
            new Employee { EmployeeId = 2, Name = "Neha", Department = "HR" },
            new Employee { EmployeeId = 3, Name = "Ravi", Department = "IT" }
        };

        // Step 2: Create LINQ query (IT department)
        var itEmployeesQuery = employees
                                .Where(e => e.Department == "IT");

        // Step 3: Print first time
        Console.WriteLine("First print:");
        foreach (var emp in itEmployeesQuery)
        {
            Console.WriteLine(emp.Name);
        }

        // Step 4: Print second time
        Console.WriteLine("\nSecond print:");
        foreach (var emp in itEmployeesQuery)
        {
            Console.WriteLine(emp.Name);
        }

        // Step 5: Update one employee department (IT → HR)
        employees.First(e => e.Name == "Ravi").Department = "HR";

        // Step 6: Print after update
        Console.WriteLine("\nAfter updating department:");
        foreach (var emp in itEmployeesQuery)
        {
            Console.WriteLine(emp.Name);
        }
    }
}
