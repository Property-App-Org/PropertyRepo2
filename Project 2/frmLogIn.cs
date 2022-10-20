using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;


namespace Project_2
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.Login(txtEmail.Text, txtPassword.Text);
            

            if(dt.Rows.Count>0)
            {
                string role = dt.Rows[0]["RoleDescription"].ToString();
                if(role=="Admin")
                {
                    frmAdmin ad = new frmAdmin();
                    ad.Show();
                    this.Hide();
                    
                    
                }
                else if (role=="Tenant")
                {
                    frmTenant t = new frmTenant();
                    t.Show();
                    this.Hide();
                    
                }
                else if (role=="Agent")
                {
                    frmAgent ag = new frmAgent();
                    ag.Show();
                    this.Hide();
                }

            }
            else
            {
                txtEmail.Clear();
                txtPassword.Clear();
                lblWrong.Visible=true;
                //MessageBox.Show("Access Denied!");
                
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            lblWrong.Visible=false;
        }

        private void lblWarning_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUser u = new frmUser();
            u.Show();
            this.Hide();
        }
    }
}
