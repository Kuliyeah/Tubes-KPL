using System.Windows.Forms;

namespace Tubes_KPL
{
    //Adamnn.
    class Automata
    {
        // Attribut pada state.
        public enum State { LOGIN, DASHBOARD, INPUT_PENGGUNA, INPUT_JASA, INPUT_TRANSAKSI, LOGOUT }; 
        public static State posisi, nextPosisi; 

        public Automata() { }

        // Mensetter keadaan posisi pada automata.
        public static void setPosisi(State pos, State nextPos) 
        {
            posisi = pos;
            nextPosisi = nextPos;
        }

        // Mengambil data posisi.
        public static State getPosisi() 
        {
            return posisi;
        }

        public static void posisiTransition(State nextPos)
        {
            // Jika keadaan pada posisi masuk pada login.
            if (posisi == State.LOGIN) 
            {
                if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan input transaksi.
            else if (posisi == State.DASHBOARD) 
            {
                if (nextPos == State.INPUT_PENGGUNA)
                {
                    Pengguna pengguna = new Pengguna();
                    pengguna.Show();
                }
                // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan input jasa.
                else if (nextPos == State.INPUT_JASA) 
                {
                    InputJasa inputJasa = new InputJasa();
                    inputJasa.Show();
                }
                // Kemudian jika tidak masuk posisi dashboard masuk ke tampilan input transaksi.
                else if (nextPos == State.INPUT_TRANSAKSI) 
                {
                    InputTransaksi inputTransaksi = new InputTransaksi();
                    inputTransaksi.Show();
                }
                // Maka jika tidak posisi dashboard masuk ke tampilan logout.
                else if (nextPos == State.LOGOUT) 
                {
                    DialogResult dialogResult = MessageBox.Show("Sure?", " ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Application.Exit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        Login login = new Login();
                        login.Show();
                    }
                }
            }
            // Keadaan jika posisi semua tampilan akan kembali pada tampilan dashboard.
            else if (State.INPUT_PENGGUNA == posisi || State.INPUT_JASA == posisi || State.INPUT_TRANSAKSI == posisi) 
            {
                if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
        }

    }
}
