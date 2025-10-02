using System;
using System.Collections.Generic;

namespace Members  
{
    public class Student : SchoolMember
    {
        private int _grade;
        
        public int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public Student(string name = "", string address = "", int phoneNumber = 0, int grade = 0)
        : base(name, address, phoneNumber)
        {
            _grade = grade;
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, phoneNumber: {2}, Grade: {3}", Name, Address, phoneNumber, Grade);
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
