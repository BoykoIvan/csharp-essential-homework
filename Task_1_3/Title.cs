using System;
namespace Task_1_3
{
    public class Title
    {
        private string value = "Untitled";

        public string Value
        {
            set => this.value = value;
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(value);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
