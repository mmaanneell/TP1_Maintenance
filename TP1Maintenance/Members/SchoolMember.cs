using System;

//teste 3 s
namespace Members
{
    public class SchoolMember
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public SchoolMember(string name, string address, int phone)
        {
            Name = name;
            Address = address;
            PhoneNumber = phone;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }
    }
}
