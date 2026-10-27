namespace INF._04_01_25._06_SG
{
    class Program
    {

        static int[,] DrawNumbers(int count)
        {
            Random random = new Random();
            int[,] draws = new int[count, 6];
            for (int row = 0; row < count; row++)
            {
                for (int column = 0; column < 6; column++)
                {
                    int number;
                    do
                    {
                        number = random.Next(1, 50);
                    }
                    while (IsInDraw(draws, row, column, number));
                    draws[row, column] = number;
                }
            }
            return draws;
        }

        static bool IsInDraw(int[,] draws, int row, int filled, int number)
        {
            for (int column = 0; column < filled; column++)
            {
                if (draws[row, column] == number)
                {
                    return true;
                }
            }
            return false;
        }

        static int[] CountOccurrences(int[,] draws)
        {
            int[] occurrences = new int[50];
            foreach (int number in draws)
            {
                occurrences[number]++;
            }
            return occurrences;
        }

        static void PrintOccurrences(int[] occurrences)
        {
            for (int number = 1; number <= 49; number++)
            {
                Console.WriteLine("Wystąpienia liczby " + number + ": " + occurrences[number]);
            }
        }

        static void PrintDraws(int[,] draws)
        {
            for (int row = 0; row < draws.GetLength(0); row++)
            {
                Console.Write("Losowanie " + (row + 1) + ":");
                for (int column = 0; column < 6; column++)
                {
                    Console.Write(" " + draws[row, column]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Ile wygenerować losowań?");
            int count = Convert.ToInt32(Console.ReadLine());

            int[,] draws = DrawNumbers(count);
            Console.WriteLine("Zestawy wylosowanych liczb:");
            PrintDraws(draws);

            int[] occurrences = CountOccurrences(draws);
            PrintOccurrences(occurrences);
        }
    }
}
