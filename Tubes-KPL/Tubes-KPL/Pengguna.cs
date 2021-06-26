using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tubes_KPL
{
    public partial class Pengguna : Form
    {
        // Init var.
        PenggunaModel penggunaModel = new PenggunaModel();
        DataTable dataTable = new DataTable();
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/Pengguna.json";
        Automata.State posisi = Automata.State.INPUT_PENGGUNA, nextPosisi;

        // Constructor pengguna.
        public Pengguna()
        {
            InitializeComponent();
            CreateDataTable();
        }

        // Membaca data yang ada pada file JSON jika terdapat file JSON,
        // Jika tidak, maka buat file JSON dari method DummyData(),
        // Lalu tampilkan di dgvPengguna.
        private void CreateDataTable()
        {
            try
            {
                dataTable = Config.ReadFromJson<DataTable>(path + pathJSON);
            }
            catch
            {
                DummyData();
                Config.SaveToJson<DataTable>(dataTable, path + pathJSON);
            }

            dgvPengguna.DataSource = dataTable;
        }

        // Mengosongkan semua textbox.
        private void ClearTextBox()
        {
            tbUsername.Text = null;
            tbNoHP.Text = null;
            tbAlamat.Text = null;
            tbEmail.Text = null;
            tbKataSandi.Text = null;
        }

        // Menonaktifkan sebagian tombol, kecuali btnNew.
        private void SetDisabled()
        {
            tbUsername.Enabled = false;
            tbNoHP.Enabled = false;
            tbAlamat.Enabled = false;
            tbEmail.Enabled = false;
            tbKataSandi.Enabled = false;

            btnSave.Enabled = false;
            btnNew.Enabled = true;
        }

        // Mengaktifkan sebagian tombol, kecuali btnNew.
        private void SetEnabled()
        {
            tbUsername.Enabled = true;
            tbNoHP.Enabled = true;
            tbAlamat.Enabled = true;
            tbEmail.Enabled = true;
            tbKataSandi.Enabled = true;

            btnSave.Enabled = true;
            btnNew.Enabled = false;
        }

        // Membuat Data palsu untuk JSON.
        private void DummyData()
        {
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("No Telp");
            dataTable.Columns.Add("Alamat");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Password");

            dataTable.Rows.Add("Lovanto", "087823837566", "Bandung", "Lovanto@gmail.com", "Lovanto");
            dataTable.Rows.Add("Gilang", "087823837566", "Sukabumi", "Gilang@gmail.com", "Gilang123");
            dataTable.Rows.Add("Adam", "087823837566", "Sumedang", "Adam@gmail.com", "Adam123");
            dataTable.Rows.Add("Ramadhan", "087823837566", "Lombok", "Ramadhan@gmail.com", "Ramadhan123");
            dataTable.Rows.Add("Dzakwan", "087823837566", "Lampung", "Dzakwan@gmail.com", "Dzakwan123");
        }

        // Method yang dijalankan ketika Pengguna.cs dalam posisi show.
        private void Pengguna_Load(object sender, System.EventArgs e)
        {
            SetDisabled();
        }

        // Ketika btnNew di klik, maka akan mengaktifkan sebagian tombol, kecuali btnNew.
        private void btnNew_Click(object sender, System.EventArgs e)
        {
            SetEnabled();
        }

        // Ketika btnCancel di klik, maka mengosongkan semua textBox, 
        // menonaktifkan sebagian tombol, lalu menutup UI pengguna.
        // dan menampikan UI dashboard.
        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ClearTextBox();
            SetDisabled();
            this.Hide();

            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
        }

        // Menyembunyikan UI pengguna dan menampilkan UI dashboard..
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        // Ketika btnSave di klik, maka akan menyimpan data
        // yang ada pada textBox ke dgvPengguna dan pengguna.json.
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            List<PenggunaModel> listPenggunaModel = new List<PenggunaModel>();
            String username = tbUsername.Text;
            String noHP = tbNoHP.Text;
            String alamat = tbAlamat.Text;
            String email = tbEmail.Text;
            String kataSandi = tbKataSandi.Text;

            Debug.Assert(noHP.Length == 12 || noHP.Length == 13, "Nomor telp minimal 12 digit dan maksimal 13 digit.");
            Debug.Assert(email.Contains("@") && email.Contains("."), "Email harus mengandung karakter @ dan .");
            if (((noHP.Length == 12 || noHP.Length == 13) && (email.Contains("@") && email.Contains("."))) == false) ClearTextBox();
            else
            {
                penggunaModel = new PenggunaModel(username, noHP, alamat, email, kataSandi);
                listPenggunaModel.Add(penggunaModel);

                for (int i = 0; i < listPenggunaModel.Count; i++)
                {
                    dataTable.Rows.Add(
                        listPenggunaModel[i].getUsername().ToString(),
                        listPenggunaModel[i].getNoHP().ToString(),
                        listPenggunaModel[i].getAlamatPengguna().ToString(),
                        listPenggunaModel[i].getEmail().ToString(),
                        listPenggunaModel[i].getKataSandi().ToString()
                        );
                }

                Config.SaveToJson<DataTable>(dataTable, path + pathJSON);
                dgvPengguna.DataSource = dataTable;
            }
        }

    }
}