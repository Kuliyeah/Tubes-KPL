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
    public partial class InputJasa : Form
    {
        List<InputJasaModel> jasa = new List<InputJasaModel>();
        public InputJasa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String namaToko = tbNamaToko.Text;
            String namaJasa = tbNamaJasa.Text;
            int harga = Int32.Parse(tbHarga.Text);
            String deskripsi = tbDeskripsi.Text;
            InputJasaModel dataJasa = new InputJasaModel(namaToko, namaJasa, harga, deskripsi);
            jasa.Add(dataJasa);

            DataTable dtJasa = new DataTable();
            dtJasa.Columns.Add("Nama Toko");
            dtJasa.Columns.Add("Nama Jasa");
            dtJasa.Columns.Add("Harga");
            dtJasa.Columns.Add("Deskripsi Jasa");

            for(int i =0; i< jasa.Count; i++)
            {
                dtJasa.Rows.Add(dataJasa[i].getNamaToko);
            }

            tgvJasa.DataSource = dtJasa;
        }
    }
}
