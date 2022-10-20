
namespace Project_2
{
    partial class ucViewProperty
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
            this.dgvProperty = new System.Windows.Forms.DataGridView();
            this.btnListPropertyType = new System.Windows.Forms.Button();
            this.btnSearchProperty = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvProperty);
            this.groupBox1.Controls.Add(this.btnListPropertyType);
            this.groupBox1.Controls.Add(this.btnSearchProperty);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Report";
            // 
            // dgvProperty
            // 
            this.dgvProperty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperty.Location = new System.Drawing.Point(17, 152);
            this.dgvProperty.Name = "dgvProperty";
            this.dgvProperty.Size = new System.Drawing.Size(694, 150);
            this.dgvProperty.TabIndex = 12;
            // 
            // btnListPropertyType
            // 
            this.btnListPropertyType.Location = new System.Drawing.Point(399, 76);
            this.btnListPropertyType.Name = "btnListPropertyType";
            this.btnListPropertyType.Size = new System.Drawing.Size(312, 42);
            this.btnListPropertyType.TabIndex = 7;
            this.btnListPropertyType.Text = "List Property Types";
            this.btnListPropertyType.UseVisualStyleBackColor = true;
            this.btnListPropertyType.Click += new System.EventHandler(this.btnSearchPropertyType_Click);
            // 
            // btnSearchProperty
            // 
            this.btnSearchProperty.Location = new System.Drawing.Point(17, 76);
            this.btnSearchProperty.Name = "btnSearchProperty";
            this.btnSearchProperty.Size = new System.Drawing.Size(312, 42);
            this.btnSearchProperty.TabIndex = 6;
            this.btnSearchProperty.Text = "List Properties";
            this.btnSearchProperty.UseVisualStyleBackColor = true;
            this.btnSearchProperty.Click += new System.EventHandler(this.btnSearchAdmin_Click);
            // 
            // ucProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ucProperty";
            this.Size = new System.Drawing.Size(783, 376);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvProperty;
        private System.Windows.Forms.Button btnListPropertyType;
        private System.Windows.Forms.Button btnSearchProperty;
    }
}
