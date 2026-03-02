using EF_1;
using EF_1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;

namespace EF_1.CRUD
{

    //---------------------------------Student entity----------------------------//

    public class StudentService
    {
        private readonly AppDbContext context;

        public StudentService(AppDbContext context)
        {
            this.context = context;
        }
        // Create
        public void Addstudent(string name, string email)
        {
            var student = new student
            {
                Name = name,
                Email = email,
                CreatedDate = DateTime.Now
            };
            context.Students.Add(student);
            context.SaveChanges();
        }

        // Read 

        public List<student> GetAllStudents()
        {
            return context.Students.ToList();
        }
        // Read(by Id)
        public student GetStudentById(int id)
        {
            return context.Students.Find(id);
        }

        // Update
        public void Updatestudent(int id, string name, string email)
        {
            var student = context.Students.Find(id);

            if (student != null)
            {
                student.Name = name;
                student.Email = email;
                context.SaveChanges();
            }
        }

        // Delete 
        public void Deletestudent(int id)
        {
            var student = context.Students.Find(id);

            if (student == null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        internal void AddStudent(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal static object GetAllstudents()
        {
            throw new NotImplementedException();
        }
    }









    //-------------------------------------Course Entity-----------------------------//
    public class CourseService
    {
        private readonly AppDbContext _context;

        public CourseService(AppDbContext context)
        {
            _context = context;
        }

        public void AddCourse(string title, int fees, int duration)
        {
            var course = new Course
            {
                Title = title,
                Fees = fees,
                DurationinMonths = duration
            };

            _context.Courses.Add(course);
            _context.SaveChanges();

        }
        public List<Course> GetAllCourse()
        {
            return _context.Courses.ToList();
        }

        public void UpdateCourse(int id, string title, int fees, int duration)
        {
            var course = _context.Courses.Find(id);

            if (course == null)

            {
                course.Title = title;
                course.Fees = fees;
                course.DurationinMonths = duration;
                _context.SaveChanges();

            }
        }

        public void DeleteCourse(int id)
        {
            var course = _context.Courses.Find(id);

            if (course == null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
            }
        }
    }


    //-----------------Trainer Entity------------------------//

    public class TrainerService
    {
        private readonly AppDbContext _context;

        public TrainerService(AppDbContext context)
        {
            _context = context;
        }

        public void AddTrainer(string name, int experience)
        {
            var trainer = new trainer
            {
                Name = name,
                ExperienceYears = experience
            };

            _context.Trainers.Add(trainer);
            _context.SaveChanges();
        }
        public List<trainer> GetTrainers()
        {
            return _context.Trainers.ToList();
        }

        public void UpdateTrainer(int id, string name, int experience)
        {
            var trainer = _context.Trainers.Find(id);

            if (trainer == null)
            {
                trainer.Name = name;
                trainer.ExperienceYears = experience;
                _context.SaveChanges();
            }
        }

        public void DeleteTrainer(int id)
        {
            var trainer = _context.Trainers.Find(id);

            if (trainer == null)
            {
                _context.Trainers.Remove(trainer);
                _context.SaveChanges();
            }
        }
    }
}
