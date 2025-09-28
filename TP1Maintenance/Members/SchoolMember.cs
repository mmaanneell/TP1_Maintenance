namespace SchoolManager
{
    public class SchoolMember
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }

        public SchoolMember(string name = "", string address = "", int phone = 0)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }
    }
}
