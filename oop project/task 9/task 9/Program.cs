//// Sample list of employees
//List<Employee> employees = new List<Employee>
//{
//    new Employee { EmployeeId = 1, Name = "Alice", Department = "HR", Salary = 50000 },
//    new Employee { EmployeeId = 2, Name = "Bob", Department = "Engineering", Salary = 60000 },
//    new Employee { EmployeeId = 3, Name = "Charlie", Department = "Sales", Salary = 55000 }
//};

//// LINQ query to fetch only the names
//IEnumerable<string> employeeNames = employees.Select(emp => emp.Name);

//// The result is an IEnumerable<string> (a new collection of names)
//foreach (var name in employeeNames)
//{
//    Console.WriteLine(name);
//}

//// Output:
//// Alice
//// Bob
//// Charlie

////////////////////////////////////////////////////////////////////////////


//// Using the same 'employees' list from above

//// LINQ query using query syntax
//IEnumerable<string> employeeNamesQuery = from emp in employees
//                                         select emp.Name;

//// Iterate through the results
//foreach (var name in employeeNamesQuery)
//{
//    Console.WriteLine(name);
//}
