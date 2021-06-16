using System;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class InputTransaksi : Form
    {
        public InputTransaksi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisableButton();
        }

        private void DisableButton()
        {
            btnSimpan.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnBatal.Enabled = false;
            btnNew.Enabled = true;
        }

        private void EnableButton()
        {
            btnSimpan.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnBatal.Enabled = true;
            btnNew.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            EnableButton();
        }

    }
}
