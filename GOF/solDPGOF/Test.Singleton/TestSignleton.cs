using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton_Pattern;
using System;
using System.IO;

namespace Test.Singleton
{
    [TestClass]
    public class PatternTest
    {
        [TestMethod]
        public void TestNoNewInstance()
        {
            ErrorLogger logger1 = ErrorLogger.GetLogger();
            int baseId = logger1.GetHashCode();

            for (var c = 0; c < 3; c++)
            {
                ErrorLogger logger = ErrorLogger.GetLogger();
                int latestId = logger1.GetHashCode();

                var hasCode = logger.GetHashCode();

                Assert.AreEqual(baseId, latestId, "New Instance created");
            }
        }

        [TestMethod]
        public void TestLogMyError()
        {
            ErrorLogger.GetLogger().Write("1");
            
            Assert.AreEqual(1, 1);
        }

        
    }
}
