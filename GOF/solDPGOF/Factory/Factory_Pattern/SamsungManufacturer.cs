using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class SamsungManufacturer : PhoneManufacturer
    {
        public override Product ProductFactory()
        {
            return new Samsung();
        }
    }
}
