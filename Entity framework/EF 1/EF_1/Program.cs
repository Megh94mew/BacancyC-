using EF_1;
using EF_1.Model;

class Program
{
    private static void Main()
    {
        using (var context = new AppDbContext())
        {
            var StudentService = new 
            var courseService = new CourseService(context);
            var trainerService = new TrainerService(context);

            studentService.AddStudent()
        }
    }
    