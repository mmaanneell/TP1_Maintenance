using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Members  
{
    public class Receptionist : Employee
    {
        public event EventHandler<Complaint>? ComplaintRaised;

        public Receptionist(string name, string address, int phoneNumber, int income = 10000)
        : base(name, address, phoneNumber, income)
        {

        }

        public override void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }

        public void HandleComplaint()
        {
            Complaint complaint = new Complaint();
            complaint.ComplaintTime = DateTime.Now;
            complaint.ComplaintRaised = ConsoleHelper.AskInfoInput("Please enter your Complaint: ");

            ComplaintRaised?.Invoke(this, complaint);
        }
    }
}
