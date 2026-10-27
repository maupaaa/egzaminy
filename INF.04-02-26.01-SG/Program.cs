namespace INF._04_02_26._01_SG
{
    internal class Program
    {
       static void Main(string[] args)
        {
            string content = ReadInput("Treść pytania: ");
            string imgFile = ReadInput("Nazwa pliku obrazu: ");
            string answerA = ReadInput("Odpowiedź A: ");
            string answerB = ReadInput("Odpowiedź B: ");
            string answerC = ReadInput("Odpowiedź C: ");
            char correctAnswer = ReadLetter("Poprawna odpowiedź (A, B lub C): ");

            PytanieZamkniete question = new PytanieZamkniete(content, imgFile, answerA, answerB, answerC, correctAnswer);

            char userAnswer = ReadLetter("Twoja odpowiedź: ");
            if (question.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Odpowiedź prawidłowa");
            }
            else
            {
                Console.WriteLine("Odpowiedź nieprawidłowa");
            }

            static string ReadInput(string prompt)
            {
                Console.Write(prompt);
                return Console.ReadLine() ?? "";
            }

            static char ReadLetter(string prompt)
            {
                string text;
                do
                {
                    text = ReadInput(prompt).Trim().ToUpper();
                } while (text.Length == 0);

                return text[0];
            }
        }
    }
}
