using System;

namespace SchoolManager
{
    public class Teacher : SchoolMember, IPayroll
    {
        public string Subject { get; set; }
        private int Income { get; }

        // La propriété Balance a été faite ainsi pour permettre d'appeler "_balance" en ref dans la méthode Pay
        private int _balance;
        public int Balance  
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        public Teacher(string name, string address, int phoneNumber, string subject = "", int income = 25000)
        {
            Name = name;
            Address = address;
            Phone = phoneNumber;
            Subject = subject;
            Income = income;
            Balance = 0;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}, Subject: {Subject}");
        }

        public void Pay()
        {
            Util.NetworkDelay.ProcessPayment("Teacher", Name, ref _balance, Income);
        }
    }
}
