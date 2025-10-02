using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Members;
using Helper;

public class Program
{
    static public List<Student> Students = new List<Student>();
    static public List<Teacher> Teachers = new List<Teacher>();
    static public Principal Principal = new Principal(name: "", address: "", phoneNumber: 0);  // temporaire avant de regler les autres problemes
    static public Receptionist Receptionist = new Receptionist(name: "", address: "", phoneNumber: 0);  // temporaire avant de regler les autres problemes

    enum SchoolMemberType
    {
        typePrincipal = 1,
        typeTeacher,
        typeStudent,
        typeReceptionist
    }


    private static int AcceptChoices()
    {
        return ConsoleHelper.AskNumberInput("\n1. Add\n2. Display\n3. Pay\n4. Raise Complaint\n5. Student Performance\nPlease enter the member type: ");
    }

    private static int AcceptMemberType()
    {
        int x = ConsoleHelper.AskNumberInput("\n1. Principal\n2. Teacher\n3. Student\n4. Receptionist\nPlease enter the member type: ");
        return Enum.IsDefined(typeof(SchoolMemberType), x) ? x : -1;
    }

    public static void AddPrincpal(string name, string address, int phoneNumber)
    {
        SchoolMember member = AcceptAttributes(name, address, phoneNumber);
        Principal.Name = member.Name;
        Principal.Address = member.Address;
        Principal.PhoneNumber = member.PhoneNumber;
    }


    private static void HandleComplaintRaised(object sender, Complaint complaint)
    {
        Console.WriteLine("\nThis is a confirmation that we received your complaint. The details are as follows:");
        Console.WriteLine($"---------\nComplaint Time: {complaint.ComplaintTime.ToLongDateString()}, {complaint.ComplaintTime.ToLongTimeString()}");
        Console.WriteLine($"Complaint Raised: {complaint.ComplaintRaised}\n---------");
    }


    private static void AddData()
    {
        Receptionist = new Receptionist("Receptionist", "address", 123);
        Receptionist.ComplaintRaised += HandleComplaintRaised;

        Principal = new Principal("Principal", "address", 123);

        for (int i = 0; i < 10; i++)
        {
            Students.Add(new Student(i.ToString(), i.ToString(), i, i));
            Teachers.Add(new Teacher(i.ToString(), i.ToString(), i));
        }
    }

    public static async Task Main(string[] args)
    {
        // Just for manual testing purposes.
        AddData();

        Console.WriteLine("-------------- Welcome ---------------\n");

        //Console.WriteLine("Please enter the Princpals information.");
        //AddPrincpal();

        bool flag = true;
        while (flag)
        {
            int choice = AcceptChoices();

            if (choice > 1 || choice < TypeChoix.lenght) 
            {
                ActionService.SelectAction();
            }
            else
            {
                Console.WriteLine("Invalid input. Terminating operation.");
                break;
            }
            
        }

        Console.WriteLine("\n-------------- Bye --------------");
    }
}

