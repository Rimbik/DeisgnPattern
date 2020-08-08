using Adapter_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Adapter
{
    [TestClass]
    public class AdapterTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            EcomSystem ecomSystem = new EcomSystem("Unknown");
            var result = ecomSystem.Display();

            // Adapted AmazonEcom compounds
            EcomSystem amazon = new EcomAdapter("Amazon");
            var result0 = amazon.Display();

            // Adapted ebay compounds
            EcomSystem ebay = new EcomAdapter("ebay");
            var result1 = ebay.Display();

            // Adapted Zalando compounds
            EcomSystem zalando = new EcomAdapter("Zalando");
            var result2 = zalando.Display();

        }
    }
}
