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
                new Dashboard().Show();
            }
            this.Hide();
        }
    }
}
