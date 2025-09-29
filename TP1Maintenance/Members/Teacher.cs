using System;

namespace SchoolManager
{
    public class Teacher : Employee
    {
        public string Subject;

        public Teacher(string name, string address, int phoneNum, int income = 25000, string subject ="")
        : base(name, address, phoneNum, income)
        {
            Subject = subject;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}, Subject: {Subject}");
        }

        public override void Pay()
        {
            Balance = Util.NetworkDelay.PayEntity("Teacher", Name, Balance, Income);
        }
    }
}
