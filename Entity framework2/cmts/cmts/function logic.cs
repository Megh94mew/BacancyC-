//using cmts;
//using DocumentFormat.OpenXml.InkML;
//using DocumentFormat.OpenXml.Office2010.Excel;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Runtime.InteropServices.Marshalling;
//using System.Text;

//namespace cmts
//{
//    public class function_logic
//    {
//        var exists = context.TrainingPrograms
//             .Any(t => t.Title == title);

//        if (exists)
//        {
//            Console.WriteLine("Training title already exists");
//            return;

//        }

//         var emailExists = context.Employees
//             .Any(e => e.Email == email);

//        if (emailExists)
//        {
//            Console.WriteLine("Email already exists");
//            return;
//        }
//     var alreadyEnrolled = context.Enrollments
//    .Any(e => e.EmployeeId == empId
//     && e.TrainingProgramId == programId);

//    if (alreadyEnrolled)
//{
//    Console.WriteLine("Employee already enrolled!");
//    return;
//}

//  var enrollment = new Enrollment
//  {
//    EmployeeId = empId,
//    TrainingProgramId = programId,
//    EnrollmentDate = DateTime.Now,
//    PerformanceScore = 0
//};
//    }
//}
//var training = context.TrainingPrograms
//    .Include(t => t.Trainer)
//    .Include(t => t.Enrollments)
//        .ThenInclude(e => e.Employee)
//            .ThenInclude(emp => emp.Department)
//    .FirstOrDefault(t => t.Id == id);

//if there are no employees
//  if (!training.Enrollments.Any())
//{
//    Console.WriteLine("No employees enrolled yet.");
//}
// if (score > 100)
//    using DocumentFormat.OpenXml.InkML;
//using DocumentFormat.OpenXml.Office2010.Excel;

//{
//    Console.WriteLine("Score cannot exceed 100!");
//    return;
//}

//var enrollment = context.Enrollments
//    .FirstOrDefault(e => e.EmployeeId == empId
//                      && e.TrainingProgramId == programId);

//enrollment.PerformanceScore = score;
//context.SaveChanges();
//var training = context.TrainingPrograms.Find(id);

//using DocumentFormat.OpenXml.InkML;

//context.TrainingPrograms.Remove(training);
//context.SaveChanges();

//var training = context.TrainingPrograms.Find(id);

//context.TrainingPrograms.Remove(training);
//context.SaveChanges();
