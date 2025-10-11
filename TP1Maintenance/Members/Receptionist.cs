using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;
using Managers;

namespace Members
{
    public class Receptionist : Employee
    {
        static public Receptionist receptionist = new Receptionist(name: "Receptionist Initial", address: "Address Initial", phoneNumber: 123456789);

        public event EventHandler<Complaint>? ComplaintRaised;

        public Receptionist(string name, string address, int phoneNumber, int income = 10000)
        : base(name, address, phoneNumber, income)
        {

        }

        public override void Display()
        {
            Console.WriteLine($"\nThe Receptionist's details are : \nName: {Name}, Address: {Address}, PhoneNumber: {PhoneNumber}");
        }

        public void HandleComplaint()
        {
            Complaint complaint = new Complaint();
            complaint.ComplaintTime = DateTime.Now;
            complaint.ComplaintRaised = ConsoleHelper.AskInfoInput("Please enter your Complaint: ");

            ComplaintRaised?.Invoke(this, complaint);
        }

        public static Receptionist ReceptionistAttributes()
        {
            SchoolMember member = ActionAdd.BaseMemberAttributes();
            return new Receptionist(member.Name, member.Address, member.PhoneNumber);
        }
    }
}
