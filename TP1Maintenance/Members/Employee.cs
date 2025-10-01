using System;
using Helper;

namespace Members //teste 3
{
    public class Employee : SchoolMember, IPayroll
    {
        public int Income {get; set;}
        
        public int Balance { get; set; }

        public Employee(string name, string address, int phoneNum, int income)
        : base(name, address, phoneNum)
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