using Members;
using Managers;
using Microsoft.Extensions.Configuration;


public class Program
{
    private static void AddData()
    {
        Receptionist.receptionist.ComplaintRaised += (sender, complaint) => complaint.DisplayConfirmation();

        for (int i = 1; i <= 10; i++)
        {
            // Génération d'une liste d'étudiants et de professeurs pour ne pas avoir une liste vide au lancement du programme
            int minGrade = JSONConfigurationManager.GradeSettings?.MinGrade ?? 0;
            Student.Students.Add(new Student($"Student{i}", $"Address{i}", 123456000 + i, i + minGrade)); 
            Teacher.Teachers.Add(new Teacher($"Teacher{i}", $"Address{i}", 123457000 + i, subject: $"Subject{i}"));
        }
    }

    public static void Main(string[] args)
    {
        JSONConfigurationManager.Initialize();
        AddData();

        Console.WriteLine("-------------- Welcome ---------------\n");

        bool flag = true;
        while (flag)
        {
            int choice = MenuHelper.AcceptChoices();


            int maxChoice = Enum.GetNames(typeof(TypeChoice)).Length;
            if (choice >= 1 && choice <= maxChoice)
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
