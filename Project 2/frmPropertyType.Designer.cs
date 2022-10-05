namespace Project_2
{
    partial class frmPropertyType
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
            this.dgvPropertyType = new System.Windows.Forms.DataGridView();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.btnlist = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPropertyTypeDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errPropertyType = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPropertyType)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dgvPropertyType);
            this.groupBox1.Controls.Add(this.btnBackTo);
            this.groupBox1.Controls.Add(this.btnlist);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtPropertyTypeDesc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Type Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(367, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 41);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvPropertyType
            // 
            this.dgvPropertyType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyType.Location = new System.Drawing.Point(13, 139);
            this.dgvPropertyType.Name = "dgvPropertyType";
            this.dgvPropertyType.Size = new System.Drawing.Size(463, 189);
            this.dgvPropertyType.TabIndex = 7;
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(249, 78);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(98, 39);
            this.btnBackTo.TabIndex = 6;
            this.btnBackTo.Text = "MENU";
            this.btnBackTo.UseVisualStyleBackColor = true;
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(127, 78);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(98, 39);
            this.btnlist.TabIndex = 5;
            this.btnlist.Text = "LIST";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 78);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 39);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPropertyTypeDesc
            // 
            this.txtPropertyTypeDesc.Location = new System.Drawing.Point(210, 28);
            this.txtPropertyTypeDesc.Name = "txtPropertyTypeDesc";
            this.txtPropertyTypeDesc.Size = new System.Drawing.Size(266, 26);
            this.txtPropertyTypeDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Property Type Description:";
            // 
            // errPropertyType
            // 
            this.errPropertyType.ContainerControl = this;
            // 
            // frmPropertyType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 370);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPropertyType";
            this.Text = "frmPropertyType";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPropertyType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPropertyType;
        private System.Windows.Forms.Button btnBackTo;
        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPropertyTypeDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errPropertyType;
    }
}