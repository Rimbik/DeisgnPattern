using System;

namespace Factory_Pattern
{
    public abstract class Product
    {
        public Product()
        {
           // this.GetMyProduct();
        }

        public abstract string GetPhone();
    }
}
