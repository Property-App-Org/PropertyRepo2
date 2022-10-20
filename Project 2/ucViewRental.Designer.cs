
namespace Project_2
{
    partial class ucViewRental
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
            this.dgvRentalReport = new System.Windows.Forms.DataGridView();
            this.btnSearchPrice = new System.Windows.Forms.Button();
            this.btnViewEndedRentals = new System.Windows.Forms.Button();
            this.btnViewTenant = new System.Windows.Forms.Button();
            this.txtPriceTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewRentedProperties = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewRentedProperties);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvRentalReport);
            this.groupBox1.Controls.Add(this.btnSearchPrice);
            this.groupBox1.Controls.Add(this.btnViewEndedRentals);
            this.groupBox1.Controls.Add(this.btnViewTenant);
            this.groupBox1.Controls.Add(this.txtPriceTo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 509);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Reports";
            // 
            // dgvRentalReport
            // 
            this.dgvRentalReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalReport.Location = new System.Drawing.Point(10, 205);
            this.dgvRentalReport.Name = "dgvRentalReport";
            this.dgvRentalReport.Size = new System.Drawing.Size(701, 298);
            this.dgvRentalReport.TabIndex = 12;
            // 
            // btnSearchPrice
            // 
            this.btnSearchPrice.Location = new System.Drawing.Point(434, 118);
            this.btnSearchPrice.Name = "btnSearchPrice";
            this.btnSearchPrice.Size = new System.Drawing.Size(137, 42);
            this.btnSearchPrice.TabIndex = 8;
            this.btnSearchPrice.Text = "Search By Price";
            this.btnSearchPrice.UseVisualStyleBackColor = true;
            // 
            // btnViewEndedRentals
            // 
            this.btnViewEndedRentals.Location = new System.Drawing.Point(195, 73);
            this.btnViewEndedRentals.Name = "btnViewEndedRentals";
            this.btnViewEndedRentals.Size = new System.Drawing.Size(213, 42);
            this.btnViewEndedRentals.TabIndex = 7;
            this.btnViewEndedRentals.Text = "View";
            this.btnViewEndedRentals.UseVisualStyleBackColor = true;
            // 
            // btnViewTenant
            // 
            this.btnViewTenant.Location = new System.Drawing.Point(195, 25);
            this.btnViewTenant.Name = "btnViewTenant";
            this.btnViewTenant.Size = new System.Drawing.Size(213, 42);
            this.btnViewTenant.TabIndex = 6;
            this.btnViewTenant.Text = "View";
            this.btnViewTenant.UseVisualStyleBackColor = true;
            this.btnViewTenant.Click += new System.EventHandler(this.btnViewTenant_Click);
            // 
            // txtPriceTo
            // 
            this.txtPriceTo.Location = new System.Drawing.Point(195, 126);
            this.txtPriceTo.Name = "txtPriceTo";
            this.txtPriceTo.Size = new System.Drawing.Size(213, 26);
            this.txtPriceTo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ended Rentals:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tenant Rentals:";
            // 
            // btnViewRentedProperties
            // 
            this.btnViewRentedProperties.Location = new System.Drawing.Point(195, 155);
            this.btnViewRentedProperties.Name = "btnViewRentedProperties";
            this.btnViewRentedProperties.Size = new System.Drawing.Size(213, 42);
            this.btnViewRentedProperties.TabIndex = 15;
            this.btnViewRentedProperties.Text = "view";
            this.btnViewRentedProperties.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Rented Properties:";
            // 
            // ucViewRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucViewRental";
            this.Size = new System.Drawing.Size(736, 515);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRentalReport;
        private System.Windows.Forms.Button btnSearchPrice;
        private System.Windows.Forms.Button btnViewEndedRentals;
        private System.Windows.Forms.Button btnViewTenant;
        private System.Windows.Forms.TextBox txtPriceTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewRentedProperties;
        private System.Windows.Forms.Label label5;
    }
}
