using System;
using System.Collections.Generic;
using System.Text;

namespace cmts
{
    public class Console_Menu
    {
        private object context;

        public object Title { get; private set; }

        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Create Training Program");
                Console.WriteLine("2. Register Employee");
                Console.WriteLine("3. Enroll Employee in Training");
                Console.WriteLine("4. Show Training Details");
                Console.WriteLine("5. Show Department Report");
                Console.WriteLine("6. Update Employee Performance");
                Console.WriteLine("7. Delete Training Program");
                Console.WriteLine("8. Exit");

                int choice = int.Parse(Console.ReadLine());
                
                switch (choice)
                {
                    case 1: CreatingTraining();
                        break;
                    case 2: RegisterEmployee();
                        break;
                    case 3: EnrollmentEmployee();
                        break;
                    case 4:
                        ShowTrainingDetails();
                        break;
                    case 5:
                        ShowDepartmentReport();
                        break;
                    case 6:
                        UpdateEmployeePerformance();
                        break;
                    case 7:
                        DeleteTrainingProgram();
                        break;
                    case 8:
                        Console.WriteLine("Exiting...");
                        return;

                }
            }
                        }
        }
    }
}