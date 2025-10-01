using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace Members //teste 3 
{
    public class Receptionist : Employee
    {
        public event EventHandler<Complaint>? ComplaintRaised;

        public Receptionist(string name, string address, int phoneNum, int income = 10000)
        : base(name, address, phoneNum, income)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, PhoneNumber: {2}", Name, Address, PhoneNumber);
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
