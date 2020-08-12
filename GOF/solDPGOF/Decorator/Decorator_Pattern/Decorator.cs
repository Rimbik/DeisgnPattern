using System;
using System.Collections.Generic;

namespace Decorator_Pattern
{
    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        // Constructor

        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override List<string> Display()
        {
           return libraryItem.Display();
        }
    }
}
