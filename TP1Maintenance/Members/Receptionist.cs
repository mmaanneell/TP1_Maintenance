using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Managers;

namespace Members
{
    public class Receptionist : Employee
    {
        static public Receptionist receptionist = new Receptionist(name: "Receptionist Initial", address: "Address Initial", phoneNumber: 123456789);

        public event EventHandler<Complaint>? ComplaintRaised;

        public Receptionist(string name, string address, int phoneNumber)
        : base(name, address, phoneNumber, JSONConfigurationManager.SalarySettings.Receptionist)
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
            complaint.ComplaintRaised = MenuHelper.AskInfoInput("Please enter your Complaint: ");

            ComplaintRaised?.Invoke(this, complaint);
        }

        public static Receptionist ReceptionistAttributes()
        {
            SchoolMember member = ActionAdd.BaseMemberAttributes();
            return new Receptionist(member.Name, member.Address, member.PhoneNumber);
        }
    }
}
