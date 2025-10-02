using System;
using System.Collections.Generic;

namespace Members  
{
    public class Student : SchoolMember
    {
        private int grade;
        
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(string name = "", string address = "", int phoneNumber = 0, int grade = 0)
        : base(name, address, phoneNumber)
        {
            this.grade = grade;
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, phoneNumber: {2}, Grade: {3}", Name, Address, phoneNumber, Grade);
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
