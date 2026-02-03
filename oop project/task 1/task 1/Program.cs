using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
    public string Department { get; set; }
}
class progrma
{
    static void Main(string[] arges)
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee {Name = "Megh", Salary = 70000, Department =
            "IT"},
            new Employee {Name = "Het", Salary = 50000, Department =
            "HR"},
            new Employee {Name = "Dev", Salary = 30000, Department =
            "IT"},
            new Employee {Name = "Mitchell", Salary = 40000, Department =
            "Account"}

        };
        var sortedEmployees = employees
            .Where(emp => emp.Department == "IT")
            .OrderByDescending(employees => employees.Salary)
            .ThenBy(emp => emp.Name);

        foreach (var employee in sortedEmployees)
        {
            Console.WriteLine($"{employee.Name}: {employee.Salary}");
        }

    }
}


// In this i have used Filttering method to filter the employ according to there salary //
// and then i have sorted them in a descending order according to there salary //
// Then by is used to see employee name as assigned new.//

//output with using ThenBy
// By using Then By the output will be:

// Megh: 70000
// Het : 50000
// Mitchell: 40000

//output without using ThenBy

// Output without using ThenBy the output will be:
// Megh: 70000
// Het : 50000
//Dev  : 30000




