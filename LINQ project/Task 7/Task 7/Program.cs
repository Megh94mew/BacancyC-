using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string DepartmentId { get; set; }
        public string City { get; set; }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
    static void Main(string[]args)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee {EmployeeId = 1, Name = "Dave", DepartmentId = 101, City = "Rajkot"},
            new Employee {EmployeeId = 2, Name = "Davin", DepartmentId = 102, City = "Surat"},
            new Employee {EmployeeId = 3, Name = "Franklin", DepartmentId = 103, City = "Rajkot"},
            new Employee {EmployeeId = 1, Name = "Trevor", DepartmentId = 104, City = "Gandhinagar"}
        };

        List<Department> departments = new List<Department>
        {
            new Department { DepartmentId = 1, DepartmentName = "Engineering"},
            new Department { DepartmentId = 2, DepartmentName = "Designer"},
            new Department { DepartmentId = 3, DepartmentName = "Accounts"}
        };

        var result = from emp in employees
                     join dept in departments on emp.DepartmentId equals dept.DepartmentId
                     select new
                     {
                         EmployeeName = emp.Name,
                         DepartmentName = dept.DepartmentName,
                         City = emp.City
                     };

        Console.WriteLine("Employee Data:");
        foreach (var item in result)
        {
            Console.WriteLine($"Name: {item.EmployeeName}, Department: {item.DepartmentName}, City: {item.City}");
        }
    }
}