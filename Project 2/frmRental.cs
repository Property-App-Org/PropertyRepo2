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

            r.PropertyAgentID = int.Parse( cmbPropertyAgent.SelectedItem.ToString());
            r.TenantID = int.Parse( cmbTenant.SelectedItem.ToString());
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
            if (string.IsNullOrEmpty(dtaStartDate.Text)|| (!Regex.IsMatch(dtaStartDate.Text, @"0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)[0-9]{ 2}")))
            {
                errRental.SetError(dtaStartDate , "Please select Start Date");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(dtaEndDate.Text)|| (!Regex.IsMatch(dtaEndDate.Text, @"0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)[0-9]{ 2}")))
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
                bll.InsertRental(r);
            }
            
        }
    }
}
