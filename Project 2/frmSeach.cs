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
    public partial class frmSeach : Form
    {
        public frmSeach()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ucViewAgencies1.Hide();
            ucViewLocation1.Hide();
            ucViewProperty1.Hide();
            ucViewRental1.Hide();
            ucViewUser1.Show();
            ucViewUser1.BringToFront();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            ucViewAgencies1.Hide();
            ucViewLocation1.Hide();
            ucViewUser1.Hide();
            ucViewRental1.Hide();
            ucViewProperty1.Show();
            ucViewProperty1.BringToFront();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            ucViewAgencies1.Hide();
            ucViewUser1.Hide();
            ucViewProperty1.Hide();
            ucViewRental1.Hide();
            ucViewLocation1.Show();
            ucViewLocation1.BringToFront();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            ucViewAgencies1.Hide();
            ucViewLocation1.Hide();
            ucViewProperty1.Hide();
            ucViewUser1.Hide();
            ucViewRental1.Show();
            ucViewRental1.BringToFront();
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            ucViewUser1.Hide();
            ucViewLocation1.Hide();
            ucViewProperty1.Hide();
            ucViewRental1.Hide();
            ucViewAgencies1.Show();
            ucViewAgencies1.BringToFront();
        }

        private void frmSeach_Load(object sender, EventArgs e)
        {
            ucViewUser1.Hide();
            ucViewLocation1.Hide();
            ucViewProperty1.Hide();
            ucViewRental1.Hide();
            ucViewAgencies1.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            frmLogIn lg = new frmLogIn();
            lg.Show();
            this.Hide();
        }
    }
}
