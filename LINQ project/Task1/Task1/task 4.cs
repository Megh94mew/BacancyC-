//public class Employee
//{
//    public int EmployeeId { get; set; }
//    public string Name { get; set; }
//    public string Department { get; set; }
//}

//    new List<Employee> employees = new List<Employee>
//{
//    new Employee { EmployeeId = 1, Name = "Megh", Department = "IT" },
//    new Employee { EmployeeId = 2, Name = "Amit", Department = "HR" },
//    new Employee { EmployeeId = 3, Name = "Riya", Department = "IT" },
//    new Employee { EmployeeId = 4, Name = "Neha", Department = "HR" },
//    new Employee { EmployeeId = 5, Name = "Arjun", Department = "Finance" }
//};

//    var sortedEmployees =
//    from emp in employees
//    orderby emp.Department, emp.Name
//    select emp;


// from is Used to iterate over a data source
// Provides a readable, SQL-like structure
// orderby is Used to sort data Supports multiple sorting keys Default order is ascending
// Multiple Sorting Keys First key (Department) defines primary order
//Second key (Name) defines secondary order within groups
