using System;
using Managers;

namespace Members
{
    public class Principal : Employee
    {
        static public Principal principal = new Principal(name: "Initial Principal", address: "Initial Address", phoneNumber: 123456789);


        public Principal(string name, string address, int phoneNumber)
        : base(name, address, phoneNumber, JSONConfigurationManager.SalarySettings.Principal)
        {
        }

        public override void Display()
        {
            Console.WriteLine($"\nName: {Name}, \nAddress: {Address}, \nPhoneNumber: {PhoneNumber}");
        }
        public static Principal PrincipalAttributes()
        {
            SchoolMember member = ActionAdd.BaseMemberAttributes();
            return new Principal(member.Name, member.Address, member.PhoneNumber);
        }
    }
}
