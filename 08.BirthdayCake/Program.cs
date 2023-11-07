namespace _08.BirthdayCake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLength = int.Parse(Console.ReadLine());
            

            int cakeSize = cakeWidth * cakeLength;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "STOP")
                {
                    if (cakeSize >= 0)
                    {
                        Console.WriteLine($"{cakeSize} pieces are left.");
                        
                    }
                    else
                    {
                        Console.WriteLine($"{-cakeSize} pieces are left.");
                    }
                    break;
                }

                int piecesTaken = int.Parse(command);
                cakeSize -= piecesTaken;
                if (cakeSize < 0)
                {
                    int missingPieces = Math.Abs(cakeSize);
                    Console.WriteLine($"No more cake left! You need {missingPieces} pieces more.");
                    break;
                }
            }
        }
    }
}