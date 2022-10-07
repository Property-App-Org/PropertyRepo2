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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogIn lg = new frmLogIn();
            lg.Show();
            this.Hide();
            MessageBox.Show("Welcome Back!");
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin ad = new frmAdmin();
            ad.Show();
            this.Hide();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            frmPropertyType pty = new frmPropertyType();
            pty.Show();
            this.Hide();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            frmProperty pt = new frmProperty();
            pt.Show();
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
            frmSurbub s = new frmSurbub();
            s.Show();
            this.Hide();

        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            frmAgency ag = new frmAgency();
            ag.Show();
            this.Hide();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            frmAgent a = new frmAgent();
            a.Show();
            this.Hide();
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            frmTenant t = new frmTenant();
            t.Show();
            this.Hide();
        }

        private void btnPropertyAgent_Click(object sender, EventArgs e)
        {
            frmPropertyAgent pa = new frmPropertyAgent();
            pa.Show();
            this.Hide();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            frmRental r = new frmRental();
            r.Show();
            this.Hide();
        }
    }
}
