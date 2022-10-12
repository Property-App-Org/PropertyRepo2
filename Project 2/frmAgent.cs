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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmLogIn lg = new frmLogIn();
            lg.Show();
            this.Hide();
            MessageBox.Show("welcome Back!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            bool validate = false;

            a.Name = txtName.Text;
            a.Surname = txtSurname.Text;
            a.Email = txtEmail.Text;
            a.Password = txtPassword.Text;
            a.Phone = txtPhone.Text;
            a.Status = cmbStatus.SelectedItem.ToString();
            a.AgencyID = int.Parse(cmbAgency.SelectedValue.ToString());
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errAgent.SetError(txtName, "Please enter  Name");
                validate = false;
            }

            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errAgent.SetError(txtSurname, "Please enter Surname");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtEmail.Text)|| (!Regex.IsMatch(txtEmail.Text, @"/^w+[+.w-]*@([w-]+.)*w+[w-]*.([a-z]{2,4}|d+)$/i")))
            {
                errAgent.SetError(txtEmail, "Please enter correct Email format");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text)|| (!Regex.IsMatch(txtPassword.Text, @"^[a-zA-Z0-9!@#%]+$")))
            {
                errAgent.SetError(txtPassword, "Please select End Date");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                errAgent.SetError(txtPhone, "Please eneter phone");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errAgent.SetError(cmbStatus, "Please select status");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbAgency.Text))
            {
                errAgent.SetError(cmbAgency, "Please select Agency");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                bll.InsertAgent(a);
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            dgvAgent.DataSource = bll.GetAgent();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            a.Email = txtName.Text;
            a.Phone = txtPhone.Text;
            a.Status = cmbStatus.SelectedItem.ToString();
            a.AgentID = int.Parse(txtAgent.Text);
            bll.UpdateAgent(a);
            dgvAgent.DataSource = bll.GetAgent();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            a.AgentID = int.Parse(txtAgent.Text);
            bll.DeleteAgent(a);
            dgvAgent.DataSource = bll.GetAgent();
        }

        private void cmbAgency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgent.SelectedRows.Count > 0)
            {
                txtAgent.Text = dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                //cmbAgency.Text = dgvAgent.SelectedRows[0].Cells["AngencyName"].Value.ToString();
            }
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            cmbAgency.DataSource = bll.GetAgency();
            cmbAgency.DisplayMember = "AgencyName";
            cmbAgency.ValueMember = "AgencyID";

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Not Available");
        }

        private void dgvAgent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
