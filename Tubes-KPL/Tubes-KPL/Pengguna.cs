using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class Pengguna : Form
    {
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
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
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
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
            btnNew.Enabled = false;
        }

        private void Pengguna_Load(object sender, System.EventArgs e)
        {
            SetDisabled();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {

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