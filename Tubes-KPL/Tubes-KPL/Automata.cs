using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    //Adamnn
    class Automata
    {
        public enum State { LOGIN, DASHBOARD, INPUT_PENGGUNA, INPUT_JASA, INPUT_TRANSAKSI, LOGOUT };
        public static State posisi, nextPosisi;

        public Automata() { }
        public static void setPosisi(State pos, State nextPos)
        {
            posisi = pos;
            nextPosisi = nextPos;
        }

        public static State getPosisi()
        {
            return posisi;
        }

        public static void posisiTransition(State nextPos)
        {
            if (posisi == State.LOGIN)
            {
                if (nextPos == State.DASHBOARD)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
            }
            else if (posisi == State.DASHBOARD)
            {
                if (nextPos == State.INPUT_PENGGUNA)
                {
                    Pengguna pengguna = new Pengguna();
                    pengguna.Show();
                }
                else if (nextPos == State.INPUT_JASA)
                {
                    InputJasa inputJasa = new InputJasa();
                    inputJasa.Show();
                }
                else if (nextPos == State.INPUT_TRANSAKSI)
                {
                    InputTransaksi inputTransaksi = new InputTransaksi();
                    inputTransaksi.Show();
                }
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
