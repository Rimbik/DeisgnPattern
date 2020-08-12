using System.Collections.Generic;

namespace Decorator_Pattern
{
    public abstract class LibraryItem
    {
        private int _numCopies;

        // Property

        public int NumCopies
        {
            get { return _numCopies; }
            set { _numCopies = value; }
        }

        public abstract List<string> Display();
    }
}