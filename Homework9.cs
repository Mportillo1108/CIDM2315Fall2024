
using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework9
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Student student1 = new Student(111, "Alice");
            Student student2 = new Student(222, "Bob");
            Student student3 = new Student(333, "Cathy");
            Student student4 = new Student(444, "David");

            
            Dictionary<string, double> gradebook = new Dictionary<string, double>()
            {
                { "Alice", 4.0 },
                { "Bob", 3.6 },
                { "Cathy", 2.5 },
                { "David", 1.8 }
            };

           
            if (!gradebook.ContainsKey("Tom"))
            {
                gradebook["Tom"] = 3.3;
            }

            
            double averageGPA = gradebook.Values.Average();
            Console.WriteLine($"Average GPA: {averageGPA:F2}");

            
            Console.WriteLine("Students with GPA greater than the average: ");
            foreach (var student in Student.student_list)
            {
                if (gradebook.ContainsKey(student.GetStudentName()) && gradebook[student.GetStudentName()] > averageGPA)
                {
                    student.PrintInfo();
                }
            }
        }
    }

    class Student
    {
        private int studentID;
        private string studentName; 

        
        public static List<Student> student_list = new List<Student>();

        
        public Student(int id, string name)
        {
            studentID = id;
            studentName = name;
            student_list.Add(this); 
        }

                public void PrintInfo()
        {
            Console.WriteLine($"Student ID: {studentID}, Name: {GetStudentName()}");
        }

        
         public string GetStudentName() => studentName; 
    }
}
