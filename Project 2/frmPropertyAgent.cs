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
using System.Text.RegularExpressions;

namespace Project_2
{
    public partial class frmPropertyAgent : Form
    {
        public frmPropertyAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPropertyAgent_Load(object sender, EventArgs e)
        {
            cmbAgent.DataSource = bll.GetAgent();
            cmbAgent.DisplayMember = "Name";
            cmbAgent.ValueMember = "AgentID";

            cmbProperty.DataSource = bll.GetProperty();
            cmbProperty.DisplayMember = "Description";
            cmbProperty.ValueMember = "PropertyID";
        }
    }
}
