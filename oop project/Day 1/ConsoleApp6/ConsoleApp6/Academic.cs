namespace StudentManagement
{
    public partial class Student
    {
        //Academic information //
        public string Course { get; set; }
        public string Semester { get; set; }
        public double GPA { get; set; }

        public void DisplayacademicInfo()
        {
            System.Console.WriteLine("\n--- Academic Information ---");
            System.Console.WriteLine($"Course   : {Course}");
            System.Console.WriteLine($"Semester : {Semester}");
            System.Console.WriteLine($"CGPA     : {CGPA}");
        }
    }
}