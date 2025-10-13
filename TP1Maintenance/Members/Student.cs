using System;
using System.Collections.Generic;
using Managers;

namespace Members
{
    public class Student : SchoolMember
    {
        static public List<Student> Students = new List<Student>();
        public int Grade { get; set; }

        public Student(string name, string address, int phoneNumber, int grade = 0)
        : base(name, address, phoneNumber)
        {
            int minGrade = JSONConfigurationManager.GradeSettings.MinGrade;
            int maxGrade = JSONConfigurationManager.GradeSettings.MaxGrade;

            if (grade < minGrade || grade > maxGrade)
            {
                Console.WriteLine($"Grade must be between {minGrade} and {maxGrade}. Defaulting to {minGrade}.");
                Grade = minGrade;
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
            SchoolMember member = ActionAdd.BaseMemberAttributes();
            int grade = MenuHelper.AskNumberInput("\n-> Enter grade: ");

            return new Student(member.Name, member.Address, member.PhoneNumber, grade);
        }
    }
}
