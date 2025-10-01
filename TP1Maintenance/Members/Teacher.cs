using System;

namespace SchoolManager
{
    public class Teacher : Employee
    {
        public string Subject { get; set;}
        private const int DefaultIncome = 25000;
        public Teacher(string name, string address, int phoneNum, int income = DefaultIncome, string subject ="")
        : base(name, address, phoneNum, income)
        {
            Subject = subject;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}, Subject: {Subject}");
        }

    }
}
