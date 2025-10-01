using System;

namespace Members 
{
    public class Principal : Employee
    {

        public Principal(string name, string address, int phoneNumber, int income = 50000)
        : base(name, address, phoneNumber, income)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, phoneNumberber: {2}", Name, Address, phoneNumberber);
        }
    }
}
