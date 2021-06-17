using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Tubes_KPL
{
    public partial class Pengguna : Form
    {
        List<PenggunaModel> listPenggunaModel = new List<PenggunaModel>();
        public Pengguna()
        {
            InitializeComponent();
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
            btnCancel.Enabled = false;
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
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
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

            PenggunaModel penggunaModel = new PenggunaModel(username, noHP, alamat, email, kataSandi);
            listPenggunaModel.Add(penggunaModel);

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("No HP");
            dataTable.Columns.Add("Alamat");
            dataTable.Columns.Add("Email");

            for (int i = 0; i < listPenggunaModel.Count; i++)
            {
                dataTable.Rows.Add(
                    listPenggunaModel[i].getUsername().ToString(),
                    listPenggunaModel[i].getNoHP().ToString(),
                    listPenggunaModel[i].getAlamatPengguna().ToString(),
                    listPenggunaModel[i].getEmail().ToString()
                );
            }
            dgvPengguna.DataSource = dataTable;
            ClearTextBox();
        }

        private void btnNew_Click(object sender, System.EventArgs e)
        {
            SetEnabled();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            ClearTextBox();
            SetDisabled();
        }
    }
}