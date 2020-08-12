using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class Abstraction
    {
        public Implementor implementor;
        // Property

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}
