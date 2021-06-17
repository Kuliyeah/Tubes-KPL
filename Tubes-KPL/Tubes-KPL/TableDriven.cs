using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class TableDriven
    {
        public enum Username { APEL, APRIKOT, ALPUKAT, PISANG, PAPRIKA, BLACKBERRY, BLACKCURRANT, CERI, KELAPA, JAGUNG, KURMA, DURIAN, ANGGUR, MELON, SEMANGKA };
        public static string[] password = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00" };
        public static string getKodeUser(Username username)
        {
            return password[(int)username];
        }
    }
}
