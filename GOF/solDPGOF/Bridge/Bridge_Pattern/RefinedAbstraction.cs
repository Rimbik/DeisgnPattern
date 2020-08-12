using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}
