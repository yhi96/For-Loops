namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows += 1)
            {
                for (int cols = 1; cols <= n; cols += 1)
                {
                    if (current > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.WriteLine(current + " ");
                    current += 1;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
            
        }
    }
}