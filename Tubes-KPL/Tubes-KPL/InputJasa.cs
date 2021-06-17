using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class InputJasa : Form
    {
        List<InputJasaModel> jasa = new List<InputJasaModel>();
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"\InputJasa.json";
        public InputJasa()
        {
            InitializeComponent();
        }

        public static void SaveToJSON<T>(T obj, string path)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String namaToko = tbNamaToko.Text;
            String namaJasa = tbNamaJasa.Text;
            int harga = Int32.Parse(tbHarga.Text);
            int jumlahPaket = Int32.Parse(tbJlhPaket.Text);
            if(jumlahPaket<2 || harga < 5000)
            {
                tbHarga.Text = String.Empty;
                tbJlhPaket.Text = String.Empty;
                tbHarga.Focus();
            }
            else
            {
                int hargaTotal = harga * jumlahPaket;
                String deskripsi = tbDeskripsi.Text;

                InputJasaModel dataJasa = new InputJasaModel(namaToko, namaJasa, harga, jumlahPaket, deskripsi);
                jasa.Add(dataJasa);

                DataTable dtJasa = new DataTable();
                dtJasa.Columns.Add("Nama Toko");
                dtJasa.Columns.Add("Nama Jasa");
                dtJasa.Columns.Add("Harga");
                dtJasa.Columns.Add("Jumlah Paket");
                dtJasa.Columns.Add("Total Harga");
                dtJasa.Columns.Add("Deskripsi Jasa");

                for (int i = 0; i < jasa.Count; i++)
                {
                    dtJasa.Rows.Add(
                        jasa[i].getNamaToko().ToString(),
                        jasa[i].getNamaJasa().ToString(),
                        "Rp. " + jasa[i].getHarga().ToString(),
                        jasa[i].getJumlahPaket().ToString(),
                        "Rp. " + (hargaTotal).ToString(),
                        jasa[i].getDeskripsi().ToString()
                        );
                }

                SaveToJSON<Object>(dataJasa, this.path + this.pathJSON);
                tgvJasa.DataSource = dtJasa;
                
                tbNamaToko.Text = String.Empty;
                tbNamaJasa.Text = String.Empty;
                tbHarga.Text = String.Empty;
                tbJlhPaket.Text = String.Empty;
                tbDeskripsi.Text = String.Empty;
            }


        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void InputJasa_Load(object sender, EventArgs e)
        {
            btnBatal.Enabled = false;
            btnSimpan.Enabled = false;
            tbNamaToko.Enabled = false;
            tbNamaJasa.Enabled = false;
            tbHarga.Enabled = false;
            tbJlhPaket.Enabled = false;
            tbDeskripsi.Enabled = false;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            btnBatal.Enabled = true;
            btnSimpan.Enabled = true;
            tbNamaToko.Enabled = true;
            tbNamaJasa.Enabled = true;
            tbHarga.Enabled = true;
            tbJlhPaket.Enabled = true;
            tbDeskripsi.Enabled = true;
            btnNew.Enabled = false;
        }
    }
}
