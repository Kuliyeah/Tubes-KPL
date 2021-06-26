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
<<<<<<< Updated upstream
            try
            {
                var laundry = SingletonPattern.GetInstance();
                laundry.inputPengguna();
                laundry.inputJasa();
                laundry.inputTransaksi();
            }
            catch (Exception e)
            {
                Console.Write("Oops: " + e);
            }

=======
>>>>>>> Stashed changes
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
