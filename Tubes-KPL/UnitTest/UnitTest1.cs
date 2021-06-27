using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tubes_KPL;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddDataPengguna()
        {
            PenggunaModel penggunaModel;
            penggunaModel = new PenggunaModel(
                "Rifky",
                "087823837566",
                "Di bandung pokonya",
                "Rifky@gmail.com",
                "lovanto"
                );
            Assert.IsNotNull(penggunaModel);
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
