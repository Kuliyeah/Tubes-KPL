using System.Windows.Forms;

namespace Tubes_KPL
{
    //Adamnn
    class Automata
    {
        public enum State { LOGIN, DASHBOARD, INPUT_PENGGUNA, INPUT_JASA, INPUT_TRANSAKSI, LOGOUT }; //attribut pada state
        public static State posisi, nextPosisi; 

        public Automata() { }

        public static void setPosisi(State pos, State nextPos) //mensetter keadaan posisi pada automata
        {
            posisi = pos;
            nextPosisi = nextPos;
        }

        public static State getPosisi() //mengambil data posisi
        {
            return posisi;
        }

        public static void posisiTransition(State nextPos)
        {
            if (posisi == State.LOGIN) //jika keadaan pada posisi masuk pada login
            {
                if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            else if (posisi == State.DASHBOARD) //kemudian jika tidak masuk posisi dashboard masuk ke tampilan input transaksi 
            {
                if (nextPos == State.INPUT_PENGGUNA)
                {
                    Pengguna pengguna = new Pengguna();
                    pengguna.Show();
                }
                else if (nextPos == State.INPUT_JASA) //kemudian jika tidak masuk posisi dashboard masuk ke tampilan input jasa
                {
                    InputJasa inputJasa = new InputJasa();
                    inputJasa.Show();
                }
                else if (nextPos == State.INPUT_TRANSAKSI) //kemudian jika tidak masuk posisi dashboard masuk ke tampilan input transaksi 
                {
                    InputTransaksi inputTransaksi = new InputTransaksi();
                    inputTransaksi.Show();
                }
                else if (nextPos == State.LOGOUT) //maka jika tidak posisi dashboard masuk ke tampilan logout 
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
            else if (State.INPUT_PENGGUNA == posisi || State.INPUT_JASA == posisi || State.INPUT_TRANSAKSI == posisi) // kedaan jika posisi semua tampilan akan kembali pada tampilan dashboard
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
