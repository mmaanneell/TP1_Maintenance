using System;

namespace Members
{
    public class Complaint : EventArgs
    {
        public DateTime ComplaintTime { get; set; }
        public string ComplaintRaised { get; set; }


        public void DisplayConfirmation()
        {
            Console.WriteLine("\nThis is a confirmation that we received your complaint. The details are as follows:");
            Console.WriteLine($"---------\nComplaint Time: {ComplaintTime.ToLongDateString()}, {ComplaintTime.ToLongTimeString()}");
            Console.WriteLine($"Complaint Raised: {ComplaintRaised}\n---------");
        }
    
    }

    
}