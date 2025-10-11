namespace Helper
{
    public static class ConsoleHelper
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
    }
}
