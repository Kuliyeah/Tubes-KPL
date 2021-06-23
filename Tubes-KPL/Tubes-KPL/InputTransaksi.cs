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
        DataTable dtTransaksi, dtJasa;
        DateTime tglSekarang = DateTime.Now;
        private string pathDir = Environment.CurrentDirectory;
        private string pathTransaksi = @"../../../json/InputTransaksi.json";
        private string pathJasa= @"../../../json/InputJasa.json";
        private string pathMoney = @"../../../json/MoneyConfig.json";
        private moneyConfig money;

        public InputTransaksi()
        {
            InitializeComponent();

            try //jika file JSON sudah ada maka akan membaca data tersebut
            {
                dtTransaksi = Config.ReadFromJson<DataTable>(pathDir + pathTransaksi);
            }
            catch //jika file JSON belum ada maka akan membuat file JSON
            {
                //membuat tabel data
                dtTransaksi = new DataTable();
                dtTransaksi.Columns.Add("Tanggal");
                dtTransaksi.Columns.Add("ID Transaksi");
                dtTransaksi.Columns.Add("ID Jasa");
                dtTransaksi.Columns.Add("Deskripsi");
                dtTransaksi.Columns.Add("Berat (Kg)");
                dtTransaksi.Columns.Add("Ongkir");
                dtTransaksi.Columns.Add("Total Bayar");

                Config.SaveToJson<DataTable>(dtTransaksi, pathDir + pathTransaksi);
            }

            //tampilkan data dari InputTransaksi.json
            dataGridTransaksi.DataSource = dtTransaksi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            setEditEnabled(false);
            btnNew.Enabled = true;
            textTanggal.Text = tglSekarang.ToString();
            setComboboxNamaJasa();

            money = Config.ReadFromJson<moneyConfig>(pathDir + pathMoney);
            if (money.getMoneyConfig() == "Rupiah")
            {
                LbMoney.Text = "Mata Uang : Rupiah";
            }
            else
            {
                LbMoney.Text = "Mata Uang : USD";
            }
        }
        private void setEditEnabled(bool stat)
        {
            btnSimpan.Enabled = stat;
            btnBatal.Enabled = true;
            btnNew.Enabled = stat;
            comboBoxNamaJasa.Enabled = stat;
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
            comboBoxNamaJasa.Text = "";
        }

        private int cariHargaJasa()
        {
            dtJasa = Config.ReadFromJson<DataTable>(pathDir + pathJasa);
            int harga = Int32.Parse(dtJasa.Rows[comboBoxNamaJasa.SelectedIndex][2].ToString());

            return harga;
        }

        private int hitungTotal(int berat, int harga, int ongkir)
        {
            int total = berat * harga + ongkir;
            return total;
        }

        private void setComboboxNamaJasa()
        {
            try //jika file JSON sudah ada maka akan membaca data tersebut
            {
                dtJasa = Config.ReadFromJson<DataTable>(pathDir + pathJasa);
            }
            catch //jika file JSON belum ada maka akan membuat file JSON
            {
                //membuat tabel data
                dtJasa = new DataTable();
                dtJasa.Columns.Add("Nama Toko");
                dtJasa.Columns.Add("Nama Jasa");
                dtJasa.Columns.Add("Harga");
                dtJasa.Columns.Add("Jumlah Paket");
                dtJasa.Columns.Add("Deskripsi Jasa");

                Config.SaveToJson<DataTable>(dtJasa, pathDir + pathJasa);
            }

            comboBoxNamaJasa.DataSource = dtJasa;
            comboBoxNamaJasa.DisplayMember = "Nama Jasa";
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
            List<InputTransaksiModel> transaksi = new List<InputTransaksiModel>();

            //set button
            setEditEnabled(false);
            btnNew.Enabled = true;

            //set dan ambil nilai dari input user
            int idTransaksi = Int32.Parse(textIDTransaksi.Text);
            String namaJasa = comboBoxNamaJasa.Text;
            String deskripsi = textDeskripsi.Text;
            int berat = Int32.Parse(textBerat.Text);
            int ongkir = Int32.Parse(textOngkir.Text);
            int totalBayar = hitungTotal(berat, cariHargaJasa(), ongkir);
            textTotal.Text = totalBayar.ToString();

            //masukan data kedalam list
            transaksi.Add(new InputTransaksiModel(tglSekarang, idTransaksi, namaJasa, deskripsi,
                berat, ongkir, totalBayar));

            //isi tabel data dengan data dari list
            for (int i = 0; i < transaksi.Count; i++)
            {
                dtTransaksi.Rows.Add(
                    transaksi[i].getTanggal().ToString(),
                    transaksi[i].getIdTransaksi().ToString(),
                    transaksi[i].getNamaJasa().ToString(),
                    transaksi[i].getDeskripsiCucian().ToString(),
                    transaksi[i].getBeratCucian().ToString(),
                    transaksi[i].getOngkir().ToString(),
                    transaksi[i].getTotalBayar().ToString()
                    );
            }

            //tampilkan data ke UI
            dataGridTransaksi.DataSource = dtTransaksi;

            //simpan dan update data ke JSON
            Config.SaveToJson<DataTable>(dtTransaksi, pathDir + pathTransaksi);
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
