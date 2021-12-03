using System;

namespace Open_Lab_10._01
{
    class Program
    {
        class Book
        {
            public string title;
            private int pages;
        }
        static void Main(string[] args)
        {
            Book LOTR = new Book();

            string title = "Samova cesta";

            Console.WriteLine(title);
        }
    }
}
