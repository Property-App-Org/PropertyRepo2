namespace Project_2
{
    partial class frmLocation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvLocation = new System.Windows.Forms.DataGridView();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbProvince = new System.Windows.Forms.ComboBox();
            this.cmbSurbub = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errLocation = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLocationID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvLocation);
            this.groupBox1.Controls.Add(this.btnMenu);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbProvince);
            this.groupBox1.Controls.Add(this.cmbSurbub);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 527);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Details";
            // 
            // txtLocationID
            // 
            this.txtLocationID.Location = new System.Drawing.Point(210, 31);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.Size = new System.Drawing.Size(215, 26);
            this.txtLocationID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "LocationID:";
            // 
            // dgvLocation
            // 
            this.dgvLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocation.Location = new System.Drawing.Point(20, 278);
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.Size = new System.Drawing.Size(700, 243);
            this.dgvLocation.TabIndex = 10;
            this.dgvLocation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocation_CellClick);
            this.dgvLocation.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocation_CellContentClick);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(583, 213);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(137, 41);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Back";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(391, 213);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(137, 41);
            this.btnList.TabIndex = 8;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(210, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 41);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 213);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(137, 41);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbProvince
            // 
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.Location = new System.Drawing.Point(210, 160);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(215, 28);
            this.cmbProvince.TabIndex = 5;
            // 
            // cmbSurbub
            // 
            this.cmbSurbub.FormattingEnabled = true;
            this.cmbSurbub.Location = new System.Drawing.Point(210, 108);
            this.cmbSurbub.Name = "cmbSurbub";
            this.cmbSurbub.Size = new System.Drawing.Size(215, 28);
            this.cmbSurbub.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(210, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(215, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Province:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surbub:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // errLocation
            // 
            this.errLocation.ContainerControl = this;
            // 
            // frmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 552);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLocation";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.frmLocation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProvince;
        private System.Windows.Forms.ComboBox cmbSurbub;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocation;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ErrorProvider errLocation;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.Label label4;
    }
}