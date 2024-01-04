namespace Project.GUI
{
    partial class frmHome
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
            this.panel_Navbar = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.btn_Vecancies = new System.Windows.Forms.Button();
            this.btn_Infomation = new System.Windows.Forms.Button();
            this.btn_Recruitment = new System.Windows.Forms.Button();
            this.btn_QLStaff = new System.Windows.Forms.Button();
            this.btn_QLCompany = new System.Windows.Forms.Button();
            this.btn_QLAccount = new System.Windows.Forms.Button();
            this.panel_Change = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Navbar
            // 
            this.panel_Navbar.BackColor = System.Drawing.Color.Cyan;
            this.panel_Navbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Navbar.Controls.Add(this.btn_Logout);
            this.panel_Navbar.Controls.Add(this.btn_Vecancies);
            this.panel_Navbar.Controls.Add(this.btn_Infomation);
            this.panel_Navbar.Controls.Add(this.btn_Recruitment);
            this.panel_Navbar.Controls.Add(this.btn_QLStaff);
            this.panel_Navbar.Controls.Add(this.btn_QLCompany);
            this.panel_Navbar.Controls.Add(this.btn_QLAccount);
            this.panel_Navbar.Location = new System.Drawing.Point(6, 9);
            this.panel_Navbar.Name = "panel_Navbar";
            this.panel_Navbar.Size = new System.Drawing.Size(219, 577);
            this.panel_Navbar.TabIndex = 0;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.White;
            this.btn_Logout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Logout.Location = new System.Drawing.Point(3, 399);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(213, 60);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // btn_Vecancies
            // 
            this.btn_Vecancies.BackColor = System.Drawing.Color.White;
            this.btn_Vecancies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Vecancies.Location = new System.Drawing.Point(3, 333);
            this.btn_Vecancies.Name = "btn_Vecancies";
            this.btn_Vecancies.Size = new System.Drawing.Size(213, 60);
            this.btn_Vecancies.TabIndex = 0;
            this.btn_Vecancies.Text = "Vecancies";
            this.btn_Vecancies.UseVisualStyleBackColor = false;
            this.btn_Vecancies.Click += new System.EventHandler(this.btn_Vecancies_Click);
            // 
            // btn_Infomation
            // 
            this.btn_Infomation.BackColor = System.Drawing.Color.White;
            this.btn_Infomation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Infomation.Location = new System.Drawing.Point(3, 201);
            this.btn_Infomation.Name = "btn_Infomation";
            this.btn_Infomation.Size = new System.Drawing.Size(213, 60);
            this.btn_Infomation.TabIndex = 0;
            this.btn_Infomation.Text = "Infomation";
            this.btn_Infomation.UseVisualStyleBackColor = false;
            this.btn_Infomation.Click += new System.EventHandler(this.btn_Infomation_Click);
            // 
            // btn_Recruitment
            // 
            this.btn_Recruitment.BackColor = System.Drawing.Color.White;
            this.btn_Recruitment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Recruitment.Location = new System.Drawing.Point(3, 267);
            this.btn_Recruitment.Name = "btn_Recruitment";
            this.btn_Recruitment.Size = new System.Drawing.Size(213, 60);
            this.btn_Recruitment.TabIndex = 0;
            this.btn_Recruitment.Text = "Recruitment";
            this.btn_Recruitment.UseVisualStyleBackColor = false;
            this.btn_Recruitment.Click += new System.EventHandler(this.btn_Recruitment_Click);
            // 
            // btn_QLStaff
            // 
            this.btn_QLStaff.BackColor = System.Drawing.Color.White;
            this.btn_QLStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QLStaff.Location = new System.Drawing.Point(3, 135);
            this.btn_QLStaff.Name = "btn_QLStaff";
            this.btn_QLStaff.Size = new System.Drawing.Size(213, 60);
            this.btn_QLStaff.TabIndex = 0;
            this.btn_QLStaff.Text = "Manage Staff";
            this.btn_QLStaff.UseVisualStyleBackColor = false;
            this.btn_QLStaff.Click += new System.EventHandler(this.btn_QLStaff_Click);
            // 
            // btn_QLCompany
            // 
            this.btn_QLCompany.BackColor = System.Drawing.Color.White;
            this.btn_QLCompany.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QLCompany.Location = new System.Drawing.Point(3, 69);
            this.btn_QLCompany.Name = "btn_QLCompany";
            this.btn_QLCompany.Size = new System.Drawing.Size(213, 60);
            this.btn_QLCompany.TabIndex = 0;
            this.btn_QLCompany.Text = "Manage Company";
            this.btn_QLCompany.UseVisualStyleBackColor = false;
            this.btn_QLCompany.Click += new System.EventHandler(this.btn_QLCompany_Click);
            // 
            // btn_QLAccount
            // 
            this.btn_QLAccount.BackColor = System.Drawing.Color.White;
            this.btn_QLAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_QLAccount.Location = new System.Drawing.Point(3, 3);
            this.btn_QLAccount.Name = "btn_QLAccount";
            this.btn_QLAccount.Size = new System.Drawing.Size(213, 60);
            this.btn_QLAccount.TabIndex = 0;
            this.btn_QLAccount.Text = "Manage Account";
            this.btn_QLAccount.UseVisualStyleBackColor = false;
            this.btn_QLAccount.Click += new System.EventHandler(this.btn_QLAccount_Click);
            // 
            // panel_Change
            // 
            this.panel_Change.Location = new System.Drawing.Point(231, 11);
            this.panel_Change.Name = "panel_Change";
            this.panel_Change.Size = new System.Drawing.Size(979, 575);
            this.panel_Change.TabIndex = 1;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 588);
            this.Controls.Add(this.panel_Change);
            this.Controls.Add(this.panel_Navbar);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel_Navbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Navbar;
        private System.Windows.Forms.FlowLayoutPanel panel_Change;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Vecancies;
        private System.Windows.Forms.Button btn_Recruitment;
        private System.Windows.Forms.Button btn_QLStaff;
        private System.Windows.Forms.Button btn_QLCompany;
        private System.Windows.Forms.Button btn_QLAccount;
        private System.Windows.Forms.Button btn_Infomation;
    }
}