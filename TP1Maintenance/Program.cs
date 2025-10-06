using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Members;
using Helper;
using Managers;

public class Program
{
    static public List<Student> Studentss = new List<Student>(); // nom temporaire pour éviter les conflits avec la liste dans Student.cs
    static public List<Teacher> Teacherss = new List<Teacher>(); // nom temporaire pour éviter les conflits avec la liste dans Teacher.cs
    static public Principal Principal = new Principal(name: "", address: "", phoneNumber: 0);  // temporaire avant de regler les autres problemes
    static public Receptionist Receptionist = new Receptionist(name: "", address: "", phoneNumber: 0);  // temporaire avant de regler les autres problemes


    private static void AddData()
    {
        Receptionist = new Receptionist("Receptionist", "address", 123);
        Receptionist.ComplaintRaised += (sender, complaint) => complaint.DisplayConfirmation();

        Principal = new Principal("Principal", "address", 123);

        for (int i = 0; i < 10; i++)
        {
            Studentss.Add(new Student(i.ToString(), i.ToString(), i, i));
            Teacherss.Add(new Teacher(i.ToString(), i.ToString(), i));
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

            int choice = MenuHelper.AcceptChoices();
            switch (choice)
            {
                case 1:
                    SchoolMemberManager.Add(name: "name", address: "address", phoneNumber: 123456); // temporaire avant de regler les autres problemes
                    break;
                case 2:
                    //Display();
                    break;
                case 3:
                    Managers.PayrollManager.PayMembers(Principal, Receptionist);
                    break;
                case 4:
                    Receptionist.HandleComplaint();
                    break;
                case 5:
                    Student.DisplayAveragePerformance();
                    break;
                default:
                    flag = false;
                    break;
            }
        }

        Console.WriteLine("\n-------------- Bye --------------");
    }
}

