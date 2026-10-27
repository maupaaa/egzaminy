namespace NF._04_01_26._01_SG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Kosc firstDie = new Kosc();
            Console.WriteLine("Pierwsza kość");
            PrintDie(firstDie);
            Console.WriteLine();

            Console.Write("Podaj liczbę oczek drugiej kości (1-6): ");
            int.TryParse(Console.ReadLine(), out int value);
            Kosc secondDie = new Kosc(value);
            Console.WriteLine("Druga kość");
            PrintDie(secondDie);

            static void PrintDie(Kosc die)
            {
                Console.WriteLine($"Liczba utworzonych kości: {Kosc.InstanceCount}");
                Console.WriteLine($"Wyrzucono: {die.Pips} ({die.ToWords()})");
                Console.WriteLine($"Plik obrazu: {die.ImageFiles[die.ImageId]}");
            }
        }
    }
}
