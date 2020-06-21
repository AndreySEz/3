using System;

namespace ООП_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Мастер и Маргарита", "Булгаков", 600, true);
            book1.outText();
        }
        class Book
        {
            string author;
            string name;
            int str;
            bool collection;
            public Book(string bookName, string bookAuthor, int bookStr, bool bookCollection)
            {
                name = bookName;
                author = bookAuthor;
                str = bookStr;
                collection = bookCollection;
            }
            public Book(string bookName, string bookAuthor, int bookStr)
            {
                name = bookName;
                author = bookAuthor;
                str = bookStr;
                collection = false;
            }
            public Book(string bookName, int bookStr)
            {
                name = bookName;
                author = "Неизвестен";
                str = bookStr;
                collection = false;
            }
            public void outText()
            {
                Console.WriteLine($"Книга \"{name}\":\nАвтор: {author}\nСтраниц: {str}\nКоллекционность: {((collection)?"Да":"Нет")}");
            }
        }
    }
}
