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
    public partial class ucViewLocation : UserControl
    {
        public ucViewLocation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnListCities_Click(object sender, EventArgs e)
        {
            City c = new City();
            dgvLocationReport.DataSource=bll.GetCity();
        }

        private void btnListProvinces_Click(object sender, EventArgs e)
        {
            Province p = new Province();
            dgvLocationReport.DataSource=bll.GetProvince();
        }

        private void btnListSurbubs_Click(object sender, EventArgs e)
        {
            Surbub s = new Surbub();
            dgvLocationReport.DataSource=bll.GetSurbub();
        }
    }
}
