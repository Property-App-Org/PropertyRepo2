using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="Username.Admin"&&txtPassword.Text=="Password@Admin")
            {
                frmAdmin ad = new frmAdmin();
                ad.Show();
                this.Hide();
                MessageBox.Show("Access granted!");
            }
            else if (txtUsername.Text=="Username.Tenant"&&txtPassword.Text=="Password@Tenant")
            {
                frmTenant tn = new frmTenant();
                tn.Show();
                this.Hide();
                MessageBox.Show("Access granted!");
            }
            else if (txtUsername.Text=="Username.Agent"&&txtPassword.Text=="Password@Agent")
            {
                frmAgent ag = new frmAgent();
                ag.Show();
                this.Hide();
                MessageBox.Show("Access granted!");
            }
            else
            {
                MessageBox.Show("Password it's wrong or it does not match with the Username\nPlease Log in again.");
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
            MessageBox.Show("Welcome!\n Please choose the form you wish to open.");
        }
    }
}
