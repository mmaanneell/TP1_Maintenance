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
                Console.WriteLine("Nom vide, nom par defaut utilise");
                Name = "NomParDefaut";
            }
            else
            {
                Name = name.Trim();
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Adresse vide, adresse par defaut utilise");
                Address = "AdresseParDefaut";
            }
            else
            {
                Address = address.Trim();
            }
            if (phoneNumber <= 0)
            {
                Console.WriteLine("Numéro de téléphone invalide, numéro par défaut utilise");
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
