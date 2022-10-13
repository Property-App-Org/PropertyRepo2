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

namespace Project_2
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            Location loc = new Location();
            bool validate;

            loc.Address=txtAddress.Text;
            loc.SurbubID=int.Parse(cmbSurbub.SelectedValue.ToString());
            loc.ProvinceID=int.Parse(cmbProvince.SelectedValue.ToString());

            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                errLocation.SetError(txtAddress, "Please enter Address");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbSurbub.Text))
            {
                errLocation.SetError(cmbSurbub, "Please select Surbub");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbProvince.Text))
            {
                errLocation.SetError(cmbProvince, "Please select Province");
                validate = false;
            }
            else
            {
                validate = true;
            }
            
            if (validate)
            {
                int x=bll.InsertLocation(loc);
                if(x>0)
                {
                    MessageBox.Show(txtAddress.Text+" Added!");
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Location loc = new Location();

            loc.LocationID=int.Parse(txtLocationID.Text);
            loc.Address=txtAddress.Text;
            loc.SurbubID=int.Parse(cmbSurbub.SelectedValue.ToString());
            loc.ProvinceID=int.Parse(cmbProvince.SelectedValue.ToString());
            
            bll.UpdateLocation(loc);
            dgvLocation.DataSource = bll.GetLocation();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Location loc = new Location();
            dgvLocation.DataSource = bll.GetLocation();
        }

        private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLocation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvLocation.SelectedRows.Count > 0)
            {
                txtLocationID.Text = dgvLocation.SelectedRows[0].Cells["LocationID"].Value.ToString();
                txtAddress.Text = dgvLocation.SelectedRows[0].Cells["Address"].Value.ToString();
                cmbProvince.Text = dgvLocation.SelectedRows[0].Cells["Description"].Value.ToString();
                cmbSurbub.Text = dgvLocation.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
                
            }
        }

        private void frmLocation_Load(object sender, EventArgs e)
        {
            cmbProvince.DataSource = bll.GetProvince();
            cmbProvince.DisplayMember = "Description";
            cmbProvince.ValueMember = "ProvinceID";

            cmbSurbub.DataSource = bll.GetSurbub();
            cmbSurbub.DisplayMember = "SurbubDescription";
            cmbSurbub.ValueMember = "SurbubID";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu men = new frmMenu();
            men.Show();
            this.Hide();
        }
    }
}
