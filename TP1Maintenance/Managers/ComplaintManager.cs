using System;
using Members;

namespace Managers
{
    public static class ComplaintManager
    {
        public static void RaiseComplaint(Receptionist receptionist)
        {
            receptionist.HandleComplaint();
        }

        public static void HandleComplaintRaised(object sender, Complaint complaint)
        {
            Console.WriteLine("\nThis is a confirmation that we received your complaint. The details are as follows:");
            Console.WriteLine($"---------\nComplaint Time: {complaint.ComplaintTime.ToLongDateString()}, {complaint.ComplaintTime.ToLongTimeString()}");
            Console.WriteLine($"Complaint Raised: {complaint.ComplaintRaised}\n---------");
        }
    }
}