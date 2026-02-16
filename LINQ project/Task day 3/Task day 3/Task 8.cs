//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Task_day_3
//{
//    public class Employee
//    {
//        public int EmployeeId { get; set; }
//        public string Name { get; set; }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            List<Employee> employees = new List<Employee>
//            {
//                new Employee { EmployeeId = 1, Name = "Vansh" },
//                new Employee { EmployeeId = 2, Name = "Nihil" },
//                new Employee { EmployeeId = 3, Name = "Rohan" },
//            };
//            Dictionary<int, string> employeeDictionary =
//                employees.ToDictionary(e => e.EmployeeId, e => e.Name);

//            foreach (var item in employeeDictionary)
//            {
//                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
//            }
//        }
//    }

// Theory:

// ToDictionary() keyword is used for immediate execution method because it must read all elements.
// A dictionary were used to requires unique keys
// 