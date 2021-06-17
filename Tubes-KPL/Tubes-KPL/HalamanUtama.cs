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
    public partial class HalamanUtama : Form
    {
        public HalamanUtama()
        {
            InitializeComponent();
        }

        private void btnDataPengguna_Click(object sender, EventArgs e)
        {
            Pengguna pengguna = new Pengguna();
            pengguna.Show();
        }

        private void btnDataJasa_Click(object sender, EventArgs e)
        {
            InputJasa inputJasa = new InputJasa();
            inputJasa.Show();
        }

        private void btnDataTransaksi_Click(object sender, EventArgs e)
        {
            /*InputTransaksi inputTransaksi = new InputTransaksi();
            inputTransaksi.Show();*/
        }

        private void HalamanUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
