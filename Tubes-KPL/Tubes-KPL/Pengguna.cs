using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tubes_KPL
{
    public partial class Pengguna : Form
    {
        PenggunaModel penggunaModel = new PenggunaModel();
        DataTable dataTable = new DataTable();
        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"../../../json/Pengguna.json";
        Automata.State posisi = Automata.State.INPUT_PENGGUNA, nextPosisi;

        public Pengguna()
        {
            InitializeComponent();

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

        private void ClearTextBox()
        {
            txtUsername.Text = null;
            txtNoHP.Text = null;
            txtAlamat.Text = null;
            txtEmail.Text = null;
            txtKataSandi.Text = null;
        }

        private void SetDisabled()
        {
            txtUsername.Enabled = false;
            txtNoHP.Enabled = false;
            txtAlamat.Enabled = false;
            txtEmail.Enabled = false;
            txtKataSandi.Enabled = false;

            btnSave.Enabled = false;
            btnNew.Enabled = true;
        }

        private void SetEnabled()
        {
            txtUsername.Enabled = true;
            txtNoHP.Enabled = true;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtKataSandi.Enabled = true;

            btnSave.Enabled = true;
            btnNew.Enabled = false;
        }

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

        private void Pengguna_Load(object sender, System.EventArgs e)
        {
            SetDisabled();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            SetEnabled();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ClearTextBox();
            SetDisabled();
            this.Hide();

            nextPosisi = Automata.State.DASHBOARD;
            Automata.setPosisi(posisi, nextPosisi);
            Automata.posisiTransition(nextPosisi);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            List<PenggunaModel> listPenggunaModel = new List<PenggunaModel>();
            String username = txtUsername.Text;
            String noHP = txtNoHP.Text;
            String alamat = txtAlamat.Text;
            String email = txtEmail.Text;
            String kataSandi = txtKataSandi.Text;

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