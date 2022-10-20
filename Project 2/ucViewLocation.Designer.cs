
namespace Project_2
{
    partial class ucViewLocation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLocationReport = new System.Windows.Forms.DataGridView();
            this.btnListProvinces = new System.Windows.Forms.Button();
            this.btnListCities = new System.Windows.Forms.Button();
            this.btnListSurbubs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationReport)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnListSurbubs);
            this.groupBox1.Controls.Add(this.dgvLocationReport);
            this.groupBox1.Controls.Add(this.btnListProvinces);
            this.groupBox1.Controls.Add(this.btnListCities);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 499);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location Report";
            // 
            // dgvLocationReport
            // 
            this.dgvLocationReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocationReport.Location = new System.Drawing.Point(6, 265);
            this.dgvLocationReport.Name = "dgvLocationReport";
            this.dgvLocationReport.Size = new System.Drawing.Size(765, 228);
            this.dgvLocationReport.TabIndex = 12;
            // 
            // btnListProvinces
            // 
            this.btnListProvinces.Location = new System.Drawing.Point(6, 155);
            this.btnListProvinces.Name = "btnListProvinces";
            this.btnListProvinces.Size = new System.Drawing.Size(312, 42);
            this.btnListProvinces.TabIndex = 7;
            this.btnListProvinces.Text = "List Provinces";
            this.btnListProvinces.UseVisualStyleBackColor = true;
            this.btnListProvinces.Click += new System.EventHandler(this.btnListProvinces_Click);
            // 
            // btnListCities
            // 
            this.btnListCities.Location = new System.Drawing.Point(6, 95);
            this.btnListCities.Name = "btnListCities";
            this.btnListCities.Size = new System.Drawing.Size(312, 42);
            this.btnListCities.TabIndex = 6;
            this.btnListCities.Text = "List Cities";
            this.btnListCities.UseVisualStyleBackColor = true;
            this.btnListCities.Click += new System.EventHandler(this.btnListCities_Click);
            // 
            // btnListSurbubs
            // 
            this.btnListSurbubs.Location = new System.Drawing.Point(6, 216);
            this.btnListSurbubs.Name = "btnListSurbubs";
            this.btnListSurbubs.Size = new System.Drawing.Size(312, 42);
            this.btnListSurbubs.TabIndex = 13;
            this.btnListSurbubs.Text = "List Surbubs";
            this.btnListSurbubs.UseVisualStyleBackColor = true;
            this.btnListSurbubs.Click += new System.EventHandler(this.btnListSurbubs_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 64);
            this.panel1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLEASE VIEW YOUR LOCATIONS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ucViewLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucViewLocation";
            this.Size = new System.Drawing.Size(783, 507);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocationReport)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListSurbubs;
        private System.Windows.Forms.DataGridView dgvLocationReport;
        private System.Windows.Forms.Button btnListProvinces;
        private System.Windows.Forms.Button btnListCities;
    }
}
