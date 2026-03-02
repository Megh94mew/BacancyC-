using EF_1.Data;
using EF_1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_1;
   
//--------------Adding student----------------//
static void Addstudent(AppDbContext context)
{
    var student = new student
    {
        Name = "Test",
        Email = "test@gmail.com"
    };

    context.Students.Add(student);
    context.SaveChanges();


    Console.WriteLine("student added successfully");
}


//--------------Enrolling student---------------//

