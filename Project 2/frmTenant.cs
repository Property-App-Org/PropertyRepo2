using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using System.Text.RegularExpressions;

namespace Project_2
{
    public partial class frmTenant : Form
    {
        public frmTenant()
        {
            InitializeComponent();
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmLogIn lg = new frmLogIn();
            lg.Show();
            this.Hide();
            MessageBox.Show("Welcome Back!");
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            bool validate = true;

            t.Name=txtName.Text;
            t.Surname=txtSurname.Text;
            t.Email=txtEmail.Text;
            t.Password=txtPassword.Text;
            t.Phone=txtPhone.Text;
            t.Status=cmbStatus.SelectedItem.ToString();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errTenant.SetError(txtName, "Please Enter Name.");
                validate = false;
            }

            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errTenant.SetError(txtSurname, "Please Enter Surname.");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtEmail.Text)|| (!Regex.IsMatch(txtEmail.Text, @"/^w+[+.w-]*@([w-]+.)*w+[w-]*.([a-z]{2,4}|d+)$/i")))
            {
                errTenant.SetError(txtEmail, "Please Enter Correct Email format.");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text)|| (!Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9!@#%]+$")))
            {
                errTenant.SetError(txtPassword, "Please enter  Password");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errTenant.SetError(txtPhone, "Please Enter Cell Phone number.");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errTenant.SetError(cmbStatus, "Please Choose Status.");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                bll.InsertTenant(t);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            dgvTenant.DataSource = bll.GetTenant();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();

            
            t.Email=txtEmail.Text;
            t.Phone=txtPhone.Text;
            t.Status=cmbStatus.SelectedItem.ToString();


            int x=bll.UpdateTenant(t);
            if(x>0)
            {
                MessageBox.Show("Updated!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();

            t.TenantID=int.Parse(txtTenantID.Text);
            int x=bll.DeleteTenant(t);
            if(x>0)
            {
                MessageBox.Show("Deleted!");
            }

        }

        private void dgvTenant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTenant.SelectedRows.Count > 0)
            {
                txtTenantID.Text = dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString();
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString();
                
            }
        }

        private void frmTenant_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
            
        }
    }
    
}
