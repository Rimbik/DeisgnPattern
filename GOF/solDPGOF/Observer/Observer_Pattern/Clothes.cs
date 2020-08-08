using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Clothes : Stock
    {
        // Constructor

        public Clothes(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}
