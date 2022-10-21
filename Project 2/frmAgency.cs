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
    public partial class frmAgency : Form
    {
        public frmAgency()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agency ag = new Agency();
            bool validate = false;

            ag.AgencyName=txtAgencyName.Text;
            ag.SurbubID=int.Parse(cmbSurbub.SelectedValue.ToString());


            if (string.IsNullOrEmpty(txtAgencyName.Text))
            {
                errAgency.SetError(txtAgencyName, "Please Enter Agency Name");
                
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbSurbub.Text))
            {
                errAgency.SetError(cmbSurbub, "Please Select surbub.");
               
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                int x=bll.InsertAgency(ag);
                if(x>0)
                {
                    MessageBox.Show(txtAgencyName.Text+" Added");
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Agency ag = new Agency();

            dgvAgency.DataSource = bll.GetAgency();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Agency ag = new Agency();
            ag.AgencyID=int.Parse(txtAgencyID.Text);
            bll.DeleteAgency(ag);
            dgvAgency.DataSource = bll.GetAgency();
        }

        private void frmAgency_Load(object sender, EventArgs e)
        {
            cmbSurbub.DataSource = bll.GetSurbub();
            cmbSurbub.DisplayMember = "SurbubDescription";
            cmbSurbub.ValueMember = "SurbubID";
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmAdminMenu menu = new frmAdminMenu();
            menu.Show();
            this.Hide();
        }

        private void dgvAgency_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgency.SelectedRows.Count > 0)
            {
                txtAgencyID.Text = dgvAgency.SelectedRows[0].Cells["AgencyID"].Value.ToString();
                txtAgencyName.Text = dgvAgency.SelectedRows[0].Cells["AgencyName"].Value.ToString();
                cmbSurbub.Text = dgvAgency.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
                
            }
        }
    }
}
