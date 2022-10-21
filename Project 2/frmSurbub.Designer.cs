namespace Project_2
{
    partial class frmSurbub
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvSurbub = new System.Windows.Forms.DataGridView();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtSurbubDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errSurbub = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurbub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSurbub)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dgvSurbub);
            this.groupBox1.Controls.Add(this.btnBackTo);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.txtSurbubDesc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(696, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Surbub Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(537, 188);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 41);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvSurbub
            // 
            this.dgvSurbub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSurbub.Location = new System.Drawing.Point(20, 250);
            this.dgvSurbub.Name = "dgvSurbub";
            this.dgvSurbub.Size = new System.Drawing.Size(657, 169);
            this.dgvSurbub.TabIndex = 11;
            this.dgvSurbub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSurbub_CellClick);
            this.dgvSurbub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSurbub_CellContentClick);
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(367, 190);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(128, 37);
            this.btnBackTo.TabIndex = 10;
            this.btnBackTo.Text = "Back";
            this.btnBackTo.UseVisualStyleBackColor = true;
            this.btnBackTo.Click += new System.EventHandler(this.btnBackTo_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(189, 190);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(128, 37);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 190);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 37);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(244, 112);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(251, 28);
            this.cmbCity.TabIndex = 7;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(244, 77);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(251, 26);
            this.txtPostalCode.TabIndex = 6;
            // 
            // txtSurbubDesc
            // 
            this.txtSurbubDesc.Location = new System.Drawing.Point(244, 38);
            this.txtSurbubDesc.Name = "txtSurbubDesc";
            this.txtSurbubDesc.Size = new System.Drawing.Size(251, 26);
            this.txtSurbubDesc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "City:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postal Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surbub Description:";
            // 
            // errSurbub
            // 
            this.errSurbub.ContainerControl = this;
            // 
            // frmSurbub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSurbub";
            this.Text = "frmSurbub";
            this.Load += new System.EventHandler(this.frmSurbub_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSurbub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSurbub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSurbub;
        private System.Windows.Forms.Button btnBackTo;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtSurbubDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errSurbub;
    }
}