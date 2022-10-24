
namespace Project_2
{
    partial class ucViewAgencies
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAgancyReport = new System.Windows.Forms.DataGridView();
            this.btnViewAgency = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAgencyName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgancyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAgencyName);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.dgvAgancyReport);
            this.groupBox1.Controls.Add(this.btnViewAgency);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 516);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agancies report";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(599, 145);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 42);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(10, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(701, 64);
            this.panel1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLEASE VIEW YOUR AGANCIES";
            // 
            // dgvAgancyReport
            // 
            this.dgvAgancyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgancyReport.Location = new System.Drawing.Point(10, 205);
            this.dgvAgancyReport.Name = "dgvAgancyReport";
            this.dgvAgancyReport.Size = new System.Drawing.Size(701, 298);
            this.dgvAgancyReport.TabIndex = 12;
            // 
            // btnViewAgency
            // 
            this.btnViewAgency.Location = new System.Drawing.Point(459, 145);
            this.btnViewAgency.Name = "btnViewAgency";
            this.btnViewAgency.Size = new System.Drawing.Size(116, 42);
            this.btnViewAgency.TabIndex = 6;
            this.btnViewAgency.Text = "View";
            this.btnViewAgency.UseVisualStyleBackColor = true;
            this.btnViewAgency.Click += new System.EventHandler(this.btnViewAgency_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agencies with more Propertes:";
            // 
            // txtAgencyName
            // 
            this.txtAgencyName.Location = new System.Drawing.Point(251, 155);
            this.txtAgencyName.Name = "txtAgencyName";
            this.txtAgencyName.Size = new System.Drawing.Size(180, 26);
            this.txtAgencyName.TabIndex = 17;
            // 
            // ucViewAgencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucViewAgencies";
            this.Size = new System.Drawing.Size(729, 522);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgancyReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAgancyReport;
        private System.Windows.Forms.Button btnViewAgency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAgencyName;
    }
}
