﻿using Open_Lab_11._00;
using System;
using System.Security.Cryptography;

namespace Open_Lab_11._00
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Book LOTR = new Book();
            //LOTR.Title = "The Lord of the Rings";
            //LOTR.Pages = 9250;
            //LOTR.Category = "epic high-fantasy novel";
            //LOTR.Author = "John Ronald Reuel Tolkien";
            //LOTR.ReleaseDate = 1954;
            Console.WriteLine(LOTR.ToString());

            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.ToString());

            Book LOTR3 = new Book("The Lord of the Rings 3", 576);
            Console.WriteLine(LOTR3.ToString());

            Book Hobit = new Book("Hobit", 304, Book.categoryList[3], "John Ronald Reuel Tolkien", 1954);
            Console.WriteLine(Hobit.ToString());
        }
    }
}