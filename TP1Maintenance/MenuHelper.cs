using System;
using Members;

public static class MenuHelper
{
    public static string AskInfoInput(string question)
    {
        Console.WriteLine(question);
        return Console.ReadLine();
    }

    public static int AskNumberInput(string question)
    {
        Console.WriteLine(question);
        bool state = int.TryParse(Console.ReadLine(), out int result);
        while (!state)
        {
            Console.WriteLine("Invalid input. Please try again: ");
            state = int.TryParse(Console.ReadLine(), out result);
        }

        return result;
    }

    public static int AcceptChoices()
    {
        return AskNumberInput("\n1. Add\n2. Display\n3. Pay\n4. Raise Complaint\n5. Student Performance\n6. Undo Last Action\nPlease enter action type: ");
    }

    public static int AcceptMemberType()
    {
        int x = AskNumberInput("\n0. Principal\n1. Teacher\n2. Student\n3. Receptionist\nPlease enter the member type: ");
        return Enum.IsDefined(typeof(SchoolMemberType), x) ? x : -1;
    }

}

