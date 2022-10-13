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
    public partial class frmRental : Form
    {
        public frmRental()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();
            bool validate = true;

            r.PropertyAgentID = int.Parse( cmbPropertyAgent.SelectedValue.ToString());
            r.TenantID = int.Parse( cmbTenant.SelectedValue.ToString());
            r.StartDate = dtaStartDate.Text;
            r.EndDate = dtaEndDate.Text;

            if (string.IsNullOrEmpty(cmbPropertyAgent.Text))
            {
                errRental.SetError(cmbPropertyAgent, "Please select Property Agent");
                validate = false;
            }

            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbTenant.Text))
            {
                errRental.SetError(cmbTenant, "Please select Tenant");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(dtaStartDate.Text))
            {
                errRental.SetError(dtaStartDate , "Please select Start Date");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(dtaEndDate.Text))
            {
                errRental.SetError(dtaEndDate, "Please select End Date");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if(validate)
            {
                int x =bll.InsertRental(r);
                if(x>0)
                {
                    MessageBox.Show("Rental Added!");
                }
            }
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();
            dgvRental.DataSource = bll.GetRental();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rental r = new Rental();

            r.RentalID=int.Parse(txtRentalID.Text);
            r.StartDate =dtaStartDate.Text;
            r.EndDate = dtaEndDate.Text;
            
            bll.UpdateRental(r);
            dgvRental.DataSource = bll.GetRental();
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                txtRentalID.Text = dgvRental.SelectedRows[0].Cells["RentalID"].Value.ToString();
                cmbPropertyAgent.Text = dgvRental.SelectedRows[0].Cells["FullName"].Value.ToString();
                cmbTenant.Text = dgvRental.SelectedRows[0].Cells["FullName"].Value.ToString();
                dtaStartDate.Text = dgvRental.SelectedRows[0].Cells["StartDate"].Value.ToString();
                dtaEndDate.Text = dgvRental.SelectedRows[0].Cells["EndDate"].Value.ToString();
               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmRental_Load(object sender, EventArgs e)
        {
            cmbPropertyAgent.DataSource = bll.GetPropertyAgent();
            cmbPropertyAgent.DisplayMember = "FullName";
            cmbPropertyAgent.ValueMember = "PropertyAgentID";

            cmbTenant.DataSource = bll.GetTenant();
            cmbTenant.DisplayMember = "FullName";
            cmbTenant.ValueMember = "TenantID";
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();
        }
    }
}
