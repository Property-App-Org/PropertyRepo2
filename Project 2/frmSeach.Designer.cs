
namespace Project_2
{
    partial class frmSeach
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgency = new System.Windows.Forms.Button();
            this.btnRental = new System.Windows.Forms.Button();
            this.btnLocation = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ucViewProperty1 = new Project_2.ucViewProperty();
            this.ucViewUser1 = new Project_2.ucViewUser();
            this.ucViewRental1 = new Project_2.ucViewRental();
            this.ucViewLocation1 = new Project_2.ucViewLocation();
            this.ucViewAgencies1 = new Project_2.ucViewAgencies();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.btnAgency);
            this.panel1.Controls.Add(this.btnRental);
            this.panel1.Controls.Add(this.btnLocation);
            this.panel1.Controls.Add(this.btnProperty);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 643);
            this.panel1.TabIndex = 0;
            // 
            // btnAgency
            // 
            this.btnAgency.Location = new System.Drawing.Point(36, 383);
            this.btnAgency.Name = "btnAgency";
            this.btnAgency.Size = new System.Drawing.Size(125, 41);
            this.btnAgency.TabIndex = 4;
            this.btnAgency.Text = "View Agency";
            this.btnAgency.UseVisualStyleBackColor = true;
            this.btnAgency.Click += new System.EventHandler(this.btnAgency_Click);
            // 
            // btnRental
            // 
            this.btnRental.Location = new System.Drawing.Point(36, 320);
            this.btnRental.Name = "btnRental";
            this.btnRental.Size = new System.Drawing.Size(125, 41);
            this.btnRental.TabIndex = 3;
            this.btnRental.Text = "View Rental";
            this.btnRental.UseVisualStyleBackColor = true;
            this.btnRental.Click += new System.EventHandler(this.btnRental_Click);
            // 
            // btnLocation
            // 
            this.btnLocation.Location = new System.Drawing.Point(36, 251);
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.Size = new System.Drawing.Size(125, 41);
            this.btnLocation.TabIndex = 2;
            this.btnLocation.Text = "View Location";
            this.btnLocation.UseVisualStyleBackColor = true;
            this.btnLocation.Click += new System.EventHandler(this.btnLocation_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Location = new System.Drawing.Point(36, 177);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Size = new System.Drawing.Size(125, 41);
            this.btnProperty.TabIndex = 1;
            this.btnProperty.Text = "View property";
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(36, 102);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(125, 41);
            this.btnUser.TabIndex = 0;
            this.btnUser.Text = "View User";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 100);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO MY PROPERTIES";
            // 
            // ucViewProperty1
            // 
            this.ucViewProperty1.Location = new System.Drawing.Point(204, 103);
            this.ucViewProperty1.Name = "ucViewProperty1";
            this.ucViewProperty1.Size = new System.Drawing.Size(783, 376);
            this.ucViewProperty1.TabIndex = 6;
            // 
            // ucViewUser1
            // 
            this.ucViewUser1.Location = new System.Drawing.Point(206, 103);
            this.ucViewUser1.Name = "ucViewUser1";
            this.ucViewUser1.Size = new System.Drawing.Size(793, 404);
            this.ucViewUser1.TabIndex = 5;
            // 
            // ucViewRental1
            // 
            this.ucViewRental1.Location = new System.Drawing.Point(200, 103);
            this.ucViewRental1.Name = "ucViewRental1";
            this.ucViewRental1.Size = new System.Drawing.Size(736, 515);
            this.ucViewRental1.TabIndex = 4;
            // 
            // ucViewLocation1
            // 
            this.ucViewLocation1.Location = new System.Drawing.Point(200, 103);
            this.ucViewLocation1.Name = "ucViewLocation1";
            this.ucViewLocation1.Size = new System.Drawing.Size(783, 507);
            this.ucViewLocation1.TabIndex = 3;
            // 
            // ucViewAgencies1
            // 
            this.ucViewAgencies1.Location = new System.Drawing.Point(206, 103);
            this.ucViewAgencies1.Name = "ucViewAgencies1";
            this.ucViewAgencies1.Size = new System.Drawing.Size(729, 522);
            this.ucViewAgencies1.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(36, 530);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(125, 41);
            this.btnLogIn.TabIndex = 5;
            this.btnLogIn.Text = "Log In.";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // frmSeach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 643);
            this.Controls.Add(this.ucViewProperty1);
            this.Controls.Add(this.ucViewUser1);
            this.Controls.Add(this.ucViewRental1);
            this.Controls.Add(this.ucViewLocation1);
            this.Controls.Add(this.ucViewAgencies1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSeach";
            this.Text = "frmSeach";
            this.Load += new System.EventHandler(this.frmSeach_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgency;
        private System.Windows.Forms.Button btnRental;
        private System.Windows.Forms.Button btnLocation;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private ucViewAgencies ucViewAgencies1;
        private ucViewLocation ucViewLocation1;
        private ucViewRental ucViewRental1;
        private ucViewUser ucViewUser1;
        private ucViewProperty ucViewProperty1;
        private System.Windows.Forms.Button btnLogIn;
    }
}