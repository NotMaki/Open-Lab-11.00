using Open_Lab_11._00;
using System;
using System.Security.Cryptography;

namespace Open_Lab_11._00
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library skola= new Library();

            Book kniha0 = new Book("SLJ", 312, Book.categoryList[2], "Zuzana Bírová", 2019);

            skola.StutentsList.Add("Lukáš");
            skola.BooksList.Add(kniha0);

            Console.WriteLine(skola.ToString());

        }
    }
}