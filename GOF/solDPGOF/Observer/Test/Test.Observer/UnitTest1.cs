using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer_Pattern;

namespace Test.Observer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Clothes clothes = new Clothes("Men-Jeans", 1500);
            clothes.Attach(new Investor("Wrangler"));
            clothes.Attach(new Investor("Lee"));

            clothes.Price = 1200; // On Sale
            clothes.Price = 1900; // On Season

        }
    }
}
