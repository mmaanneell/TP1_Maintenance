using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManager
{
    public class Receptionist : SchoolMember, IPayroll
    {
        private int _income;
        private int _balance;
        public event EventHandler<Complaint> ComplaintRaised;

        public Receptionist(int income = 10000) 
        {
            _income = income;
            _balance = 0;
        }

        public Receptionist(string name, string address, int phoneNumber, int income = 10000)
        {
            Name = name;
            Address = address;
            Phone = phoneNumber;
            _income = income;
            _balance = 0;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Address: {Address}, Phone: {Phone}");
        }

        public void Pay()
        {
            Util.NetworkDelay.PayEntity("Receptionist", Name, ref _balance, _income);
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
