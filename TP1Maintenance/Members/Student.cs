using System;
using System.Collections.Generic;

namespace Members  
{
    public class Student : SchoolMember
    {
        private int _grade;
        
        private int Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public Student(string name = "", string address = "", int phoneNumber = 0, int grade = 0)
        : base(name, address, phoneNumber)
        {
            Grade = grade;
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, phoneNumberber: {2}, Grade: {3}", Name, Address, phoneNumberber, Grade);
        }

        public static double CalculateAverageGrade(List<Student> students)
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
