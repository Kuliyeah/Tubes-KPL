using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{//dz
    public partial class Login : Form
    {
        string user, pass;
        
        Double count = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            // Set hiden password.
            tbPassword.ForeColor = Color.Black;
            tbPassword.PasswordChar = '●';
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure?", "Alert", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                new Dashboard().Show();
                this.Hide();
            }
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Enum nm1 = TableDriven.Username.user;
            user = nm1.ToString();
            pass = TableDriven.getKodeUser(TableDriven.Username.user);

            // Untuk cek bahwa username yang dimasukkan tidak boleh lebih kecil sama dengan 3.
            Debug.Assert(tbUsername.Text.Length > 3, "Username terlalu pendek");

            if ((tbUsername.Text == user) && (tbPassword.Text == pass))
            {
                
                MessageBox.Show("Welcome User", "Hi");
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password "+ remain + " tries left", "Alert");
                tbPassword.Clear();
                tbUsername.Clear();
                tbUsername.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded.", "Warning");
                    Application.Exit();
                }
            }
        }
    }
}
