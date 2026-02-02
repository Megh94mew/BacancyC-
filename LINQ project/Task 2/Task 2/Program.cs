using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

}
public class program
{
    public static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { EmployeeId = 1, Name = "Megh", Department = "IT", Salary = 60000M },
            new Employee { EmployeeId = 2, Name = "Mitchell", Department = "HR", Salary = 50000M },
            new Employee { EmployeeId = 3, Name = "Het", Department = "IT", Salary = 75000M },
            new Employee { EmployeeId = 4, Name = "David", Department = "Sales", Salary = 62000M },
        };

    }
}