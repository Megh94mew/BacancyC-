using System;

namespace EmployeeHierarchy
{
    public class Employee
    {
        public string Name { get; set; }
        public string EmployeeId { get; set; }

        public virtual decimal CalcualteSalary()
        {
            return 0
        }
    }

    public class FullTimeEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }
        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }
    }

    public class ContractEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public override decimal CalculateSalary()
        {
            return HourlyRate * HoursWorked;
        }
    }
    class Program
    {
        static void Main()
        {
            Employee emp1 = new FullTimeEmployee
            {
                Name = "Mewada",
                EmployeeId = 94,
                MonthlySalary = 5000m
            };
            Employee emp2 = new ContractEmployee
            {
                Name = "Kohli",
                EmployeeId = 102,
                HourlyRate = 50m,
                HoursWorked = 120,
            };

            Console.WriteLine($"Full Time Salary: {emp1.CalculateSalary()}");
            Console.WriteLine($"Contract Salary: {emp2.CalculateSalary()}");
        }
    }
}