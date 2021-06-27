using System;

namespace Tubes_KPL
{
    // Menentukan nama atau mata uang.
    class moneyConfig
    {
        public String mataUang;

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
