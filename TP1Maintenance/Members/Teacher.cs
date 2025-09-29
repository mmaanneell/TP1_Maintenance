using System;

namespace SchoolManager
{
    public class Teacher : SchoolMember, IPayroll
    {
        public string Subject;
        private int income;
        private int balance;

        public Teacher(string name, string address, int phoneNum, string subject = "", int income = 25000)
        : base(name, address, phoneNum)
        {
            Subject = subject;
            this.income = income;
            balance = 0;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}, Subject: {Subject}");
        }

        public void Pay()
        {
            Util.NetworkDelay.PayEntity("Teacher", Name, ref balance, income);
        }
    }
}
