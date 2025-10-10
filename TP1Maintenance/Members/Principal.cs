using System;
using Managers;

namespace Members
{
    public class Principal : Employee
    {
        static public Principal principal = new Principal(name: "Initial Principal", address: "Initial Address", phoneNumber: 123456789);


        public Principal(string name, string address, int phoneNumber, int income = 50000)
        : base(name, address, phoneNumber, income)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"\nThe Principal's details are : \nName: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }
        public static Principal PrincipalAttributes()
        {
            SchoolMember member = ActionAdd.BaseMemberAttributes();
            return new Principal(member.Name, member.Address, member.PhoneNumber);
        }
    }
}
