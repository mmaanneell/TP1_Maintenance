namespace SchoolManager
{
    public class SchoolMember
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public SchoolMember(string name, string address, int phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}");
        }
    }
}
