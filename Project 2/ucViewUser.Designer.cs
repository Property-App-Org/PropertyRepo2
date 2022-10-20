
namespace Project_2
{
    partial class ucViewUser
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
            this.dgvUserReport = new System.Windows.Forms.DataGridView();
            this.btnViewTenant = new System.Windows.Forms.Button();
            this.btnViewAgent = new System.Windows.Forms.Button();
            this.btnViewAdmin = new System.Windows.Forms.Button();
            this.btnSearchTenant = new System.Windows.Forms.Button();
            this.btnSearchAgent = new System.Windows.Forms.Button();
            this.btnSearchAdmin = new System.Windows.Forms.Button();
            this.txtTenant = new System.Windows.Forms.TextBox();
            this.txtAgent = new System.Windows.Forms.TextBox();
            this.txtAdmin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUserReport);
            this.groupBox1.Controls.Add(this.btnViewTenant);
            this.groupBox1.Controls.Add(this.btnViewAgent);
            this.groupBox1.Controls.Add(this.btnViewAdmin);
            this.groupBox1.Controls.Add(this.btnSearchTenant);
            this.groupBox1.Controls.Add(this.btnSearchAgent);
            this.groupBox1.Controls.Add(this.btnSearchAdmin);
            this.groupBox1.Controls.Add(this.txtTenant);
            this.groupBox1.Controls.Add(this.txtAgent);
            this.groupBox1.Controls.Add(this.txtAdmin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Report";
            // 
            // dgvUserReport
            // 
            this.dgvUserReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserReport.Location = new System.Drawing.Point(33, 187);
            this.dgvUserReport.Name = "dgvUserReport";
            this.dgvUserReport.Size = new System.Drawing.Size(701, 150);
            this.dgvUserReport.TabIndex = 12;
            // 
            // btnViewTenant
            // 
            this.btnViewTenant.Location = new System.Drawing.Point(597, 118);
            this.btnViewTenant.Name = "btnViewTenant";
            this.btnViewTenant.Size = new System.Drawing.Size(114, 42);
            this.btnViewTenant.TabIndex = 11;
            this.btnViewTenant.Text = "View";
            this.btnViewTenant.UseVisualStyleBackColor = true;
            this.btnViewTenant.Click += new System.EventHandler(this.btnViewTenant_Click);
            // 
            // btnViewAgent
            // 
            this.btnViewAgent.Location = new System.Drawing.Point(597, 76);
            this.btnViewAgent.Name = "btnViewAgent";
            this.btnViewAgent.Size = new System.Drawing.Size(114, 42);
            this.btnViewAgent.TabIndex = 10;
            this.btnViewAgent.Text = "View";
            this.btnViewAgent.UseVisualStyleBackColor = true;
            this.btnViewAgent.Click += new System.EventHandler(this.btnViewAgent_Click);
            // 
            // btnViewAdmin
            // 
            this.btnViewAdmin.Location = new System.Drawing.Point(597, 36);
            this.btnViewAdmin.Name = "btnViewAdmin";
            this.btnViewAdmin.Size = new System.Drawing.Size(114, 42);
            this.btnViewAdmin.TabIndex = 9;
            this.btnViewAdmin.Text = "View";
            this.btnViewAdmin.UseVisualStyleBackColor = true;
            this.btnViewAdmin.Click += new System.EventHandler(this.btnViewAdmin_Click);
            // 
            // btnSearchTenant
            // 
            this.btnSearchTenant.Location = new System.Drawing.Point(477, 118);
            this.btnSearchTenant.Name = "btnSearchTenant";
            this.btnSearchTenant.Size = new System.Drawing.Size(114, 42);
            this.btnSearchTenant.TabIndex = 8;
            this.btnSearchTenant.Text = "Search";
            this.btnSearchTenant.UseVisualStyleBackColor = true;
            // 
            // btnSearchAgent
            // 
            this.btnSearchAgent.Location = new System.Drawing.Point(477, 76);
            this.btnSearchAgent.Name = "btnSearchAgent";
            this.btnSearchAgent.Size = new System.Drawing.Size(114, 42);
            this.btnSearchAgent.TabIndex = 7;
            this.btnSearchAgent.Text = "Search";
            this.btnSearchAgent.UseVisualStyleBackColor = true;
            // 
            // btnSearchAdmin
            // 
            this.btnSearchAdmin.Location = new System.Drawing.Point(477, 36);
            this.btnSearchAdmin.Name = "btnSearchAdmin";
            this.btnSearchAdmin.Size = new System.Drawing.Size(114, 42);
            this.btnSearchAdmin.TabIndex = 6;
            this.btnSearchAdmin.Text = "Search";
            this.btnSearchAdmin.UseVisualStyleBackColor = true;
            this.btnSearchAdmin.Click += new System.EventHandler(this.btnSearchAdmin_Click);
            // 
            // txtTenant
            // 
            this.txtTenant.Location = new System.Drawing.Point(234, 123);
            this.txtTenant.Name = "txtTenant";
            this.txtTenant.Size = new System.Drawing.Size(205, 26);
            this.txtTenant.TabIndex = 5;
            // 
            // txtAgent
            // 
            this.txtAgent.Location = new System.Drawing.Point(234, 81);
            this.txtAgent.Name = "txtAgent";
            this.txtAgent.Size = new System.Drawing.Size(205, 26);
            this.txtAgent.TabIndex = 4;
            // 
            // txtAdmin
            // 
            this.txtAdmin.Location = new System.Drawing.Point(234, 38);
            this.txtAdmin.Name = "txtAdmin";
            this.txtAdmin.Size = new System.Drawing.Size(205, 26);
            this.txtAdmin.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tenant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin:";
            // 
            // ucUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucUser";
            this.Size = new System.Drawing.Size(793, 404);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUserReport;
        private System.Windows.Forms.Button btnViewTenant;
        private System.Windows.Forms.Button btnViewAgent;
        private System.Windows.Forms.Button btnViewAdmin;
        private System.Windows.Forms.Button btnSearchTenant;
        private System.Windows.Forms.Button btnSearchAgent;
        private System.Windows.Forms.Button btnSearchAdmin;
        private System.Windows.Forms.TextBox txtTenant;
        private System.Windows.Forms.TextBox txtAgent;
        private System.Windows.Forms.TextBox txtAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
