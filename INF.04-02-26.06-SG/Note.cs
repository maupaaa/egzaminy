using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace INF._04_02_26._06_SG
{
    public class Note
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Priority { get; set; }
        public DateTime Date { get; set; }

        public Note(string title, string content, bool priority, DateTime date)
        {
            Title = title;
            Content = content;
            Priority = priority;
            Date = date;
        }

        public Note(string title)
        {
            Title = title;
            Content = string.Empty;
            Priority = false;
            Date = DateTime.Now;
        }

        public void DisplayNote()
        {
            Console.WriteLine("--------------------------------");
            if (Priority == true)
            {
                Console.WriteLine($"Notatka WAŻNA!{Title}");
            }
            else
            {
                Console.WriteLine($"Notatka {Title}");
            }
            Console.WriteLine(Content);
            Console.WriteLine(Date);
            Console.WriteLine("--------------------------------");
        }
    }
}

