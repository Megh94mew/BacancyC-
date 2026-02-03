//public class Employee
//{
//    public int EmployeeId { get; set; }
//    public string Name { get; set; }
//    public string Department { get; set; }
//    public decimal Salary { get; set; }
//}

//List<Employee> employees = new List<Employee>
//{
//    new Employee { EmployeeId = 1, Name = "Megh", Department = "IT", Salary = 30000 },
//    new Employee { EmployeeId = 2, Name = "Amit", Department = "HR", Salary = 25000 },
//    new Employee { EmployeeId = 3, Name = "Riya", Department = "IT", Salary = 35000 },
//    new Employee { EmployeeId = 4, Name = "Neha", Department = "HR", Salary = 28000 },
//    new Employee { EmployeeId = 5, Name = "Arjun", Department = "Finance", Salary = 40000 }
//};
//var departmentStats =
//  from emp in employees
//  group emp by emp.Department into deptGroup
//  select new
//  {
//      Department = deptGroup.Key,
//      EmployeeCount = deptGroup.Count(),
//      AverageSalary = deptGroup.Average(e => e.Salary)
//  };
//foreach (var dept in departmentStats)
//{
//    Console.WriteLine(
//        $"Department: {dept.Department}, " +
//        $"Employees: {dept.EmployeeCount}, " +
//        $"Average Salary: {dept.AverageSalary}"
//    );
//}


// here first from keyword is used to iterate through collection and declarative and alternative for foreach Data.
// group by was used to categorize data and to similarize SQL group by to produce Igrouping<TKey, TElement> keyword.
// into will help us to stores the grouped results for the further operations. It can be enable aggretions after grouping.
// Key this keyword represented for the grouping key. And it holds the department name
// Aggregation Method was used Like: Count() this is used for Total of employees . Average() this was used to calcualte the mean salary. Sum() Sum keyword helps up to find out the total salary of the employees.
// Lambda expression (e => e.Salary) This helps to use specify which property to aggregate and makes the code concise and readable.
// Anonymouse type is used for tempory result projection. to avoid creation of a extra class.for improving the maintainability.
// Deferred Execution helps to iterate the query which is execuyed.
//
//