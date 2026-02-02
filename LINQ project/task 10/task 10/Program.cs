public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}

// Create a list of employees
List<Employee> employees = new List<Employee>
{
    new Employee { EmployeeId = 1, Name = "Alice", Salary = 65000M },
    new Employee { EmployeeId = 2, Name = "Bob", Salary = 55000M },
    new Employee { EmployeeId = 3, Name = "Charlie", Salary = 72000M },
    new Employee { EmployeeId = 4, Name = "David", Salary = 48000M },
    new Employee { EmployeeId = 5, Name = "Eve", Salary = 90000M }
};
