namespace Util
{
    static public class ConsoleHelper
    {
        static public string AskInfoInput(string question)
        {
            System.Console.Write(question);
            return System.Console.ReadLine();
        }

        static public int AskNumberInput(string question)
        {
            System.Console.Write(question);
            bool state = int.TryParse(System.Console.ReadLine(), out int result);
            while (!state)
            {
                System.Console.Write("Invalid input. Please try again: ");
                state = int.TryParse(System.Console.ReadLine(), out result);
            }

            return result;
        }
    }
}
