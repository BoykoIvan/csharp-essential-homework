using System;

namespace Task_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            new Book().Show();
            Console.WriteLine(new string('=',30));

            new Book("Crocodile Magazine").Show();
            Console.WriteLine(new string('=', 30));

            new Book("Murzilka Magazine", "Soyuzpechat'").Show();
            Console.WriteLine(new string('=', 30));

            var novel = new Book()
            {
                Title = "A tale of two cities",
                Author = "Charles Dickens",
                Content = "In 1775, a man flags down the nightly mail-coach on its route from London to Dover. " +
                    "The man is Jerry Cruncher, an employee of Tellson's Bank in London; he carries a message for Jarvis Lorry, " +
                    "a passenger and one of the bank's managers. Lorry sends Jerry back to deliver a cryptic response to the bank: \"Recalled to Life.\" " +
                    "The message refers to Alexandre Manette, a French physician who has been released from the Bastille after an 18-year imprisonment. " +
                    "Once Lorry arrives in Dover, he meets Dr. Manette's daughter Lucie and her governess, Miss Pross. Lucie has believed her father to be dead, " +
                    "and faints at the news that he is alive; Lorry takes her to France to reunite with her father."
            };
            novel.Show();
        }
    }
}