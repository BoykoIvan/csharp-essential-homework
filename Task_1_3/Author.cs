using System;
namespace Task_1_3
{
    public class Author
    {
        private string name = "Unknown";

        public string Name
        {
            set => name = value;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Author: {0}", name);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
