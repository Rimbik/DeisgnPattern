using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public abstract class PhoneManufacturer
    {
        public abstract Product ProductFactory();
    }
}
