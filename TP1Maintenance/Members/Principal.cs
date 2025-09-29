using System;

namespace SchoolManager
{
    public class Principal : SchoolMember, IPayroll
    {
        private const int Income = 50000;
        private int _balance;
        private int Balance
        {
            get { return _balance; }
            set { _balance = 0; }
        }


        public Principal(string name, string address, int phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public void display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}");
        }

        public void Pay()
        {
            Util.NetworkDelay.PayEntity("Principal", Name, ref _balance, Income);
        }
    }
}
