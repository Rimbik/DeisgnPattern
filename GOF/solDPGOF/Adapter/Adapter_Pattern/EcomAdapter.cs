using System;
using System.Collections.Generic;
using System.Text;

//Target: EcomSystem
//Adapter: EcomAdapter
//Adaptee: EcomMerchants
//Client: EcomApp

namespace Adapter_Pattern
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>

    public class EcomAdapter : EcomSystem //Adapter

    {
        private EcomMerchant _bank;

        // Constructor

        public EcomAdapter(string name)
          : base(name)
        {
        }

        public override List<string> Display()
        {
            var data = new List<string>();

            // The Adaptee

            _bank = new EcomMerchant();

            technology = _bank.GetInfo(_ecomProduct, "T");
            platform = _bank.GetInfo(_ecomProduct, "P");
            userPopularity = _bank.GetPopularity(_ecomProduct);

            data.AddRange(base.Display());

            data.AddRange(new List<string>()
            {
                "Tech - " + technology,
                "Platform :- " + platform,
                "User Popularity : - " +userPopularity
            });
            

            return data;
        }
    }
}
