using Factory_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Factory
{
    [TestClass]
    public class TestFactory
    {
        [TestMethod]
        public void TestMethod1()
        {
            PhoneManufacturer[] manufacturer = new PhoneManufacturer[2];

            manufacturer[0] = new RealMeManufacturer();
            manufacturer[1] = new SamsungManufacturer();

            var realemePhoneFactory = manufacturer[0].ProductFactory();
            var realmePhone = realemePhoneFactory.GetPhone();

            var samsungPhoneFactory = manufacturer[1].ProductFactory();
            var samsungPhone = samsungPhoneFactory.GetPhone();

            //
            var nonChinesPhoneFactory = new SamsungManufacturer().ProductFactory();
            var myNonChinesPhone = nonChinesPhoneFactory.GetPhone();

        }
    }
}
