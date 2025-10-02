using System;
using System.Collections.Generic;

namespace Members  
{
    public class Student : SchoolMember
    {
        public int Grade { get; set;}

        public Student(string name = "", string address = "", int phoneNumber = 0, int grade = 0)
        : base(name, address, phoneNumber)
        {
            Grade = grade;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}, Grade: {Grade}");
        }

        public static double CalculateAverageGrade(List<Student> students)
        {
            double averageSum = 0;
            foreach (Student student in students)
            {
                averageSum += student.Grade;
            }
            return averageSum / students.Count;
        }
    }
}
