using System;

namespace Members 
{
    public class Teacher : Employee
    {
        public string Subject;

        public Teacher(string name, string address, int phoneNumber, int income = 25000, string subject ="")
        : base(name, address, phoneNumber, income)
        {
            Subject = subject;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, phoneNumberber: {phoneNumberber}, Subject: {Subject}");
        }
    }
}
