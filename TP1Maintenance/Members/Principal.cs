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
            Console.WriteLine($"\nThe Principal's details are : \nName: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }
    }
}
