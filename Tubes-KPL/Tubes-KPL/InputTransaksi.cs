using System;
using System.Windows.Forms;

//Gilang

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
            setEditEnabled(false);
            btnNew.Enabled = true;
        }

        private void setEditEnabled(bool stat)
        {
            btnSimpan.Enabled = stat;
            btnBatal.Enabled = stat;
            btnNew.Enabled = stat;
            comboBoxIDJasa.Enabled = stat;
            textBerat.Enabled = stat;
            textDeskripsi.Enabled = stat;
            textIDTransaksi.Enabled = stat;
            textOngkir.Enabled = stat;
            textTotal.Enabled = stat;
        }

        private void clearText()
        {
            textIDTransaksi.Text = "";
            textBerat.Text= "";
            textOngkir.Text = "";
            textTotal.Text = "";
            textDeskripsi.Text = "";
        }

        private int hitungTotal()
        {
            int harga = 5000;
            int total = Int16.Parse(textBerat.Text) * harga + Int16.Parse(textOngkir.Text);
            return total;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearText();
            setEditEnabled(true);
            btnNew.Enabled = false;
            textTotal.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            setEditEnabled(false);
            btnNew.Enabled = true;
            textTotal.Text = hitungTotal().ToString();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            setEditEnabled(false);
            btnNew.Enabled = true;
            this.Hide();
            new Dashboard().Show();
        }
    }
}
