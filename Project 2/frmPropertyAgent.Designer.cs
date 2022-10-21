namespace Project_2
{
    partial class frmPropertyAgent
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
            this.txtPropertyAgentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtaDate = new System.Windows.Forms.DateTimePicker();
            this.dgvPropertyAgent = new System.Windows.Forms.DataGridView();
            this.btnBackTo = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbAgent = new System.Windows.Forms.ComboBox();
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errPropertyAgent = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPropertyAgent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPropertyAgentID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtaDate);
            this.groupBox1.Controls.Add(this.dgvPropertyAgent);
            this.groupBox1.Controls.Add(this.btnBackTo);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnList);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbAgent);
            this.groupBox1.Controls.Add(this.cmbProperty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property Agent Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPropertyAgentID
            // 
            this.txtPropertyAgentID.Location = new System.Drawing.Point(205, 30);
            this.txtPropertyAgentID.Name = "txtPropertyAgentID";
            this.txtPropertyAgentID.Size = new System.Drawing.Size(199, 26);
            this.txtPropertyAgentID.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "PropertyAgentID:";
            // 
            // dtaDate
            // 
            this.dtaDate.Location = new System.Drawing.Point(205, 151);
            this.dtaDate.Name = "dtaDate";
            this.dtaDate.Size = new System.Drawing.Size(286, 26);
            this.dtaDate.TabIndex = 11;
            // 
            // dgvPropertyAgent
            // 
            this.dgvPropertyAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPropertyAgent.Location = new System.Drawing.Point(26, 231);
            this.dgvPropertyAgent.Name = "dgvPropertyAgent";
            this.dgvPropertyAgent.Size = new System.Drawing.Size(701, 210);
            this.dgvPropertyAgent.TabIndex = 10;
            this.dgvPropertyAgent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPropertyAgent_CellClick);
            // 
            // btnBackTo
            // 
            this.btnBackTo.Location = new System.Drawing.Point(470, 189);
            this.btnBackTo.Name = "btnBackTo";
            this.btnBackTo.Size = new System.Drawing.Size(120, 36);
            this.btnBackTo.TabIndex = 9;
            this.btnBackTo.Text = "Back";
            this.btnBackTo.UseVisualStyleBackColor = true;
            this.btnBackTo.Click += new System.EventHandler(this.btnBackTo_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(328, 189);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 36);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(181, 189);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(120, 36);
            this.btnList.TabIndex = 7;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 189);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 36);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbAgent
            // 
            this.cmbAgent.FormattingEnabled = true;
            this.cmbAgent.Location = new System.Drawing.Point(205, 117);
            this.cmbAgent.Name = "cmbAgent";
            this.cmbAgent.Size = new System.Drawing.Size(286, 28);
            this.cmbAgent.TabIndex = 5;
            // 
            // cmbProperty
            // 
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Location = new System.Drawing.Point(205, 72);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(286, 28);
            this.cmbProperty.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agent:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property:";
            // 
            // errPropertyAgent
            // 
            this.errPropertyAgent.ContainerControl = this;
            // 
            // frmPropertyAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPropertyAgent";
            this.Text = "frmPropertyAgent";
            this.Load += new System.EventHandler(this.frmPropertyAgent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPropertyAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPropertyAgent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPropertyAgent;
        private System.Windows.Forms.Button btnBackTo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbAgent;
        private System.Windows.Forms.DateTimePicker dtaDate;
        private System.Windows.Forms.ErrorProvider errPropertyAgent;
        private System.Windows.Forms.TextBox txtPropertyAgentID;
        private System.Windows.Forms.Label label4;
    }
}