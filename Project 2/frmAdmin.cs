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
using System.Text.RegularExpressions;
using BLL;

namespace Project_2
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.AdminID=int.Parse(txtAdminID.Text);
            bll.DeleteAdmin(ad);
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
            Admin ad = new Admin();
            bool validate;

            ad.AdminID=int.Parse(txtAdminID.Text);
            ad.Name=txtName.Text;
            ad.Surname=txtSurname.Text;
            ad.Email=txtEmail.Text;
            ad.Password=txtPassword.Text;
            ad.Status=cmbStatus.Text;
            ad.PropertyID=int.Parse(cmbProperty.SelectedItem.ToString());
            ad.PropertyTypeID=int.Parse(cmbPropertyType.SelectedItem.ToString());
            ad.LocationID=int.Parse(cmbLocation.SelectedItem.ToString());
            ad.AgentID=int.Parse(cmbAgent.SelectedItem.ToString());
            ad.AgencyID=int.Parse(cmbAgency.SelectedItem.ToString());
            

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errAdmin.SetError(txtName, "Please enter Name");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtSurname.Text) )
            {
                errAdmin.SetError(txtSurname, "Please enter Surname");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtEmail.Text)|| (!Regex.IsMatch(txtEmail.Text, @"/^w+[+.w-]*@([w-]+.)*w+[w-]*.([a-z]{2,4}|d+)$/i")))
            {
                errAdmin.SetError(txtEmail, "Please enter correct Email format");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text)|| (!Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9!@#%]+$")))
            {
                errAdmin.SetError(txtPassword, "Please enter  Password");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errAdmin.SetError(cmbStatus, "select status");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbProperty.Text))
            {
                errAdmin.SetError(cmbProperty, "Please select property");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbPropertyType.Text))
            {
                errAdmin.SetError(cmbPropertyType, "Please select propertyType");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbLocation.Text))
            {
                errAdmin.SetError(cmbLocation, "Please select Location");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbAgent.Text))
            {
                errAdmin.SetError(cmbAgent, "Please select Agent");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbAgency.Text))
            {
                errAdmin.SetError(cmbAgency, "Please select Agency");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                bll.InsertAdmin(ad);
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();

            dgvAdmin.DataSource = bll.GetAdmin();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Email=txtEmail.Text;
            ad.Password=txtPassword.Text;
            ad.Status=cmbStatus.SelectedItem.ToString();
            ad.PropertyID=int.Parse(cmbProperty.SelectedValue.ToString());
            ad.PropertyTypeID=int.Parse(cmbPropertyType.SelectedValue.ToString());
            ad.LocationID=int.Parse(cmbLocation.SelectedValue.ToString());
            ad.AgentID=int.Parse(cmbAgent.SelectedValue.ToString());
            ad.AgencyID=int.Parse(cmbAgency.SelectedValue.ToString());
            
            bll.UpdateAdmin(ad);
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAdmin.SelectedRows.Count > 0)
            {
                txtAdminID.Text = dgvAdmin.SelectedRows[0].Cells["AdminID"].Value.ToString();
                txtName.Text = dgvAdmin.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAdmin.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAdmin.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAdmin.SelectedRows[0].Cells["Password"].Value.ToString();
                cmbStatus.Text = dgvAdmin.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbProperty.Text = dgvAdmin.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                cmbPropertyType.Text = dgvAdmin.SelectedRows[0].Cells["PropertyTypeID"].Value.ToString();
                cmbLocation.Text = dgvAdmin.SelectedRows[0].Cells["Location"].Value.ToString();
                cmbAgent.Text = dgvAdmin.SelectedRows[0].Cells["AgentID"].Value.ToString();
                cmbAgency.Text = dgvAdmin.SelectedRows[0].Cells["AgencyID"].Value.ToString();

            }
        }
    }
}
