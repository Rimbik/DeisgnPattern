using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class Realme : Product
    {
        public override string GetPhone()
        {
            //code .process to manufac phone
            return "Product created In China ...";
        }
    }
}
