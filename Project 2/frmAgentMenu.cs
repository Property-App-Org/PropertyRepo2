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
    public partial class frmAgentMenu : Form
    {
        public frmAgentMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSearch sch = new frmSearch();
            sch.Show();
            this.Hide();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            frmProperty p = new frmProperty();
            p.Show();
            this.Hide();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            frmAgent a = new frmAgent();
            a.Show();
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
