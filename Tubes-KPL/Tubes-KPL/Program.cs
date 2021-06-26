using System;
using System.Windows.Forms;
using Tubes_KPL;

namespace HalamanUtama
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                var laundry = SingletonPattern.GetInstance();
                laundry.inputPengguna();
                laundry.inputJasa();
                laundry.inputTransaksi();
            }
            catch (Exception)
            {
                Console.Write("Oops");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
