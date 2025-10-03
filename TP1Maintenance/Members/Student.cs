using System;
using System.Collections.Generic;

namespace Members  
{
    public class Student : SchoolMember
    {
        static public List<Student> Students = new List<Student>();

        public int Grade { get; set; }

        public Student(string name = "", string address = "", int phoneNumber = 0, int grade = 0)
        : base(name, address, phoneNumber)
        {
            Grade = grade;
            Students.Add(this);
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}, Grade: {Grade}");
        }

        public void DisplayAll()
        {
            Console.WriteLine("\nThe students are:");

            foreach (Student student in Students)
            {
                student.Display();
            }
        }

        public static double CalculateAverageGrade()
        {
            double averageSum = 0;
            foreach (Student student in Students)
            {
                averageSum += student.Grade;
            }
            return averageSum / Students.Count;
        }

        public static void DisplayAveragePerformance()
        {
            double averagePerformance = CalculateAverageGrade();
            Console.WriteLine($"The student average performance is: {averagePerformance}");
        }
    }
}
