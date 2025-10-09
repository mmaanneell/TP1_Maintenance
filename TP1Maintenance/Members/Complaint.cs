using System;

namespace Members
{
    public class Complaint : EventArgs
    {
        public DateTime ComplaintTime { get; set; }
        public string ComplaintRaised { get; set; }

        public Complaint()
        {
            ComplaintTime = DateTime.Now;
            ComplaintRaised = "";
        }
        public Complaint(DateTime complaintTime, string complaintText)
        {
            ComplaintTime = complaintTime;
            ComplaintRaised = complaintText;
        }

        public void DisplayConfirmation()
        {
            Console.WriteLine("\nThis is a confirmation that we received your complaint. The details are as follows:");
            Console.WriteLine($"---------\nComplaint Time: {ComplaintTime.ToLongDateString()}, {ComplaintTime.ToLongTimeString()}");
            Console.WriteLine($"Complaint Raised: {ComplaintRaised}\n---------");
            
             Program.Undo.Push(
                description: $"Undo: Raise Complaint at '{ComplaintTime.ToLongDateString()}, {ComplaintTime.ToLongTimeString()}'\n Complaint Raised: {ComplaintRaised}",
                undo: () =>
                {
                    ComplaintTime = new DateTime(2000, 1, 1);
                    ComplaintRaised = "None";
                    ComplaintRaised = "None";
                }
            );
        }
    
    }

    
}