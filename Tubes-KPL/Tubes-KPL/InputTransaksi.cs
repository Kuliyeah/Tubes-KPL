using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class InputTransaksi : Form
    {
        // Init var.
        DataTable dtTransaksi = new DataTable(), dtJasa;
        DateTime tglSekarang = DateTime.Now;
        string pathDir = Environment.CurrentDirectory;
        string pathTransaksi = @"../../../json/InputTransaksi.json";
        string pathJasa = @"../../../json/InputJasa.json";
        string pathMoney = @"../../../json/MoneyConfig.json";
        moneyConfig money;
        Automata.State posisi = Automata.State.INPUT_TRANSAKSI, nextPosisi;

        public InputTransaksi()
        {
            InitializeComponent();

            // Membaca file InputTransaksi.json.
            try
            {
                dtTransaksi = Config.ReadFromJson<DataTable>(pathDir + pathTransaksi);
            }
            // Membuat file InputTransaksi.json jika file tersebut belum tersedia.
            catch
            {
                // Set dummy data.
                DummyData();

                Config.SaveToJson<DataTable>(dtTransaksi, pathDir + pathTransaksi);
            }

            // Tampilkan data dari InputTransaksi.json
            dgvTransaksi.DataSource = dtTransaksi;
        }

        // Membuat Data palsu untuk JSON.
        private void DummyData()
        {
            dtTransaksi.Columns.Add("Tanggal");
            dtTransaksi.Columns.Add("ID Transaksi");
            dtTransaksi.Columns.Add("Nama Jasa");
            dtTransaksi.Columns.Add("Deskripsi");
            dtTransaksi.Columns.Add("Berat (Kg)");
            dtTransaksi.Columns.Add("Ongkir");
            dtTransaksi.Columns.Add("Total Bayar");
            dtTransaksi.Rows.Add(DateTime.Now, "1234", "Test Jasa", "Deskripsi Test Jasa", "2", "5000", "15000");
        }

        // Method yang dijalankan ketika InputTransaksi.cs dalam posisi show.
        private void Form1_Load(object sender, EventArgs e)
        {
            setEditEnabled(false);
            btnNew.Enabled = true;
            tbTanggal.Text = tglSekarang.ToString();
            setComboboxNamaJasa();

            // Membaca file MoneyConfig.json dan menyimpan ke var money.
            money = Config.ReadFromJson<moneyConfig>(pathDir + pathMoney);

            // Set tampilan text pada LbMoney.
            if (money.getMoneyConfig() == "Rupiah")
            {
                LbMoney.Text = "Mata Uang : Rupiah";
            }
            else
            {
                LbMoney.Text = "Mata Uang : USD";
            }
            convertMataUang();
        }

        // Mengaktifkan/Menonaktifkan sebagian tombol dan text box.
        private void setEditEnabled(bool stat)
        {
            btnSimpan.Enabled = stat;
            btnBatal.Enabled = true;
            btnNew.Enabled = stat;
            cbNamaJasa.Enabled = stat;
            tbBerat.Enabled = stat;
            tbDeskripsi.Enabled = stat;
            tbIDTransaksi.Enabled = stat;
            tbOngkir.Enabled = stat;
            tbTotal.Enabled = stat;
            tbTanggal.Enabled = false;
        }

        // Untuk me-reset text yang sudah diinputkan pada text box.
        private void clearText()
        {
            tbIDTransaksi.Text = "";
            tbBerat.Text = "";
            tbOngkir.Text = "";
            tbTotal.Text = "";
            tbDeskripsi.Text = "";
            cbNamaJasa.Text = "";
        }

        // Untuk mencari harga jasa.
        private int cariHargaJasa()
        {
            // Membaca file InputJasa.json dan me-return harga.
            dtJasa = Config.ReadFromJson<DataTable>(pathDir + pathJasa);
            int harga = Int32.Parse(dtJasa.Rows[cbNamaJasa.SelectedIndex][2].ToString());
            return harga;
        }

        // Untuk menghitung total bayar.
        private int hitungTotal(int berat, int harga, int ongkir)
        {
            int total = berat * harga + ongkir;
            return total;
        }

        // Set data combobox nama jasa.
        private void setComboboxNamaJasa()
        {
            // Membaca file InputJasa.json.
            try
            {
                dtJasa = Config.ReadFromJson<DataTable>(pathDir + pathJasa);
            }
            // Membuat file InputJasa.json jika file tersebut belum tersedia.
            catch
            {
                // Membuat tabel data
                dtJasa = new DataTable();
                dtJasa.Columns.Add("Nama Toko");
                dtJasa.Columns.Add("Nama Jasa");
                dtJasa.Columns.Add("Harga");
                dtJasa.Columns.Add("Jumlah Paket");
                dtJasa.Columns.Add("Deskripsi Jasa");
                Config.SaveToJson<DataTable>(dtJasa, pathDir + pathJasa);
            }

            // Set data combobox nama jasa.
            cbNamaJasa.DataSource = dtJasa;
            cbNamaJasa.DisplayMember = "Nama Jasa";
        }

        // Ketika btnNew di klik, maka akan memanggil beberapa method dan menonaktifkan sebagian tombol dan text box.
        private void btnNew_Click(object sender, EventArgs e)
        {
            clearText();
            setEditEnabled(true);
            btnNew.Enabled = false;
            tbTotal.Enabled = false;
        }

        // Ketika btnSimpan di klik, akan menyimpan data yang diinput kedalam dgvTransaksi.
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Membuat List.
            List<InputTransaksiModel> transaksi = new List<InputTransaksiModel>();

            // Set button dan text box.
            setEditEnabled(false);
            btnNew.Enabled = true;

            // Set dan ambil nilai dari input user.
            int idTransaksi = Int32.Parse(tbIDTransaksi.Text);
            String namaJasa = cbNamaJasa.Text;
            String deskripsi = tbDeskripsi.Text;
            int berat = Int32.Parse(tbBerat.Text);
            int ongkir = Int32.Parse(tbOngkir.Text);
            int totalBayar = hitungTotal(berat, cariHargaJasa(), ongkir);
            tbTotal.Text = totalBayar.ToString();

            // Memasukan data kedalam list.
            transaksi.Add(new InputTransaksiModel(tglSekarang, idTransaksi, namaJasa, deskripsi,
                berat, ongkir, totalBayar));

            // Mengisi tabel data dengan data dari list.
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

            // Menampilkan data ke UI.
            dgvTransaksi.DataSource = dtTransaksi;

            // Simpan dan update data ke file InputTransaksi.json.
            Config.SaveToJson<DataTable>(dtTransaksi, pathDir + pathTransaksi);
        }

        // Ketika btnBatal di klik, maka mengosongkan semua textBox, menonaktifkan sebagian tombol,
        // lalu menutup UI InputTransaksi dan menampikan UI dashboard.
        private void btnBatal_Click(object sender, EventArgs e)
        {
            clearText();
            setEditEnabled(false);
            btnNew.Enabled = true;
            this.Hide();

            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
        }

        // Untuk mengubah mata uang dari Rupiah ke USD dan sebaliknya.
        public void convertMataUang()
        {
            // Membaca file MoneyConfig.json.
            money = Config.ReadFromJson<moneyConfig>(pathDir + pathMoney);

            // Merubah data ongkir dan total dari Rupiah ke USD atau sebaliknya.
            if (money.getMoneyConfig() == "USD")
            {
                for (int i = 0; i < dgvTransaksi.RowCount - 1; i++)
                {
                    dgvTransaksi.Rows[i].Cells[5].Value = (Double.Parse(dgvTransaksi.Rows[0 + i].Cells[5].Value.ToString()) / 14000).ToString().Substring(0, 4);
                    dgvTransaksi.Rows[i].Cells[6].Value = (Double.Parse(dgvTransaksi.Rows[0 + i].Cells[6].Value.ToString()) / 14000).ToString().Substring(0, 4);
                }
            }
        }

    }
}
