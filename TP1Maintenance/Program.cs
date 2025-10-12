using Members;
using Managers;
using Microsoft.Extensions.Configuration;


public class Program
{


    public static void Main(string[] args)
    {
        JSONConfigurationManager.Initialize();
        ActionAdd.AddData();

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
