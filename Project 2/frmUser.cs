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
using DAL;
using BLL;

namespace Project_2
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
             User u = new User();
            bool validate = true;

            u.Name = txtName.Text;
            u.Surname=txtSurname.Text;
            u.Email=txtEmail.Text;
            u.Password=txtPassword.Text;
            u.RoleID=int.Parse(cmbRoleDesc.SelectedValue.ToString());

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errUser.SetError(txtName, "Please enter your Name.");
                validate = false;
            }
            else
            {
                validate = true;
            }

            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errUser.SetError(txtSurname, "Please enter your Surname.");
                validate = false;
            }
            else
            {
                validate = true;
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errUser.SetError(txtEmail, "Please enter the correct Email format.");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errUser.SetError(txtPassword, "Please enter Password.");
                validate = false;
            }
            if (string.IsNullOrEmpty(cmbRoleDesc.Text))
            {
                errUser.SetError(cmbRoleDesc, "Please select a role.");
                validate = false;
            }
            else
            {
                validate = true;
            }

            if (validate)
            {
               bll.InsertUser(u);
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource=bll.GetUser();
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmAdminMenu l = new frmAdminMenu();
            l.Show();
            this.Hide();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            cmbRoleDesc.DataSource = bll.GetRole();
            cmbRoleDesc.DisplayMember = "RoleDescription";
            cmbRoleDesc.ValueMember = "RoleID";
        }
    }
}
