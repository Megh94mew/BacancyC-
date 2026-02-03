
//public class Employee;
//{
//   public int EmployeeId { get; set; }
//   public string Name { get; set; }
//   public  string Department { get; set; }
//   public decimal Salary { get; set; }
//}

//List<Employee> employees = new List<Employee>
//{
//    new Employee {EmployeeId = 1, Name = "Megh", Department = "IT", Salary = 50000},
//    new Employee {EmployeeId = 2, Name = "David", Department = "HR", Salary = 30000},
//    new Employee {EmployeeId = 3, Name = "Sam", Department = "IT", Salary = 70000},
//    new Employee {EmployeeId = 4, Name = "Rohan", Department = "HR", Salary = 40000},
//    new Employee {EmployeeId = 5, Name = "Vicky", Department = "Finance", Salary = 35000}
//};
//decimal highestSalary = employees.Max(e => e.Salary);
//decimal lowestSalary = employees.Min(e => e.Salary);
//decimal totalSalary = employees.Sum(e => e.Salary);
//decimal averageSalary = employees.Average(e => e.Salary);

//var employeeCountByDepartment =
//    employees


//    .GroupBy(e => e.Department)
//    .Select(global => new

//    {
//        Department = g.Key,
//        Count = g.Count()
//    });

//{
//    Console.WriteLine($"Highest Salary: {highestSalary}");
//    Console.WriteLine($"Lowest Salary: {lowestSalary}");
//    Console.WriteLine($"Total Salary: {totalSalary}");
//    Console.WriteLine($"Average Salary: {averageSalary}");

//    Console.WriteLine("\nEmployees per Department:");
//    foreach ( var item in employeeCountByDepartment)

//    {
//        Console.WriteLine($"(item.Department) : {item.Count}");
//    }
//}


// In this I hsve used firstly is Max() --> this I have used to find the highest / maximum salary efficiency of the employees from the list .
// then I have used is Min() --> this was used for finding the value of the lowest salary employees.
// then I have used Sum() --> for calculating the total salary of the employees
// Average() keyword was used for calculating the mean salary for the employee
// GroupedBy() keyword were used to demostrate the group employees from department.
// Count() this keyword has been used to count employee in each group like:(it,hr,finance,etc)
// (=>) sign is called lambda expression and i used for a logic and concise way.
