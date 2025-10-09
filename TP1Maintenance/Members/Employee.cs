using System;
using Helper;

namespace Members
{
    public class Employee : SchoolMember
    {
        public int Income { get; set; }

        public int Balance { get; set; }

        public Employee(string name, string address, int phoneNumber, int income)
        : base(name, address, phoneNumber)
        {
            if (income < 0)
            {
                Console.WriteLine("Income must be positive.");
                Income = 0;
            }
            else
            {
                Income = income;
            }
            Balance = 0;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }

        public virtual void Pay()
        {
            Balance += Income;
            Console.WriteLine($"Paid Employee: {Name}. Total balance: {Balance}");
        }

    }
}