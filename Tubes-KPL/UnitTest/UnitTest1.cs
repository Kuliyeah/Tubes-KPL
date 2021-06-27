using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tubes_KPL;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        // Tes input pengguna.
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

        // Tes keberadaan file json.
        [TestMethod]
        public void isExistingFile()
        {
            ClassTestExistingFile isExistingFile = new ClassTestExistingFile();
            var result = isExistingFile.isExistingFileJson();
            Assert.AreEqual(true, result);
        }

        // Tes input transaksi.
        [TestMethod]
        public void TestAddTransaksi()
        {
            InputTransaksiModel transaksi;
            transaksi = new InputTransaksiModel(
                DateTime.Now, 1, "Jasa1", "Desk1", 5, 5000, 30000
                );
            Assert.IsNotNull(transaksi);
        }
    }
}
