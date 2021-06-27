using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tubes_KPL;

namespace UnitTest
{
    class TestJasa
    {
        public void isLessThanMinHargaPaket()
        {
            InputJasaModel inputJasaModel = new InputJasaModel();
            var result = inputJasaModel.isExitingFileJson();
            Assert.AreEqual(true, result);
        }
    }
}
