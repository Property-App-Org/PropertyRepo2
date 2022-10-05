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
           
             BusinessLogicLayer bll = new BusinessLogicLayer();
            string ImageLoc = " ";
             OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.jpg; *.jpeg; *.png; *.gif; *.bmp)| *.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ImageLoc = dialog.FileName.ToString();
                pbxImage.ImageLocation = ImageLoc;
            }

            Property pt = new Property();

            bool validate = true;
            byte[] images = null;
            FileStream Stream = new FileStream(ImageLoc, FileMode.Open, FileAccess.Read);
            BinaryReader reader = new BinaryReader(Stream);
            images = reader.ReadBytes((int)Stream.Length);

            pt.Description = txtpropertyDesc.Text;
            pt.Price = double.Parse(txtPrice.Text.ToString());
            pt.Image = images;
            pt.PropertyID = int.Parse(cmbPropertyType.SelectedValue.ToString());
            pt.SurbubID = int.Parse(cmbSurbub.SelectedValue.ToString());
            pt.Status = cmbStatus.SelectedItem.ToString();

            if (string.IsNullOrEmpty(txtpropertyDesc.Text))
            {
                errDescription.SetError(txtpropertyDesc, "Please enter property description");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(txtPrice.Text) || (!Regex.IsMatch(txtPrice.Text, @"^[0-9]+[.[0-0]]+?")))
            {
                errDescription.SetError(txtPrice, "Please enter correct price format");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(pbxImage.Text))
            {
                errDescription.SetError(pbxImage, "Insert Image");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbPropertyType.Text))
            {
                errDescription.SetError(cmbPropertyType, "Please enter property type");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbStatus.Text))
            {
                errDescription.SetError(cmbStatus, "select status");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (string.IsNullOrEmpty(cmbSurbub.Text))
            {
                errDescription.SetError(cmbSurbub, "Please enter surbub");
                validate = false;
            }
            else
            {
                validate = true;
            }
            if (validate)
            {
                bll.InsertProerty(pt);
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
            pt.PropertyTypeID = int.Parse(cmbPropertyType.SelectedItem.ToString());
            pt.Price = int.Parse(txtPrice.Text);
            pt.Status = cmbStatus.SelectedItem.ToString();
            bll.UpdateProperty(pt);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Property pt = new Property();
            pt.PropertyTypeID = int.Parse(cmbPropertyType.SelectedItem.ToString());
            pt.Price = int.Parse(txtPrice.Text);
            pt.Status = cmbStatus.SelectedItem.ToString();
            bll.DeleteProperty(pt);
        }

        private void frmProperty_Load(object sender, EventArgs e)
        {
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
                txtpropertyDesc.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = dgvProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                pbxImage.Text = dgvProperty.SelectedRows[0].Cells["Image"].Value.ToString();
                cmbPropertyType.Text = dgvProperty.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
                cmbStatus.Text = dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbSurbub.Text = dgvProperty.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();

            }
        }
    }
}
