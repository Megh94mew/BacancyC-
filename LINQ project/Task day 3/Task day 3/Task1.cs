//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;

//public class Employee
//{
//    public int EmployeeId { get; set; }
//    public string Name { get; set; }
//    public decimal Salary { get; set; }
//    public string Department { get; set; }
//}
//class Program
//{
//    static void Main()
//    {
//        // create a employee list //

//        List<Employee> employees = new List<Employee>
//    {
//        new Employee{ EmployeeId = 1, Name = "Megh", Salary = 45000, Department = "IT"},
//        new Employee{ EmployeeId = 2, Name = "Het", Salary = 50000, Department = "HR"},
//        new Employee{ EmployeeId = 3, Name = "Raj", Salary = 25000, Department = "It"},
//        new Employee{ EmployeeId = 4, Name = "Ashish", Salary = 30000, Department = "Finance"}
//     };

//        // LINQ Query 

//        var highSalaryEmployees = employees
//                                   .Where(e => e.Salary > 30000);

        
//          employees.Add(new Employee
//          {
//              EmployeeId = 5,
//              Name = "Niken",
//              Salary = 35000,
//              Department = "HR"
//          });

//        // Execute Query

//        foreach (var employee in highSalaryEmployees)
//        {
//            Console.WriteLine($"{employee.Name} - {employee.Salary}");
//        }


//    }
//}


////Theory:

// I have observed a "Deferred Execution" in this .
// This execution happens by using keyword "foreach".
// I have used a keyword "where" to apply a filter condition .
// here we can see that new employee name "Niken" is coming in the output because his salary is 
// above 30000.
 