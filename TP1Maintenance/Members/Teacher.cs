using System;
using System.Collections.Generic;
using Helper;

namespace Members 
{
    public class Teacher : Employee
    {
        static public List<Teacher> Teachers = new List<Teacher>();
        public string Subject { get; set; }
        private const int DefaultIncome = 25000;
        public Teacher(string name, string address, int phoneNumber, int income = DefaultIncome, string subject = "")
        : base(name, address, phoneNumber, income)
        {
            if (string.IsNullOrWhiteSpace(subject))
            {
                Console.WriteLine("Subject is empty, using default subject.");
                Subject = "DefaultSubject";
            }
            else
            {
                Subject = subject.Trim();
            }
            Teachers.Add(this);
        }

        public override void Display()
        {
            Console.WriteLine("\nThe teachers are:");

            foreach (Teacher teacher in Teachers)
            {
                teacher.DisplayOneTeacher();
            }
        }

        public void DisplayOneTeacher()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}, Subject: {Subject}");
        }

        public override void Pay()
        {
            Balance += Income;
            Console.WriteLine($"Paid Teacher: {Name}. Total balance: {Balance}");
        }

        public static void PayAll()
        {
            Console.WriteLine("\nPayment in progress for teachers...");

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
