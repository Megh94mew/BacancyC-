// Query Syntax
IEnumerable<Employee> querySyntaxResult = from emp in employees
                                          where emp.Salary > 60000M
                                          orderby emp.Name
                                          select emp;

///////////////////////////////////////////////////////////////////////
// Method Syntax
IEnumerable<Employee> methodSyntaxResult = employees
                                            .Where(emp => emp.Salary > 60000M)
                                            .OrderBy(emp => emp.Name)
                                            .Select(emp => emp);
