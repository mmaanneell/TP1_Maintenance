using System;

namespace Members //teste 3 
{
    public class Principal : Employee
    {

        public Principal(string name, string address, int phoneNum, int income = 50000)
        : base(name, address, phoneNum, income)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, PhoneNumber: {2}", Name, Address, PhoneNumber);
        }
    }
}
