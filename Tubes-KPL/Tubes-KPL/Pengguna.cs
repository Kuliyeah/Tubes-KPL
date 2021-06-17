using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Tubes_KPL
{
    public partial class Pengguna : Form
    {
        List<PenggunaModel> listPenggunaModel = new List<PenggunaModel>();
        PenggunaModel penggunaModel = new PenggunaModel();
        DataTable dataTable = new DataTable();

        private string path = Environment.CurrentDirectory;
        private string pathJSON = @"\Pengguna.json";

        public Pengguna()
        {
            InitializeComponent();
            DummyData();
            showTable();
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
            btnUpdate.Enabled = false;
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
            btnUpdate.Enabled = true;
            btnNew.Enabled = false;
        }
        private void DummyData()
        {
            penggunaModel = new PenggunaModel("Lovanto", "087823837566", "Bandung", "Lovanto@gmail.com", "Lovanto");
            listPenggunaModel.Add(penggunaModel);
            penggunaModel = new PenggunaModel("Lovanto2", "087823837566", "Bandung", "Lovanto@gmail.com", "Lovanto");
            listPenggunaModel.Add(penggunaModel);
            penggunaModel = new PenggunaModel("Lovanto3", "087823837566", "Bandung", "Lovanto@gmail.com", "Lovanto");
            listPenggunaModel.Add(penggunaModel);
            penggunaModel = new PenggunaModel("Lovanto4", "087823837566", "Bandung", "Lovanto@gmail.com", "Lovanto");
            listPenggunaModel.Add(penggunaModel);
            penggunaModel = new PenggunaModel("Lovanto5", "087823837566", "Bandung", "Lovanto@gmail.com", "Lovanto");
            listPenggunaModel.Add(penggunaModel);
        }

        private void showTable()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("No HP");
            dataTable.Columns.Add("Alamat");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Password");

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
            dgvPengguna.DataSource = dataTable;
        }

        public static void SaveToJSON<T>(T obj, string path)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        private void Pengguna_Load(object sender, System.EventArgs e)
        {
            SetDisabled();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
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

                dataTable.Rows.Add(
                    listPenggunaModel[listPenggunaModel.Count - 1].getUsername().ToString(),
                    listPenggunaModel[listPenggunaModel.Count - 1].getNoHP().ToString(),
                    listPenggunaModel[listPenggunaModel.Count - 1].getAlamatPengguna().ToString(),
                    listPenggunaModel[listPenggunaModel.Count - 1].getEmail().ToString()
                );

                listPenggunaModel.Clear();
                dgvPengguna.DataSource = dataTable;
            }
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
            new Dashboard().Show();
        }

        private void btnExportToJSON_Click(object sender, EventArgs e)
        {
            SaveToJSON<Object>(listPenggunaModel, this.path + this.pathJSON);
        }
    }
}