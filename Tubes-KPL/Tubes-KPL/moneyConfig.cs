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
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"\InputJasa.json";
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
