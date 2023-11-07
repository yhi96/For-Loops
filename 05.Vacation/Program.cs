using System;

class VacationSavings
{
    static void Main()
    {
        double moneyNeeded = double.Parse(Console.ReadLine());
        double availableMoney = double.Parse(Console.ReadLine());

        int consecutiveSpendDays = 0;
        int totalDays = 0;

        while (availableMoney < moneyNeeded && consecutiveSpendDays < 5)
        {
            string action = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (action == "save")
            {
                availableMoney += amount;
                consecutiveSpendDays = 0;
            }
            else if (action == "spend")
            {
                availableMoney -= amount;
                consecutiveSpendDays++;
            }

            if (availableMoney < 0)
            {
                availableMoney = 0;
            }

            totalDays++;
        }

        if (consecutiveSpendDays == 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(totalDays);
        }
        else
        {
            Console.WriteLine($"You saved the money for {totalDays} days.");
        }
    }
}