using System;

namespace Members
{
    public class SchoolMember
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int phoneNumberber { get; set; }

        public SchoolMember(string name, string address, int phone)
        {
            Name = name;
            Address = address;
            phoneNumberber = phone;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, phoneNumberber: {phoneNumberber}");
        }
    }
}
