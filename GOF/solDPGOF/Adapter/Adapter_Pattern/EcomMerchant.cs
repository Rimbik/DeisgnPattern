using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_Pattern
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>

    class EcomMerchant //Adaptee
    {
        // The databank 'legacy API'
        public string GetInfo(string product, string area)
        {
            if (product.ToLower() == "amazon")
            {
                if (area == "T")
                    return "Java";
                if (area == "P")
                    return "OpenSource";
            }
            else if (product.ToLower() == "ebay")
            {
                if (area == "T")
                    return ".Net";
                if (area == "P")
                    return "Microsoft";
            }
            else if (product.ToLower() == "zalando")
            {
                if (area == "T")
                    return "Drupal";
                if (area == "P")
                    return "OpenSource";
            }

            return "empty";
        }

        public string GetMolecularStructure(string compound)
        {
            switch (compound.ToLower())
            {
                case "water": return "H20";
                case "benzene": return "C6H6";
                case "ethanol": return "C2H5OH";
                default: return "";
            }
        }

        public string GetPopularity(string merchant)
        {
            switch (merchant.ToLower())
            {
                case "amazon": return "10/10";
                case "ebay": return "6/10";
                case "zalando": return "8/10";
                
                default: return "0";
            }
        }
    }
}
