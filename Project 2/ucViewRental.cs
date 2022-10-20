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

namespace Project_2
{
    public partial class ucViewRental : UserControl
    {
        public ucViewRental()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnViewTenant_Click(object sender, EventArgs e)
        {
            Tenant T = new Tenant();
            dgvRentalReport.DataSource=bll.GetTenantAgent();
        }

        private void btnViewEndedRentals_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            dgvRentalReport.DataSource=bll.GetEndedDate();
        }

        private void btnSearchPrice_Click(object sender, EventArgs e)
        {
            Property p = new Property();
            p.Price=double.Parse(txtPrice.Text);
            dgvRentalReport.DataSource=bll.GetRentalByPrice(p);
        }
    }
}
