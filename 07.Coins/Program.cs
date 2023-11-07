using System.ComponentModel.Design;

namespace _07.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] coins = { 2.00m, 1.00m, 0.50m, 0.20m, 0.10m, 0.05m, 0.02m, 0.01m };

            Console.Write("");
            decimal amount = decimal.Parse(Console.ReadLine());

            int numberOfCoinsToBeReturned = 0;
            int i = 0;

            while (amount > 0 && i < coins.Length)
            {
                if (amount >= coins[i])
                {
                    amount -= coins[i];
                    numberOfCoinsToBeReturned += 1;
                }
                else
                {
                    i += 1;
                }
            }

            Console.WriteLine($"{numberOfCoinsToBeReturned}");
        }
    }
}
