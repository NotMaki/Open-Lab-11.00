using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    internal class Library
    {
        private int numberOfBooks;
        private int numberOfStutentds;
        private List<string> studentsList = new List<string>();
        private List<Book> booksList = new List<Book>();

        public List<Book> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }

        public List<string> StutentsList
        {
            get { return studentsList; }
            set { studentsList = value; }
        }

        public int NumberOfBooks
        { get { return numberOfBooks; } set { numberOfBooks = value; } }

        public int NumberOfStutentds
        { get { return numberOfStutentds;} set { numberOfStutentds = value; } }

        public override string ToString()
        {
            string bOoksFromList = string.Empty;
            string studentsFromList = string.Empty;

            foreach(var b in booksList) 
            {
                bOoksFromList += b + " ";
            }

            foreach(var s in studentsList)
            {
                studentsFromList += s + " ";
            }
            return String.Format($"\n{this.numberOfBooks}\n{this.numberOfStutentds}\n{bOoksFromList}\n{studentsFromList}\n");
        }
    }
}
