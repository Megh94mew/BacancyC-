//using System;
//using System.Generics;
//using System.Linq;

//public class Employee
//{
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public string Department { get; set; }
//}
//class progrma
//{
//    static void Main(string[] arges)
//    {
//        List<Employee> employees = new List<Employee>
//        {
//            new Employee {Name = "Megh", Salary = 70000, Department =
//            "IT"},
//            new Employee {Name = "Het", Salary = 50000, Department =
//            "HR"},
//            new Employee {Name = "Dev", Salary = 30000, Department =
//            "IT"},
//            new Employee {Name = "Mitchell", Salary = 40000, Department =
//            "Account"}

//        };
//        var sortedEmployees = employees
//            .Where(emp => emp.Department == "IT")
//            .OrderByDescending(employees => employees.Salary)
//            .ThenBy(emp => emp.Name);

//        foreach (var employee in sortedEmployees)
//        {
//            Console.WriteLine($"{employee.Name}: {employee.Salary}");
//        }

//    }
// }
//