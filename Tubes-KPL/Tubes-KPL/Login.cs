using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tubes_KPL
{
    public partial class Login : Form
    {
        string user, pass;
        
        Double count = 0;
        public Login()
        {
            InitializeComponent();
            user = "ALPUKAT";
            pass = TableDriven.getKodeUser(TableDriven.Username.ALPUKAT);
            tbUsername.Text = user;
            tbPassword.Text = pass;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text == user) && (tbPassword.Text == pass))
            {
                MessageBox.Show("Welcome User");
                new Dashboard().Show();
                this.Hide();
            }
            else
            {
                count = count + 1;
                double maxcount = 3;
                double remain;
                remain = maxcount - count;
                MessageBox.Show("Wrong user name or password" + "\t" + remain + "" + "tries left");
                tbPassword.Clear();
                tbUsername.Clear();
                tbUsername.Focus();
                if (count == maxcount)
                {
                    MessageBox.Show("Max try exceeded.");
                    Application.Exit();
                }
            }
        }
    }
}
