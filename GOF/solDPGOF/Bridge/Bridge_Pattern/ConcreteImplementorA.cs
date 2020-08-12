using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            //Do Some Opt
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}