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
    static public Principal Principal = new Principal(name: "Principal Initial", address: "Address Initial", phoneNumber: 123456789);  // valeurs valides
    static public Receptionist Receptionist = new Receptionist(name: "Receptionist Initial", address: "Address Initial", phoneNumber: 123456789);  // valeurs valides


    private static void AddData()
    {
        Receptionist = new Receptionist("Receptionist", "address", 123456789);
        Receptionist.ComplaintRaised += (sender, complaint) => complaint.DisplayConfirmation();

        Principal = new Principal("Principal", "address", 123456789);

        for (int i = 1; i <= 10; i++) 
        {
            Studentss.Add(new Student($"Student{i}", $"Address{i}", 123456000 + i, i + 60)); // Grade réaliste
            Teacherss.Add(new Teacher($"Teacher{i}", $"Address{i}", 123457000 + i, subject: $"Subject{i}"));
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
                    SchoolMemberManager.Add(Principal, "name", "address", 123456); // temporaire avant de regler les autres problemes
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

