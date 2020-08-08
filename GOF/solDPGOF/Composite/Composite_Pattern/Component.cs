using System;
using System.Collections.Generic;

namespace Composite_Pattern
{
    public abstract class Component

    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component c);
        public abstract void Remove(Component c);
        public abstract List<string> Display(int depth);
    }
}
