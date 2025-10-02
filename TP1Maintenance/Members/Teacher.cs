using System;

namespace Members 
{
    public class Teacher : Employee
    {
        public string Subject { get; set; }

        static public List<Teacher> Teachers = new List<Teacher>();

        private const int DefaultIncome = 25000;
        public Teacher(string name, string address, int phoneNumber, int income = DefaultIncome, string subject = "")
        : base(name, address, phoneNumber, income)
        {
            Subject = subject;
        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}, Subject: {Subject}");
        }

        public override void Pay()
        {
            List<Task> payments = new List<Task>();

            foreach (Teacher teacher in Teachers)
            {
                Task payment = new Task(teacher.Pay);
                payments.Add(payment);
                payment.Start();
            }

            Task.WaitAll(payments.ToArray());
        }
    }
}
