using System;
using System.Collections.Generic;
using Managers;

namespace Members
{
    public class Student : SchoolMember
    {
        static public List<Student> Students = new List<Student>();

        private const int MinGrade = 0;
        private const int MaxGrade = 100;
        public int Grade { get; set; }

        public Student(string name, string address, int phoneNumber, int grade = 0)
        : base(name, address, phoneNumber)
        {
            if (grade < MinGrade || grade > MaxGrade)
            {
                Console.WriteLine("Grade must be between 0 and 100. Defaulting to 0.");
                Grade = 0;
            }
            else
            {
                Grade = grade;
            }
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
            if (Students.Count == 0)
            {
                Console.WriteLine("No students available to calculate average.");
                return 0;
            }

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

        public static Student StudentAttributes()
        {
            SchoolMember member = SchoolMemberManager.BaseMemberAttributes();
            int grade = MenuHelper.AskNumberInput("Enter grade: ");

            return new Student(member.Name, member.Address, member.PhoneNumber, grade);
        }
    }
}
