using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Samsung : Product
    {
        public override string GetPhone()
        {
            return "Product created In Korea ...";
        }
    }
}
