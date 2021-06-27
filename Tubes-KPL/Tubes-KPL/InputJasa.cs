using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class InputJasa : Form
    {
        // Inisialisasi variabel dan memberikan value pada variabel tertentu
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/InputJasa.json";
        private string pathMoney = @"../../../json/MoneyConfig.json";
        private moneyConfig money;
        DataTable dtJasa = new DataTable();
        Automata.State posisi = Automata.State.INPUT_JASA, nextPosisi;

        public InputJasa()
        {
            InitializeComponent();

            // Memanggil data dari json (Deserialisasi) untuk ditampilkan pada tabrl data grid view
            try
            {
                dtJasa = Config.ReadFromJson<DataTable>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<DataTable>(dtJasa, path + pathJSON);
            }
            
            dgvJasa.DataSource = dtJasa;
            convertMataUang();
        }

        // Menggunakan dummy data untuk menampilkan data jika tidak ada file export (Serialisasi)
        private void DummyData()
        {
            dtJasa.Columns.Add("Nama Toko");
            dtJasa.Columns.Add("Nama Jasa");
            dtJasa.Columns.Add("Harga");
            dtJasa.Columns.Add("Jumlah Paket");
            dtJasa.Columns.Add("Deskripsi Jasa");

            dtJasa.Rows.Add("Toko Sukses", "Test Jasa", "5500", "1", "Deskripsi Test");
        }

        // Action pada button batal untuk membatalkan inputan jasa dan kembali ke dashboard
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
        }

        // Memberikan Enablization pada button yang diperlukan ketika menginput data jasa
        private void InputJasa_Load(object sender, EventArgs e)
        {
            btnBatal.Enabled = true;
            btnSimpan.Enabled = false;
            tbNamaToko.Enabled = false;
            tbNamaJasa.Enabled = false;
            tbHarga.Enabled = false;
            tbJlhPaket.Enabled = false;
            tbDeskripsi.Enabled = false;

            money = Config.ReadFromJson<moneyConfig>(path + pathMoney);
            if (money.getMoneyConfig() == "Rupiah")
            {
                LbMoney.Text = "Mata Uang : Rupiah";
            }
            else
            {
                LbMoney.Text = "Mata Uang : USD";
            }
        }

        // Memberikan Enablization pada button tertentu jika mengklik button new
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

        // Memberikan action menyimpan data yang telah terisi pada form untuk diserialisasi (Export)
        // Kedalam bentuk json dan menampilkan data dari form ke table data grid view
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            List<InputJasaModel> jasa = new List<InputJasaModel>();

            // Menyimpan isi dari textbox ke dalam variabel baru
            String namaToko = tbNamaToko.Text;
            String namaJasa = tbNamaJasa.Text;
            int harga = Int32.Parse(tbHarga.Text);
            int jumlahPaket = Int32.Parse(tbJlhPaket.Text);
            String deskripsi = tbDeskripsi.Text;
            if (jumlahPaket < 2 || harga < 5000)
            {
                tbHarga.Text = String.Empty;
                tbJlhPaket.Text = String.Empty;
                tbHarga.Focus();
            }
            else
            {
                // Masukan data kedalam list
                jasa.Add(new InputJasaModel("Rupiah", namaToko, namaJasa, harga, jumlahPaket, deskripsi));

                for (int i = 0; i < jasa.Count; i++)
                {

                    dtJasa.Rows.Add(
                        jasa[i].getNamaToko().ToString(),
                        jasa[i].getNamaJasa().ToString(),
                        jasa[i].getHargaPerPaket().ToString(),
                        jasa[i].getJumlahPaket().ToString(),
                        jasa[i].getDeskripsi().ToString()
                        );
                }

                dgvJasa.DataSource = dtJasa;

                Config.SaveToJson<DataTable>(dtJasa, path + pathJSON);
                btnNew.Enabled = true;
                btnSimpan.Enabled = false;
            }
        }

        private void tbHarga_TextChanged(object sender, EventArgs e)
        {

        }

        // Mengonversi nilai atau value dari data number menjadi USD yang secara default adalah rupiah
        public void convertMataUang()
        {
            money = Config.ReadFromJson<moneyConfig>(path + pathMoney);
            if (money.getMoneyConfig() == "USD")
            {
                for (int i = 0; i < dgvJasa.RowCount-1; i++)
                {
                    dgvJasa.Rows[i].Cells[2].Value = (Double.Parse(dgvJasa.Rows[0 + i].Cells[2].Value.ToString())/14000).ToString().Substring(0, 4);
                }
            }
        }

    }
}
