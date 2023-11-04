namespace _01.Numbers1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i += 1)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}