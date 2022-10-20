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
    public partial class ucViewUser : UserControl
    {
        public ucViewUser()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnViewAdmin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();

            dgvUserReport.DataSource = bll.GetAdmin();
        }

        private void btnViewAgent_Click(object sender, EventArgs e)
        {
            Agent a = new Agent();
            dgvUserReport.DataSource = bll.GetAgent();
        }

        private void btnViewTenant_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            dgvUserReport.DataSource = bll.GetTenant();
        }

        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.Name=txtAdmin.Text;
            dgvUserReport.DataSource=bll.GetAdminByName(ad);

        }

        private void btnSearchAgent_Click(object sender, EventArgs e)
        {
            Agent ag = new Agent();
            ag.Name=txtAgent.Text;
            dgvUserReport.DataSource=bll.GetAgentByName(ag);
        }

        private void btnSearchTenant_Click(object sender, EventArgs e)
        {
            Tenant t = new Tenant();
            t.Name=txtTenant.Text;
            dgvUserReport.DataSource=bll.GetTenantByName(t);
        }
    }
}
