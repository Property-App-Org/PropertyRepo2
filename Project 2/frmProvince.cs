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
using System.Text.RegularExpressions;

namespace Project_2
{
    public partial class frmProvince : Form
    {
        public frmProvince()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Province pr = new Province();
            bool validate = true;

            pr.Description = txtDesc.Text;
            

            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                errorProvince.SetError(txtDesc, "Please enter description");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                int x =bll.InsertProvince(pr);
                if(x>0)
                {
                    MessageBox.Show("Province added!");
                }
            }
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Province pr = new Province();
            dgvProvince.DataSource = bll.GetProvince();
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
