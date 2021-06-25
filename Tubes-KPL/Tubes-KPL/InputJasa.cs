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
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/InputJasa.json";
        private string pathMoney = @"../../../json/MoneyConfig.json";
        private moneyConfig money;
        DataTable dtJasa = new DataTable();
        Automata.State posisi = Automata.State.INPUT_JASA, nextPosisi;

        public InputJasa()
        {
            InitializeComponent();

            try
            {
                dtJasa = Config.ReadFromJson<DataTable>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<DataTable>(dtJasa, path + pathJSON);
            }
            
            dataGridJasa.DataSource = dtJasa;
            convertMataUang();
        }

        private void DummyData()
        {
            dtJasa.Columns.Add("Nama Toko");
            dtJasa.Columns.Add("Nama Jasa");
            dtJasa.Columns.Add("Harga");
            dtJasa.Columns.Add("Jumlah Paket");
            dtJasa.Columns.Add("Deskripsi Jasa");



            dtJasa.Rows.Add("Toko Sukses", "Test Jasa", "5500", "1", "Deskripsi Test");
        }

        private void cleartTextBox()
        {
            tbNamaToko.Text = String.Empty;
            tbNamaJasa.Text = String.Empty;
            tbHarga.Text = String.Empty;
            tbJlhPaket.Text = String.Empty;
            tbDeskripsi.Text = String.Empty;
        }
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
        }

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

                dataGridJasa.DataSource = dtJasa;

                Config.SaveToJson<DataTable>(dtJasa, path + pathJSON);
                btnNew.Enabled = true;
                btnSimpan.Enabled = false;
            }
        }

        public void convertMataUang()
        {
            money = Config.ReadFromJson<moneyConfig>(path + pathMoney);
            if (money.getMoneyConfig() == "USD")
            {
                for (int i = 0; i < dataGridJasa.RowCount-1; i++)
                {
                    dataGridJasa.Rows[i].Cells[2].Value = (Double.Parse(dataGridJasa.Rows[0 + i].Cells[2].Value.ToString())/14000).ToString().Substring(0, 4);
                }
            }
        }
    }
}
