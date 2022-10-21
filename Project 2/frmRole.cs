using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BLL;
using DAL;

namespace Project_2
{
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Role r = new Role();
            bool validate = false;

            r.RoleDesc = txtRoleDesc.Text;

            if (string.IsNullOrEmpty(txtRoleDesc.Text))
            {
                errRole.SetError(txtRoleDesc, "Please enter Role Description.");
                
            }
            else
            {
                validate = true;
            }
            
            if (validate)
            {
                int x = bll.InsertRole(r);
                if (x>0)
                {
                    MessageBox.Show(txtRoleDesc.Text+" Role Added!");
                }
            }
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmUser u = new frmUser();
            u.Show();
            this.Hide();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvRole.DataSource=bll.GetRole();
        }
    }
}
