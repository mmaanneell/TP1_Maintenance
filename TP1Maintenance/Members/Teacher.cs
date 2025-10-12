using System;
using System.Collections.Generic;
using Managers;

namespace Members
{
    public class Teacher : Employee
    {
        static public List<Teacher> Teachers = new List<Teacher>();
        public string Subject { get; set; }

        public Teacher(string name, string address, int phoneNumber, string subject = "")
        : base(name, address, phoneNumber, JSONConfigurationManager.SalarySettings.Teacher)
        {
            if (string.IsNullOrWhiteSpace(subject))
            {
                Console.WriteLine("Subject is empty, using default subject.");
                Subject = "DefaultSubject";
            }
            else
            {
                Subject = subject.Trim();
            }
            Teachers.Add(this);
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}, Subject: {Subject}");
        }

        public override void Pay()
        {
            Balance += Income;
            Console.WriteLine($"Paid Teacher: {Name}. Total balance: {Balance}");
        }

        public static Teacher TeacherAttributes()
        {
            SchoolMember member = ActionAdd.BaseMemberAttributes();
            string subject = MenuHelper.AskInfoInput("Enter subject: ");

            return new Teacher(member.Name, member.Address, member.PhoneNumber, subject);
        }
    }
}
