using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    public class ClassTestExitingFile
    {
        // Unit Testing untuk mengecek apakah terdapat file MoneyConfig.json pada projek ini
        public bool isExitingFileJson()
        {
            if (File.Exists("../../../../Tubes-KPL/json/MoneyConfig.json"))
            {
                return true;
            }
            return false;
        }
    }
}
