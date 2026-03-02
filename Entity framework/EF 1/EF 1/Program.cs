using EF_1;

class Program
{
    private =static void Main()
    {
        using (var context = new AppDbContext())
        
        {
            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Course");
                Console.WriteLine("3. Show All Students");
                Console.WriteLine("4. Show All Course");
                Console.WriteLine("5. Enroll student in Course");
                Console.WriteLine("6. Create Batch");
                Console.WriteLine("7. Show Course with student");
                Console.WriteLine("8. Show trainer with Batches");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(context);
                        break;
                    case "2":
                        AddCourse(context);
                        break;
                    case "3":
                        Showstudents(context);
                        break;
                    case "4":
                        ShowCourse(context);
                        break;
                    case "5":
                        Enrollstudent(context);
                        break;
                    case "6":
                        CreateBatch(context);
                        break;
                    case "7":
                        ShowCourseWithStudent(context);
                        break;
                    case "8":
                        ShowTrainerWithBathches(context);
                        break;
                }
            }
        }
    }
}


