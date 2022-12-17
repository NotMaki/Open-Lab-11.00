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
        private List<string> booksList = new List<string>();

        public List<string> BooksList
        {
            get { return booksList; }
            set { booksList = value; }
        }

        public List<string> StutentsList
        {
            set { booksList = value; }
            get { return booksList; }
        }

        public int NumberOfBooks
        { get { return numberOfBooks; } set { numberOfBooks = value; } }

        public int NumberOfStutentds
        { get { return numberOfStutentds;} set { numberOfStutentds = value; } }

        public override string ToString()
        {
            string bOoksFromList;
            string studentsFromList;
            return String.Format($"\n{this.numberOfBooks}\n{this.numberOfStutentds}\n{bOoksFromList}\n{studentsFromList}\n");
        }
    }
}
