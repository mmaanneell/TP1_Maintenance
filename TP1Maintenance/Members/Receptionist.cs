using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager
{
    public class Complaint : EventArgs
    {
        public DateTime ComplaintTime { get; set; }
        public string ComplaintRaised { get; set; }
    }

    public class Receptionist : Employee
    {
        public event EventHandler<Complaint> ComplaintRaised;

        public Receptionist(string name, string address, int phoneNum, int income = 10000)
        : base(name, address, phoneNum, income)
        {

        }

        public override void Display()
        {
            Console.WriteLine("Name: {0}, Address: {1}, Phone: {2}", Name, Address, Phone);
        }

        public void HandleComplaint()
        {
            Complaint complaint = new Complaint();
            complaint.ComplaintTime = DateTime.Now;
            complaint.ComplaintRaised = Util.Console.AskQuestion("Please enter your Complaint: ");

            ComplaintRaised?.Invoke(this, complaint);
        }
    }
}
