using System;
using Members;

public static class MenuHelper
{
    public static int AcceptChoices()
    {
        string question = VerifyQuestion("\n[1] Add\n[2] Display\n[3] Pay\n[4] Raise Complaint\n[5] Student Performance\n[6] Undo Last Action\n\nPlease enter action type : ");
        return AskNumberInput(question);
    }

    public static int AcceptMemberType()
    {
        string question = VerifyQuestion("\n0. Principal\n1. Teacher\n2. Student\n3. Receptionist\n\nPlease enter the member type : ");
        int x = AskNumberInput(question);
        return Enum.IsDefined(typeof(SchoolMemberType), x) ? x : -1;
    }

    public static string AskInfoInput(string question)
    {
        Console.WriteLine(question);
        return Console.ReadLine() ?? string.Empty;
    }

    public static int AskNumberInput(string question)
    {
        Console.WriteLine(question);
        bool state = int.TryParse(Console.ReadLine(), out int result);
        while (!state)
        {
            Console.WriteLine("\n ----- Invalid input. Please try again: ");
            state = int.TryParse(Console.ReadLine(), out result);
        }

        return result;
    }

    public static string VerifyQuestion(string question)
    {
        if (string.IsNullOrEmpty(question))
        {
            Console.WriteLine("AskInfoInput requires a non-null question string.\nPlease provide a valid question then restart the program.");
            Environment.Exit(1);
        }
        return question;
    }

}

