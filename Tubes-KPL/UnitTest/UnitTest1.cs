using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tubes_KPL;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void isLessThanMinHargaPaket()
        {
            ClassTestExitingFile isExitingFile = new ClassTestExitingFile();
            var result = isExitingFile.isExitingFileJson();
            Assert.AreEqual(true, result);
        }
    }
}
