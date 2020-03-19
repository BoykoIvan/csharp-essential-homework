using System;

namespace Task_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(20, 30);

            Console.WriteLine("Area = {0}", rectangle.Area);
            Console.WriteLine("Perimeter = {0}", rectangle.Perimeter);
        }
    }
}
