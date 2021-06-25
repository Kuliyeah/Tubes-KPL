using System;

namespace Tubes_KPL
{
    
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
