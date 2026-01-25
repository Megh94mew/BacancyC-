using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Using Array
        Console.WriteLine("=== Student Records using Array ===");
        string[] studentArray = new string[3];
        studentArray[0] = "101 - Rahul";
        studentArray[1] = "102 - Priya";
        studentArray[2] = "103 - Aman";

        foreach (string student in studentArray)
        {
            Console.WriteLine(student);
        }

        // 2. Using List
        Console.WriteLine("\n=== Student Records using List ===");
        List<string> studentList = new List<string>();
        studentList.Add("201 - Neha");
        studentList.Add("202 - Karan");
        studentList.Add("203 - Sneha");

        foreach (string student in studentList)
        {
            Console.WriteLine(student);
        }

        // 3. Using Dictionary
        Console.WriteLine("\n=== Student Records using Dictionary ===");
        Dictionary<int, string> studentDictionary = new Dictionary<int, string>();
        studentDictionary.Add(301, "Arjun");
        studentDictionary.Add(302, "Pooja");
        studentDictionary.Add(303, "Ravi");

        foreach (var student in studentDictionary)
        {
            Console.WriteLine("ID: " + student.Key + ", Name: " + student.Value);
        }
    }
}

