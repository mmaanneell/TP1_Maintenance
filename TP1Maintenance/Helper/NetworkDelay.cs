using System;
using System.Threading;

namespace Helper //teste 3 
{ 
    public class NetworkDelay
    {
        private const int MinDelayMilliseconds = 1000;
        private const int MaxDelayMilliseconds = 5000;

        private static Random _random = new Random();

        public static void SimulateNetworkDelay()
        {
            Thread.Sleep(_random.Next(MinDelayMilliseconds, MaxDelayMilliseconds));
        }

        public static int PayEntity(string entity, string name, int balance, int income)
        {
            SimulateNetworkDelay();

            balance += income;
            System.Console.WriteLine($"Paid {entity}: {name}. Total balance: {balance}");
            return balance; // solution temporaire pour enlever le ref
        }
    }
}
