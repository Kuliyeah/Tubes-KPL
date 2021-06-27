using System;

namespace Tubes_KPL
{
    // Menentukan nama atau mata uang.
    class moneyConfig
    {
        // Init.
        public String mataUang;

        // Constructor.
        public moneyConfig(String mataUang)
        {
            this.mataUang = mataUang;
        }

        public moneyConfig()
        {

        }

        public String getMoneyConfig()
        {
            return this.mataUang;
        }

    }

}
