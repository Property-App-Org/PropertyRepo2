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
    public partial class frmRole : Form
    {
        public frmRole()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            City ct = new City();
            bool validate = true;

            ct.CityDescription = txtDesc.Text;
            ct.ProvinceID = int.Parse(cmbProvince.SelectedValue.ToString());

            if (string.IsNullOrEmpty(txtDesc.Text))
            {
                errCity.SetError(txtDesc, "Please enter City");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbProvince.Text))
            {
                errCity.SetError(cmbProvince, "Please select Province");
                validate = false;
            }
            else
            {
                validate = true;
            }

            if (validate)
            {
                int x = bll.InsertCity(ct);
                if (x>0)
                {
                    MessageBox.Show(txtDesc.Text+" City Added!");
                }
            }
        }
    }
}
