using System;
using System.Collections.Generic;


//Target: EcomSystem
//Adapter: Compound
//Adaptee: EcomMerchants
//Client: EcomApp

namespace Adapter_Pattern
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    public class EcomSystem //Target
    {
        protected string _ecomProduct;

        protected string technology; //_boilingPoint;
        protected string platform;   //_meltingPoint;

        protected string userPopularity; //_molecularWeight
        protected string marketTrends;//_molecularFormula;


        // Constructor

        public EcomSystem(string ecomProduct)
        {
            this._ecomProduct = ecomProduct;
        }

        public virtual List<string> Display()
        {
            return new List<string>() {
                    "Mecrahnt: -"+ _ecomProduct
                };
        }
    }
}
