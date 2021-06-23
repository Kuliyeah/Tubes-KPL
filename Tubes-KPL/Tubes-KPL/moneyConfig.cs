using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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
