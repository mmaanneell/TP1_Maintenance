using System;

namespace SchoolManager
{
    public class Principal : SchoolMember, IPayroll
    {
        private const int Income = 50000;
        private int Balance {get;}

        public Principal(string name, string address, int phone, int income, int balance)
        {
            Name = name;
            Address = address;
            Phone = phone;
            this.Income = income;
            Balance = 0;
        }

        public void display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}");
        }

        public void Pay()
        {
            Util.NetworkDelay.PayEntity("Principal", Name, ref Balance, Income);
        }
    }
}
