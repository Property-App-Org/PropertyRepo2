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
    public partial class frmPropertyType : Form
    {
        public frmPropertyType()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyType pty = new PropertyType();
            bool validate = true;

            pty.PropertyTypeDescription = txtPropertyTypeDesc.Text;
            if (string.IsNullOrEmpty(txtPropertyTypeDesc.Text))
            {
                errPropertyType.SetError(txtPropertyTypeDesc, "Please enter property type description");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                int x=bll.InsertPropertyType(pty);
                if(x>0)
                {
                    MessageBox.Show("Property Type Added!");
                }
            }
            

        }

        private void btnlist_Click(object sender, EventArgs e)
        {
            PropertyType pty = new PropertyType();
            dgvPropertyType.DataSource = bll.GetPropertyType();
        }

        private void dgvPropertyType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPropertyType_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
        }
    }
}
