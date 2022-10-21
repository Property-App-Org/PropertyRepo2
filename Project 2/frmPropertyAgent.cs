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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();
            bool validate = true;

            pa.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
            pa.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            pa.Date=dtaDate.Value;

            if (string.IsNullOrEmpty(cmbProperty.Text))
            {
                errPropertyAgent.SetError(cmbProperty, "select propety");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbAgent.Text))
            {
                errPropertyAgent.SetError(cmbAgent, "select agent");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(dtaDate.Text) )
            {
                errPropertyAgent.SetError(dtaDate, "select correct date");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                bll.InsertPropertyAgent(pa);
            }
           

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();
            dgvPropertyAgent.DataSource = bll.GetPropertyAgent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            PropertyAgent pa = new PropertyAgent();

            pa.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
            pa.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            pa.PropertyAgentID=int.Parse(txtPropertyAgentID.Text);
            pa.Date = dtaDate.Value;

            bll.UpdatePropertAgent(pa);
        }

        private void dgvPropertyAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropertyAgent.SelectedRows.Count > 0)
            {
               
               txtPropertyAgentID.Text= dgvPropertyAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbProperty.Text = dgvPropertyAgent.SelectedRows[0].Cells["Description"].Value.ToString();
                cmbAgent.Text = dgvPropertyAgent.SelectedRows[0].Cells["FullName"].Value.ToString();
                //dtaDate.Text = dgvPropertyAgent.SelectedRows[0].Cells["Date"].Value.ToString();

            }
        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmAdminMenu menu = new frmAdminMenu();
            menu.Show();
            this.Hide();
        }
    }
}
