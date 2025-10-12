using System;

namespace Members
{
    public class SchoolMember
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }

        public SchoolMember(string name, string address, int phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name is empty, using default name");
                Name = "DefaultName";
            }
            else
            {
                Name = name.Trim();
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Address is empty, using default address");
                Address = "DefaultAddress";
            }
            else
            {
                Address = address.Trim();
            }
            if (phoneNumber <= 0)
            {
                Console.WriteLine("Invalid phone number, using default number");
                PhoneNumber = 123456789;
            }
            else
            {
                PhoneNumber = phoneNumber;
            }
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }
    }
}
