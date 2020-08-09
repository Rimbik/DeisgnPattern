using Facade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.Facade
{
    [TestClass]
    public class TestFacade
    {
        [TestMethod]
        public void TestFacadeSave()
        {
            DatabaseService myDBService = new DatabaseService();

            var isSaved = myDBService.SaveData(
                  new System.Collections.Generic.List<string>() {
                    "UserID = 1234", "{'UserAge':'25', 'UserName' : 'XYZ'}" 
                  }
                );
        }
    }
}
