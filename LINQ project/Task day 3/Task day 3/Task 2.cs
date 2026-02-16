using System;
using System.Collections.Generic;
using System.Linq;

// defining the student class 

public class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public string Marks { get; set; }



    // create a student list.

    List<Student> students = new List<Student>()
 { 
    new Student { RollNo = 1, Name = "Mewada", Marks = 50},
    new Student{ RollNo = 2, Name = "Neel", Marks = 35},
    new Student{ RollNo = 3, Name = "Het", Marks = 76},
    new Student{ RollNo = 4, Name = "Rajkumar", Marks = 30},
 };
    var query = students.Where(s => s.Marks > 40);

    List<Student> storedResult = Queryable.ToList();

    // marrks to be updated of one student {30 -> 80} 
    students.First(s => s.Marks == 30).Marks = 80;

     Console.WriteLine("")

}

