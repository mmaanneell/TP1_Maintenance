using System;
using System.Collections.Generic;

namespace SchoolManager
{
    public class Student : SchoolMember
    {
        private int _grade;
        private int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public Student(string name, string address, int phoneNumber, int grade)
        {
            Name = name;
            Address = address;
            Phone = phoneNumber;
            Grade = grade;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}, Grade: {Grade}");
        }

        public static double AverageGrade(List<Student> students)
        {
            double totalGradeSum = 0;
            foreach (Student student in students)
            {
                totalGradeSum += student.Grade;
            }

            return totalGradeSum / students.Count;
        }
    }
}
