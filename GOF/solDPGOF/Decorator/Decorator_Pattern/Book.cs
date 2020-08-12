using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class Book : LibraryItem
    {
        private string _author;
        private string _title;

        // Constructor

        public Book(string author, string title, int numCopies)
        {
            this._author = author;
            this._title = title;
            this.NumCopies = numCopies;
        }

        public override List<string> Display()
        {
            return new List<string>() {
                "\nBook ------ ",
                " Author: " + _author,
                " Title: " + _title,
                " # Copies: " + NumCopies.ToString()
            };
        }
    }

}
