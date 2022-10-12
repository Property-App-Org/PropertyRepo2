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
    public partial class frmSurbub : Form
    {
        public frmSurbub()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Surbub sb = new Surbub();
            bool validate = true;

            sb.SurbubDescription = txtSurbubDesc.Text;
            sb.PostalCode = txtPostalCode.Text;
            sb.CityID=int.Parse(cmbCity.SelectedValue.ToString());
            
            if (string.IsNullOrEmpty(cmbCity.Text))
            {
                errSurbub.SetError(cmbCity, "Please select City.");
                validate = false;
            }

            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtSurbubDesc.Text))
            {
                errSurbub.SetError(txtSurbubDesc, "Please Enter Surbub.");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPostalCode.Text))
            {
                errSurbub.SetError(txtPostalCode, "Please Enter Postal Code");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                int x=bll.InsertSurbub(sb);
                if(x>0)
                {
                    MessageBox.Show(txtSurbubDesc.Text+" Succefully Added!");
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Surbub sb = new Surbub();
            dgvSurbub.DataSource = bll.GetSurbub();
        }

        private void dgvSurbub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSurbub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSurbub.SelectedRows.Count > 0)
            {
                txtSurbubDesc.Text = dgvSurbub.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
                txtPostalCode.Text = dgvSurbub.SelectedRows[0].Cells["PostalCode"].Value.ToString();
                cmbCity.Text = dgvSurbub.SelectedRows[0].Cells["CityDescription"].Value.ToString();
                

            }
        }

        private void frmSurbub_Load(object sender, EventArgs e)
        {
            cmbCity.DataSource = bll.GetCity();
            cmbCity.DisplayMember = "CityDescription";
            cmbCity.ValueMember = "CityID";
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmMenu m = new frmMenu();
            m.Show();
            this.Hide();

        }
    }
}
