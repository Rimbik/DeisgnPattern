using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Pattern
{
    public class RealMeManufacturer : PhoneManufacturer
    {
        public override Product ProductFactory()
        {
            return new Realme();
        }
    }
}
