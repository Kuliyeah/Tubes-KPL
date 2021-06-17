using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class InputTransaksi : Form
    {
        List<InputTransaksiModel> transaksi = new List<InputTransaksiModel>();
        InputTransaksiModel dataTransaksi;
        DataTable dtTransaski;
        DateTime tglSekarang = DateTime.Now;
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"\InputTransaksi.json";

        public InputTransaksi()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setEditEnabled(false);
            btnNew.Enabled = true;
            textTanggal.Text = tglSekarang.ToString();
            dataGridTransaksi.DataSource = dtTransaski;
        }
        private void setEditEnabled(bool stat)
        {
            btnSimpan.Enabled = stat;
            btnBatal.Enabled = true;
            btnNew.Enabled = stat;
            comboBoxIDJasa.Enabled = stat;
            textBerat.Enabled = stat;
            textDeskripsi.Enabled = stat;
            textIDTransaksi.Enabled = stat;
            textOngkir.Enabled = stat;
            textTotal.Enabled = stat;
            textTanggal.Enabled = false;
        }
        private void clearText()
        {
            textIDTransaksi.Text = "";
            textBerat.Text = "";
            textOngkir.Text = "";
            textTotal.Text = "";
            textDeskripsi.Text = "";
            comboBoxIDJasa.Text = "";
        }

        private int cariHargaJasa()
        {
            int harga = 1000;
            return harga;
        }

        public static T ReadFromJson<T>(string path)
        {
            string json = File.ReadAllText(path);
            T obj = JsonConvert.DeserializeObject<T>(json);
            return obj;
        }

        public static void SaveToJson<T>(T obj, string path)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        private int hitungTotal()
        {
            int harga = cariHargaJasa();
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

            int idTransaksi = Int16.Parse(textIDTransaksi.Text);
            int idJasa = Int16.Parse(comboBoxIDJasa.Text);
            String deskripsi = textDeskripsi.Text;
            int berat = Int16.Parse(textBerat.Text);
            int ongkir = Int16.Parse(textOngkir.Text);
            int totalBayar = hitungTotal();
            textTotal.Text = hitungTotal().ToString();


            dataTransaksi = new InputTransaksiModel(tglSekarang, idTransaksi, idJasa, deskripsi,
                berat, ongkir, totalBayar);
            transaksi.Add(dataTransaksi);

            dtTransaski = new DataTable();
            dtTransaski.Columns.Add("Tanggal");
            dtTransaski.Columns.Add("ID Transaksi");
            dtTransaski.Columns.Add("ID Jasa");
            dtTransaski.Columns.Add("Deskripsi");
            dtTransaski.Columns.Add("Berat");
            dtTransaski.Columns.Add("Ongkir");
            dtTransaski.Columns.Add("Total Bayar");

            for (int i = 0; i < transaksi.Count; i++)
            {
                dtTransaski.Rows.Add(
                    transaksi[i].getTanggal().ToString(),
                    transaksi[i].getIdTransaksi().ToString(),
                    transaksi[i].getIdJasa().ToString(),
                    transaksi[i].getDeskripsiCucian().ToString(),
                    transaksi[i].getBeratCucian().ToString(),
                    transaksi[i].getOngkir().ToString(),
                    transaksi[i].getTotalBayar().ToString()
                    );
            }

            dataGridTransaksi.DataSource = dtTransaski;

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            setEditEnabled(false);
            btnNew.Enabled = true;
            this.Hide();
            new Dashboard().Show();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveToJson<Object>(dataTransaksi, path + pathJSON);
        }
    }
}
