namespace StudentManagement
{
    public partial class Student
    {
        // Personal information //
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string DateOfBirth { get; set; }
        public string Gender { get; set; }

        public void DisplayPersonalInfo()
        {
            System.Console.WriteLine("\n--- personal information ---");
            System.Console.WriteLine($"ID       : {StudentID}");
            System.Console.WriteLine($"Name     : {FullName}");
            System.Console.WriteLine($"DOB      : {DateOfBirth}");
            System.Console.WriteLine($"Gender   : {Gender}");
        }
    }
}