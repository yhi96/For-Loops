using System.ComponentModel.Design;

namespace _09.MovingOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int freeSpaceWidth = int.Parse(Console.ReadLine());
            int freeSpaceLength = int.Parse(Console.ReadLine());
            int freeSpaceHeight = int.Parse(Console.ReadLine());

            int freeSpace = freeSpaceWidth * freeSpaceLength * freeSpaceHeight;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Done")
                {
                    Console.WriteLine($"{freeSpace} Cubic meters left.");
                    break;
                }

                int numberBoxes = int.Parse(command);

                if (freeSpace >= numberBoxes)
                {
                    freeSpace -= numberBoxes;
                }
                else
                {
                    int neededSpace = numberBoxes - freeSpace;
                    Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
                    break;
                }
            }
        }
    }
}





