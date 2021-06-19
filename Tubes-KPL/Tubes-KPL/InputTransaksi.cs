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
        DataTable dtTransaksi;
        DateTime tglSekarang = DateTime.Now;
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"\InputTransaksi.json";

        public InputTransaksi()
        {
            InitializeComponent();

            try //jika file JSON sudah ada maka akan membaca data tersebut
            {
                dtTransaksi = ReadFromJson<DataTable>(path + pathJSON);
            }
            catch //jika file JSON belum ada maka akan membuat file JSON
            {
                //membuat tabel data
                DataTable dtTransaksi = new DataTable();
                dtTransaksi.Columns.Add("Tanggal");
                dtTransaksi.Columns.Add("ID Transaksi");
                dtTransaksi.Columns.Add("ID Jasa");
                dtTransaksi.Columns.Add("Deskripsi");
                dtTransaksi.Columns.Add("Berat");
                dtTransaksi.Columns.Add("Ongkir");
                dtTransaksi.Columns.Add("Total Bayar");

                SaveToJson<DataTable>(dtTransaksi, path + pathJSON);
            }

            //tampilkan data dari InputTransaksi.json
            dataGridTransaksi.DataSource = dtTransaksi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setEditEnabled(false);
            btnNew.Enabled = true;
            textTanggal.Text = tglSekarang.ToString();
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
            //set button
            setEditEnabled(false);
            btnNew.Enabled = true;

            //set dan ambil nilai dari input user
            int idTransaksi = Int16.Parse(textIDTransaksi.Text);
            int idJasa = Int16.Parse(comboBoxIDJasa.Text);
            String deskripsi = textDeskripsi.Text;
            int berat = Int16.Parse(textBerat.Text);
            int ongkir = Int16.Parse(textOngkir.Text);
            int totalBayar = hitungTotal();
            textTotal.Text = hitungTotal().ToString();

            //masukan data kedalam list
            transaksi.Add(new InputTransaksiModel(tglSekarang, idTransaksi, idJasa, deskripsi,
                berat, ongkir, totalBayar));

            //isi tabel data dengan data dari list
            for (int i = 0; i < transaksi.Count; i++)
            {
                dtTransaksi.Rows.Add(
                    transaksi[i].getTanggal().ToString(),
                    transaksi[i].getIdTransaksi().ToString(),
                    transaksi[i].getIdJasa().ToString(),
                    transaksi[i].getDeskripsiCucian().ToString(),
                    transaksi[i].getBeratCucian().ToString(),
                    transaksi[i].getOngkir().ToString(),
                    transaksi[i].getTotalBayar().ToString()
                    );
            }

            //tampilkan data ke UI
            dataGridTransaksi.DataSource = dtTransaksi;

            //simpan dan update data ke JSON
            SaveToJson<DataTable>(dtTransaksi, path + pathJSON);
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
