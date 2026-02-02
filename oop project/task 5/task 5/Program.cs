//using System;
//using System.Collections.Generic;
//using System.Linq;

//public class Students
//{
//    public int ROllNo { get; set; }
//    public string Name { get; set; }
//    public int Marks { get; set; }
//}

//public class StudentResult
//{
//    public string StudentName { get; set; }
//    public int StudentMarks { get; set; }
//    public string Result { get; set; }
//}

//public class Program
//{
//    public static void Main()
//    {
//        List<Students> students = new List<Students>
//        {
//            new Student { RollNo = 1, Name = "Dave", Marks = 55},
//            new Student { RollNo = 2, Name = "Jhon", Marks = 80},
//            new Student { RollNo = 3, Name = "Smith", Marks = 35},
//            new Student { RollNo = 4, Name = "Mary", Marks = 90},
//            new Student { RollNo = 5, Name = "Jane", Marks = 45},
//        };

//        var uqeryResult = from s in students
//                          select new StudentResult
//                          {
//                              StudentName = s.Name,
//                              StudentMarks = s.Marks,
//                              Result = (s.Marks >= 40) ? "Pass" : "Fail"
//                          };

//        var methodResults = students.Select(s => new StudentResult
//        {
//            StudentName = s.Name,
//            StudentMarks = s.Marks,
//            Result = (s.Marks >= 40) ? "Pass" : "Fail"
//        });

//        Console.WriteLine("{0,-14} {1,-11} {2,-10}", "Name", "Marks", "Result");
//        Console.WriteLine(new string('-', 35));

//        foreach (var sr in uqeryResult)
//        {
//            Console.WriteLine("{0,-14} {1,-11} {2,-10}", sr.StudentName, sr.StudentMarks, sr.Result);
//        }
//    }
//}