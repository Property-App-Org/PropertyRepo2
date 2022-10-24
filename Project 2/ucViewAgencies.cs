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
    public partial class ucViewAgencies : UserControl
    {
        public ucViewAgencies()
        {
            InitializeComponent();
        }

        private void btnViewAgency_Click(object sender, EventArgs e)
        {
            dgvAgancyReport.DataSource=bll.GetAllPropertyByAgency();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Agency ag = new Agency();
            ag.AgencyName=txtAgencyName.Text;
            dgvAgancyReport.DataSource=bll.GetPropertyByAgencyName(ag);
        }
    }
}
