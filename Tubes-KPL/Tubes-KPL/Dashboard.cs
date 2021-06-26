using System;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class Dashboard : Form
    {
        String path = Environment.CurrentDirectory;
        String pathMoney = @"../../../json/MoneyConfig.json";
        moneyConfig money;
        Automata.State posisi = Automata.State.DASHBOARD, nextPosisi;

        public Dashboard()
        {
            try
            {
                money = Config.ReadFromJson<moneyConfig>(path + pathMoney);
            }
            catch
            {
                money = new moneyConfig("Rupiah");
                Config.SaveToJson<moneyConfig>(money, path + pathMoney);
            }

            InitializeComponent();
        }

        private enum Dashboard
        {
            Empty, Pendataan, Pemrosesan, Pembayaran
        }

        private void btnDataTransaksi_Click(object sender, EventArgs e) //bottom data transaksi
        {
            nextPosisi = Automata.State.INPUT_TRANSAKSI;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void btnDataJasa_Click(object sender, EventArgs e) //bottom data jasa
        {
            nextPosisi = Automata.State.INPUT_JASA;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void btnDataPengguna_Click(object sender, EventArgs e) //bottom data pengguna
        {
            nextPosisi = Automata.State.INPUT_PENGGUNA;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (money.getMoneyConfig() == "Rupiah")
            {
                cbMoney.SelectedItem = "Rupiah";
                Config.SaveToJson<moneyConfig>(new moneyConfig(cbMoney.Text), path + pathMoney);
            }
            else
            {
                cbMoney.SelectedItem = "USD";
                Config.SaveToJson<moneyConfig>(new moneyConfig(cbMoney.Text), path + pathMoney);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e) //bottom logout
        {
            nextPosisi = Automata.State.LOGOUT;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void comboBoxMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.SaveToJson<moneyConfig>(new moneyConfig(cbMoney.Text), path + pathMoney);
        }

    }
}
