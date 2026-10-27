using INF._04_02_26._06_SG;

class Program
{
    static void Main(string[] args)
    {
        Note single = new Note("bajojajo");
        single.DisplayNote();

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Podaj tytuł notatki:");
        string title = Console.ReadLine();
        Console.WriteLine("Podaj priorytet notatki (true/false):");
        bool priority = bool.Parse(Console.ReadLine());
        Console.WriteLine("Podaj treść notatki:");
        string content = Console.ReadLine();
        Console.WriteLine("Podaj datę notatki (yyyy-MM-dd):");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Note triple = new Note(title, content, priority, date);
        triple.DisplayNote();
    }

}