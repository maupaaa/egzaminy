namespace konsola;

class Program
{
    const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
    const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string Diacritics = "ąęłńóśżźĄĘŁŃÓŚŻŹ";
    const string Digits = "0123456789";
    const string Special = "!@#$%^&*()_+";

    static Random random = new Random();

    static string InsertRandomChar(string password, string characters)
    {
        char character = characters[random.Next(characters.Length)];
        int position = random.Next(password.Length + 1);
        return password.Insert(position, character.ToString());
    }

    static string GeneratePassword()
    {
        string password = "";
        for (int i = 0; i < 3; i++)
        {
            password = InsertRandomChar(password, Lowercase);
        }
        for (int i = 0; i < 3; i++)
        {
            password = InsertRandomChar(password, Uppercase);
        }
        for (int i = 0; i < 2; i++)
        {
            password = InsertRandomChar(password, Diacritics);
        }
        for (int i = 0; i < 2; i++)
        {
            password = InsertRandomChar(password, Digits);
        }
        for (int i = 0; i < 2; i++)
        {
            password = InsertRandomChar(password, Special);
        }
        return password;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Wygenerowano 5 bezpiecznych haseł");
        for (int number = 1; number <= 5; number++)
        {
            Console.WriteLine($"Hasło {number}: {GeneratePassword()}");
        }
    }
}