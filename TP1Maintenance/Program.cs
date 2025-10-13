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
            Student.Students.Add(new Student($"Student{i}", $"Address{i}", 123456000 + i, i + 60)); // Grade réaliste
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
