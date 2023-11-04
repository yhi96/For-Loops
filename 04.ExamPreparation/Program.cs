namespace _04.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int poorGradesLimit = int.Parse(Console.ReadLine());

            int numberPoorGrades = 0;
            double gradesTotal = 0;
            int gradesNum = 0;
            string lastProblem = "";

            while (numberPoorGrades < poorGradesLimit)
            {
                string currentProblem = Console.ReadLine();
                if (currentProblem == "Enough")
                    break;
                lastProblem = currentProblem;
                int currentGrade = int.Parse(Console.ReadLine());

                gradesTotal += currentGrade;
                gradesNum += 1;

                if (currentGrade <= 4)
                    numberPoorGrades += 1;
            }
            if (numberPoorGrades >= poorGradesLimit)
            {
                Console.WriteLine($"You need a break, {numberPoorGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesTotal/gradesNum:f2}");
                Console.WriteLine($"Number of problems: {gradesNum}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}