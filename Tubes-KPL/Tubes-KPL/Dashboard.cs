using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class Dashboard : Form
    {
        String path = Environment.CurrentDirectory;
        String pathMoney = @"../../../json/MoneyConfig.json";
        Automata.State posisi = Automata.State.DASHBOARD, nextPosisi;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDataTransaksi_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.INPUT_TRANSAKSI;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void btnDataJasa_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.INPUT_JASA;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void btnDataPengguna_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.INPUT_PENGGUNA;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataTable dtMoney = new DataTable();
            dtMoney.Columns.Add("Mata Uang");
            dtMoney.Rows.Add("Rupiah");
            dtMoney.Rows.Add("USD");

            comboBoxMoney.DataSource = dtMoney;
            comboBoxMoney.DisplayMember = "Mata Uang";

            moneyConfig money;

            try
            {
                money = Config.ReadFromJson<moneyConfig>(path + pathMoney);
            }
            catch
            {
                money = new moneyConfig("Rupiah");
                Config.SaveToJson<moneyConfig>(money, path + pathMoney);
            }

            if (money.getMoneyConfig() == "Rupiah")
            {
                comboBoxMoney.SelectedItem = "Rupiah";
            }
            else
            {
                comboBoxMoney.SelectedItem = "USD";
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            nextPosisi = Automata.State.LOGOUT;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
            this.Hide();
        }
        private void comboBoxMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.SaveToJson<moneyConfig>(new moneyConfig(comboBoxMoney.Text), path + pathMoney);
        }
    }
}
