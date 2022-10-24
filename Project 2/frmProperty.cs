using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using DAL;
using BLL;

namespace Project_2
{
    public partial class frmProperty : Form
    {
        public frmProperty()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        string ImageLoc = " ";

        private void btnAdd_Click(object sender, EventArgs e)
        { 
            Property pt = new Property();

            bool validate = false;
            byte[] images = null;
            FileStream Stream = new FileStream(ImageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(Stream);
            images = reader.ReadBytes((int)Stream.Length);

            pt.Description = txtpropertyDesc.Text;
            pt.Price = double.Parse(txtPrice.Text.ToString());
            pt.Image = images;
            pt.PropertyTypeID = int.Parse(cmbPropertyType.SelectedValue.ToString());
            pt.SurbubID = int.Parse(cmbSurbub.SelectedValue.ToString());
            pt.Status = cmbStatus.SelectedItem.ToString();

            if (string.IsNullOrEmpty(txtpropertyDesc.Text))
            {
                errDescription.SetError(txtpropertyDesc, "Please enter property description");
               
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPrice.Text) || (!Regex.IsMatch(txtPrice.Text, @"^[0-9]+[.[0-9]]+]?")))
            {
                errDescription.SetError(txtPrice, "Please enter correct price format");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbPropertyType.Text))
            {
                errDescription.SetError(cmbPropertyType, "Please enter property type");
                
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errDescription.SetError(cmbStatus, "select status");
                
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbSurbub.Text))
            {
                errDescription.SetError(cmbSurbub, "Please enter surbub");
                
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                bll.InsertProperty(pt);
            }

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            Property pt = new Property();

            dgvProperty.DataSource = bll.GetProperty();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Property pt = new Property();
            pt.PropertyTypeID = int.Parse(cmbPropertyType.SelectedValue.ToString());
            pt.Price = double.Parse(txtPrice.Text);
            pt.Status = cmbStatus.SelectedItem.ToString();
            pt.PropertyID=int.Parse(txtPropertyID.Text);
            int x=bll.UpdateProperty(pt);
            if (x>0)
            {
                MessageBox.Show("Updated Successfully");
            }
            dgvProperty.DataSource = bll.GetProperty();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Property pt = new Property();          
            pt.PropertyID = int.Parse(txtPropertyID.Text);
            bll.DeleteProperty(pt);
            dgvProperty.DataSource = bll.GetProperty();
        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
            txtPropertyID.Enabled=false;
            cmbPropertyType.DataSource = bll.GetPropertyType();
            cmbPropertyType.DisplayMember = "PropertyTypeDescription";
            cmbPropertyType.ValueMember = "PropertyTypeID";

            cmbSurbub.DataSource = bll.GetSurbub();
            cmbSurbub.DisplayMember = "SurbubDescription";
            cmbSurbub.ValueMember = "SurbubID";

            cmbStatus.Items.Add("Approved");
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("Full");
        }

        private void dgvProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProperty.SelectedRows.Count > 0)
            {
                txtPropertyID.Text = dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txtpropertyDesc.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = dgvProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                pbxImage.Text = dgvProperty.SelectedRows[0].Cells["Image"].Value.ToString();
                cmbPropertyType.Text = dgvProperty.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
                cmbStatus.Text = dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbSurbub.Text = dgvProperty.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();

            }
        }

        private void txtpropertyDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBackTo_Click(object sender, EventArgs e)
        {
            frmAgentMenu agmenu = new frmAgentMenu();
            agmenu.Show();
            this.Hide();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.jpg; *.jpeg; *.png; *.gif; *.bmp)| *.jpg; *.jpeg; *.png; *.gif; *.bmp;| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageLoc = dialog.FileName.ToString();
                pbxImage.ImageLocation = ImageLoc;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdminMenu adM = new frmAdminMenu();
            adM.Show();
            this.Hide();
        }
    }
}
