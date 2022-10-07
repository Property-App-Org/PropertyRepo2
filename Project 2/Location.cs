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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnAdd_Click(object sender, EventArgs e)
        {

            DAL.Location loc = new DAL.Location();

            loc.Address=txtAddress.Text;
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
