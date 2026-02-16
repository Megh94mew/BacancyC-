//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;

//public class Employee

//{
//    public int EmployeeId { get; set; }
//    public string Name { get; set; }
//    public string Department { get; set; }
//}

//public class Program
//{
//    static void Main()
//    {
//        // Create employee list.

//        List<Employee> employees = new List<Employee>

//        new Employee { EmployeeId = 1, Name = "Megh", Department = "HR" };
//        new Employee { EmployeeId = 2, Name = "Virat", Department = "IT" };
//        new Employee { EmployeeId = 3, Name = "Rohit", Department = "HR" };
//        new Employee { EmployeeId = 4, Name = "Shubham", Department = "Finance" };
//        new Employee { EmployeeId = 5, Name = "Krunal", Department = "HR" }
//    };

//    var groupedEmployees = employees
//                         .Grouped(e => e.Department)
//                         .Select(g => new
//                         {
//                             Department = g.Key,
//                             EmployeeCount = g.Count()
//                         });

//    foreach private (var group in groupedEmployees)

//        {
//          Console.WriteLine($"{group.Department} : {group.EmployeeCount}");
//        }
           
//     }
//}


// Theory: 

// This query is ussed for defrred execution because LINQ grouping 
// is a executed when the result was iterated.
// "GroupBy()" keyword and "Select()" keywrod is not execute immediately.
// query is executed only when it is "foreach".
// LINQ execution was used to improve performance, Avoid unnecessary latest data changes.
