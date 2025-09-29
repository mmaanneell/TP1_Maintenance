using System;

namespace SchoolManager
{
    public class Teacher : SchoolMember, IPayroll
    {
        public string Subject;
        private int income;
        private int balance;

        public Teacher(string name, string address, int phoneNum, string subject = "", int income = 25000)
        {
            Name = name;
            Address = address;
            Phone = phoneNum;
            Subject = subject;
            this.income = income;
            balance = 0;
        }

        public void display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, Phone: {2}, Subject: {3}", Name, Address, Phone, Subject);
        }

        public void Pay()
        {

            List<Task> payments = new List<Task>();

            foreach (Teacher teacher in Program.Teachers)
            {
                Task payment = new Task(()=>
                    Util.NetworkDelay.PayEntity("Teacher", teacher.Name, ref teacher.balance, teacher.income));
                payments.Add(payment);
                payment.Start();  

            }

            Task.WaitAll(payments.ToArray());



        }
    }
}
