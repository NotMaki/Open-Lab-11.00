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

            Book kniha0 = new Book("Slovenský Jazyk", 183, Book.categoryList[2], "Zuzana Bírová", 2019);
            Book kniha1 = new Book("Matematika", 90, Book.categoryList[2], "Peter Druska", 2021);
            Book kniha2 = new Book("Nemčina", 157, Book.categoryList[2], "Mária Maxiánová", 2021);
            Book kniha3 = new Book("Elektronika hrou", 157, Book.categoryList[2], "Peter Sovík", 2017);
            
            skola.StutentsList.Add("John");
            skola.StutentsList.Add("Poul");
            skola.BooksList.Add(kniha0);
            skola.BooksList.Add(kniha1);
            skola.BooksList.Add(kniha2);

            Console.WriteLine(skola.ToString());

        }
    }
}