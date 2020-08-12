using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>

    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        // Constructor

        public Borrowable(LibraryItem libraryItem)
          : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            libraryItem.NumCopies++;
        }

        public override List<string> Display()
        {
            var data = new List<string>();

            data.AddRange(base.Display());

            foreach (string borrower in borrowers)
            {
                data.Add(" borrower: " + borrower);
            }

            return data;

        }
    }
}
