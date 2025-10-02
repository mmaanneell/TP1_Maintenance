using System;
using Helper;

namespace Members
{
    public class Employee : SchoolMember, IPayroll
    {
        public int Income {get; set;}
        
        public int Balance { get; set; }

        public Employee(string name, string address, int phoneNumber, int income)
        : base(name, address, phoneNumber)
        {
            Income = income;
            Balance = 0;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }

        public virtual void Pay()
        {
            Balance = Helper.NetworkDelay.PayEntity("Employee", Name, Balance, Income);
        }
    }
}