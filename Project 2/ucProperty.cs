﻿using System;
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
    public partial class ucProperty : UserControl
    {
        public ucProperty()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnSearchAdmin_Click(object sender, EventArgs e)
        {
            Property pt = new Property();

            dgvProperty.DataSource = bll.GetProperty();
        }
    }
}
