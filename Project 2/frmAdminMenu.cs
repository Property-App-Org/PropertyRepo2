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
    public partial class frmAdminMenu : Form
    {
        public frmAdminMenu()
        {
            InitializeComponent();
        }

        private void frmAdminMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogIn lgin = new frmLogIn();
            lgin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmUser u = new frmUser();
            u.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin ad = new frmAdmin();
            ad.Show();
            this.Hide();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            frmPropertyType pt = new frmPropertyType();
            pt.Show();
            this.Hide();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            frmProperty pro = new frmProperty();
            pro.Show();
            this.Hide();
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            frmProvince p = new frmProvince();
            p.Show();
            this.Hide();
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            frmCity c = new frmCity();
            c.Show();
            this.Hide();
        }

        private void btnSurbub_Click(object sender, EventArgs e)
        {
            frmSurbub su = new frmSurbub();
            su.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            frmLocation loc = new frmLocation();
            loc.Show();
            this.Show();
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            frmAgency ag = new frmAgency();
            ag.Show();
            this.Hide();
        }

        private void btnPropertyAgent_Click(object sender, EventArgs e)
        {
            frmPropertyAgent pa = new frmPropertyAgent();
            pa.Show();
            this.Hide();
        }
    }
}
