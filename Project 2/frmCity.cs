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
using BLL;
using DAL;

namespace Project_2
{
    public partial class frmCity : Form
    {
        public frmCity()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            City ct = new City();
            bool validate = false;

            ct.CityDescription = txtDesc.Text;
            ct.ProvinceID = int.Parse(cmbProvince.SelectedValue.ToString());
            
            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                errCity.SetError(txtDesc, "Please enter City");
                
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbProvince.Text))
            {
                errCity.SetError(cmbProvince, "Please select Province");
                
            }
            else
            {
                validate = true;
            }
            
            if (validate)
            {
                int x=bll.InsertCity(ct);
                if(x>0)
                {
                    MessageBox.Show(txtDesc.Text+" City Added!");
                }
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            City ct = new City();
            dgvCity.DataSource = bll.GetCity();
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmAdminMenu m = new frmAdminMenu();
            m.Show();
            this.Hide();
        }

        private void frmCity_Load(object sender, EventArgs e)
        {
            cmbProvince.DataSource = bll.GetProvince();
            cmbProvince.DisplayMember = "Description";
            cmbProvince.ValueMember = "ProvinceID";
        }
    }
}
