using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Members;
using Helper;
using Managers;
using System.Xml.Serialization;

public class Program
{
    static public UndoManager Undo = new UndoManager();
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
        
        AddData();

        Console.WriteLine("-------------- Welcome ---------------\n");

        //Console.WriteLine("Please enter the Princpals information.");
        //AddPrincpal();

        bool flag = true;
        while (flag)
        {
            int choice = MenuHelper.AcceptChoices();
            

            if (choice > 1 || choice < Enum.GetNames(typeof(TypeChoice)).Length)
            {
                TypeChoice myChoice = (TypeChoice)choice;

                ActionService.SelectAction(myChoice);
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
