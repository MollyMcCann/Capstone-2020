using System;
using HomeTrackerDatamodelLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestHomeTracker
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateandInitializedDataBaseTest()
        {
            HomeTrackerInitializer.CustomInitializer();
            Assert.IsTrue(true);

        }
    }
}
