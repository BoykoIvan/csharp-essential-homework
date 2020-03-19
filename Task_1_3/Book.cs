using System;
namespace Task_1_3
{
    public class Book : IShow
    {
        private Title title;
        private Author author;
        private Content content;

        public string Title
        {
            set => title.Value = value;
        }

        public string Author
        {
            set => author.Name = value;
        }

        public string Content
        {
            set => content.Value = value;
        }


        public Book()
        {
            title = new Title();
            author = new Author();
            content = new Content();
        }

        public Book(string title) :this()
        {
            this.Title = title;
        }

        public Book(string title, string author) : this(title)
        {
            this.Author = author;
        }


        public void Show()
        {
            title.Show();
            author.Show();
            Console.WriteLine(new string('-', 20));
            content.Show();
            Console.WriteLine();
        }
    }
}
