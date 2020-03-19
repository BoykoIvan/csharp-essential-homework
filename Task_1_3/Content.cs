using System;
namespace Task_1_3
{
    public class Content:IShow
    {
        private string content = "No content";

        public string Value
        {
            set => content = value;
        }

        public void Show()
        {
            Console.WriteLine(content);
        }
    }
}
