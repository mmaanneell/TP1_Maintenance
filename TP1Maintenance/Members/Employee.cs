using System;
using Helper;

namespace Members
{
    public class Employee : SchoolMember, IPayroll
    {
        public int Income {get; set;}
        
        public int Balance { get; set; }

        public Employee(string name, string address, int phoneNumber, int income)
        : base(name, address, phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Nom vide, nom par defaut utilise");
                name = "Nom par defaut";
            }
            else
            {
                Name = name.Trim();
            }
            if (string.IsNullOrWhiteSpace(address))
            {
                Console.WriteLine("Adresse vide, adresse par defaut utilise");
                Address = "Adresse par defaut";
            }
            else
            {
                Address = address.Trim();
            }
            if (phoneNumber <= 0)
            {
                Console.WriteLine("Le numero de telephone doit etre positif. Numero par defaut utilise");
                PhoneNumber = 123456789;
            }
            else
            {
                PhoneNumber = phoneNumber;
            }
            if (income < 0)
            {
                Console.WriteLine("Income doit etre positif.");
                Income = 0;
            }
            else
            {
                Income = income;
            }
            Balance = 0;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }

        public virtual void Pay()
        {
            Balance = Helper.NetworkDelay.PayEntity("Employee", Name, Balance, Income);
        }
    }
}