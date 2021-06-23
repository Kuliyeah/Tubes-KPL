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
        moneyConfig money;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnDataTransaksi_Click(object sender, EventArgs e)
        {
            InputTransaksi inputTransaksi = new InputTransaksi();
            inputTransaksi.Show();
            this.Hide();
        }

        private void btnDataJasa_Click(object sender, EventArgs e)
        {
            InputJasa inputJasa = new InputJasa();
            inputJasa.Show();
            this.Hide();
        }

        private void btnDataPengguna_Click(object sender, EventArgs e)
        {
            Pengguna pengguna = new Pengguna();
            pengguna.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new Login().Show();
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
            String path = Environment.CurrentDirectory;
            String pathMoney = @"../../../json/MoneyConfig.json";

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
            DialogResult dialogResult = MessageBox.Show("Sure?", " ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                new Login().Show();
            }
            this.Hide();
        }
        private string pathMoney = @"\MoneyConfig.json";
        private string path = Environment.CurrentDirectory;
        private void comboBoxMoney_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.SaveToJson<moneyConfig>(new moneyConfig(comboBoxMoney.Text), path+pathMoney);
        }
    }
}
