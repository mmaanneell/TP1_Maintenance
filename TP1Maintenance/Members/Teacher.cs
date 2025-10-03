using System;

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
            Subject = subject;
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
    }
}
