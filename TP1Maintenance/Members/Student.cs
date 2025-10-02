using System;
using System.Collections.Generic;

namespace Members  
{
    public class Student : SchoolMember
    {
        public int Grade { get; set; }
        
        public Student(string name = "", string address = "", int phoneNumber = 0, int grade = 0)
        : base(name, address, phoneNumber)
        {
            Grade = grade;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}, Grade: {Grade}");
        }

        public static double averageGrade(List<Student> students)
        {
            double avg = 0;
            foreach (Student student in students)
            {
                avg += student.Grade;
            }
            return avg / students.Count;
        }
    }
}
