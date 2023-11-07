using System;

using System;

class Program
{
    static void Main()
    {
        int goal = 10000;
        int totalSteps = 0;

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "going home")
            {
                int stepsGoingHome = int.Parse(Console.ReadLine());
                totalSteps += stepsGoingHome;
                int difference = goal - totalSteps;

                if (difference <= 0)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{Math.Abs(difference)} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(difference)} more steps to reach goal.");
                }

                break;
            }

            int steps = int.Parse(input);
            totalSteps += steps;

            if (totalSteps >= goal)
            {
                int difference = totalSteps - goal;
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
                break;
            }
        }
    }
}
