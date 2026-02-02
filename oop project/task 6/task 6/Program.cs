using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Define the Employee and Department classes
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public string City { get; set; }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }

    static void Main(string[] args)
    {
        // 1. Create a sample list of employees
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, Name = "Alice", DepartmentId = 1, City = "New York" },
            new Employee { EmployeeId = 2, Name = "Bob", DepartmentId = 2, City = "London" },
            new Employee { EmployeeId = 3, Name = "Charlie", DepartmentId = 1, City = "New York" },
            new Employee { EmployeeId = 4, Name = "David", DepartmentId = 3, City = "Paris" }
        };

        // 2. Create a sample list of departments
        List<Department> departments = new List<Department>
        {
            new Department { DepartmentId = 1, DepartmentName = "Engineering" },
            new Department { DepartmentId = 2, DepartmentName = "Sales" },
            new Department { DepartmentId = 3, DepartmentName = "Marketing" }
        };

        // 3. Write the LINQ query using an anonymous type
        var result = from emp in employees
                     join dept in departments on emp.DepartmentId equals dept.DepartmentId
                     select new // This creates the anonymous type
                     {
                         EmployeeName = emp.Name,
                         DepartmentName = dept.DepartmentName,
                         City = emp.City
                     };

        // 4. Iterate over the results and print them
        Console.WriteLine("Employee Data:");
        foreach (var item in result)
        {
            Console.WriteLine($"Name: {item.EmployeeName}, Department: {item.DepartmentName}, City: {item.City}");
        }
    }
}
