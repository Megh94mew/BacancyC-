using System;
using System.Collections.Generic;
using System.Linq;

// Define the Employee class
public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

public class LinqExample
{
     static void Main()
    {
        // Sample list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Megh", Salary = 45000M },
            new Employee { EmployeeId = 2, Name = "Bob", Salary = 25000M },
            new Employee { EmployeeId = 3, Name = "Mitchell", Salary = 55000M },
            new Employee { EmployeeId = 4, Name = "David", Salary = 30000M },
            new Employee { EmployeeId = 5, Name = "Het", Salary = 32000M }
        };

        // --- Method 1: Query Syntax (Recommended for complex queries) ---
        IEnumerable<Employee> filteredAndSortedQuery =
            from emp in employees
            where emp.Salary > 30000M
            orderby emp.Salary ascending
            select emp;

        // --- Method 2: Method Syntax (Lambda Expressions) ---
        IEnumerable<Employee> filteredAndSortedMethod =
            employees
            .Where(emp => emp.Salary > 30000M)
            .OrderBy(emp => emp.Salary);

        // --- Display the results (using Method 2 results in this example) ---
        Console.WriteLine("Employees with salary > 30000 (sorted by salary):");
        foreach (var employee in filteredAndSortedMethod)
        {
            Console.WriteLine($"ID: {employee.EmployeeId}, Name: {employee.Name}, Salary: {employee.Salary:C}");
        }
    }
}
