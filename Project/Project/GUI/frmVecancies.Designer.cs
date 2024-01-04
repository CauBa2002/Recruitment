namespace Project.GUI
{
    partial class frmVecancies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVecancies));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HostLine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbox_Level = new System.Windows.Forms.ComboBox();
            this.cbox_Role = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Id_User = new System.Windows.Forms.TextBox();
            this.panel_Data = new System.Windows.Forms.Panel();
            this.btn_AddCompany = new System.Windows.Forms.Button();
            this.data_Company = new System.Windows.Forms.DataGridView();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Loading = new System.Windows.Forms.Button();
            this.btn_SaveCompany = new System.Windows.Forms.Button();
            this.btn_DeleteCompany = new System.Windows.Forms.Button();
            this.panel_Info.SuspendLayout();
            this.panel_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Company)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Vecancies";
            // 
            // panel_Info
            // 
            this.panel_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Info.Controls.Add(this.cbox_Level);
            this.panel_Info.Controls.Add(this.txt_Email);
            this.panel_Info.Controls.Add(this.cbox_Role);
            this.panel_Info.Controls.Add(this.label2);
            this.panel_Info.Controls.Add(this.label7);
            this.panel_Info.Controls.Add(this.label11);
            this.panel_Info.Controls.Add(this.txt_Quantity);
            this.panel_Info.Controls.Add(this.txt_HostLine);
            this.panel_Info.Controls.Add(this.label9);
            this.panel_Info.Controls.Add(this.label3);
            this.panel_Info.Controls.Add(this.label8);
            this.panel_Info.Controls.Add(this.txt_Address);
            this.panel_Info.Controls.Add(this.label4);
            this.panel_Info.Controls.Add(this.txt_Id_User);
            this.panel_Info.Controls.Add(this.txt_Name);
            this.panel_Info.Controls.Add(this.label5);
            this.panel_Info.Controls.Add(this.txt_Id);
            this.panel_Info.Controls.Add(this.label6);
            this.panel_Info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_Info.Location = new System.Drawing.Point(12, 69);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(776, 177);
            this.panel_Info.TabIndex = 10;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(80, 145);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(299, 25);
            this.txt_Email.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id :";
            // 
            // txt_HostLine
            // 
            this.txt_HostLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HostLine.Location = new System.Drawing.Point(80, 111);
            this.txt_HostLine.Name = "txt_HostLine";
            this.txt_HostLine.Size = new System.Drawing.Size(299, 25);
            this.txt_HostLine.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(3, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name :";
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Address.Location = new System.Drawing.Point(80, 76);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(299, 25);
            this.txt_Address.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(3, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Address :";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.Location = new System.Drawing.Point(80, 41);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(299, 25);
            this.txt_Name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "HostLine :";
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id.Location = new System.Drawing.Point(80, 8);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(299, 25);
            this.txt_Id.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email :";
            // 
            // cbox_Level
            // 
            this.cbox_Level.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbox_Level.FormattingEnabled = true;
            this.cbox_Level.Location = new System.Drawing.Point(456, 76);
            this.cbox_Level.Name = "cbox_Level";
            this.cbox_Level.Size = new System.Drawing.Size(183, 25);
            this.cbox_Level.TabIndex = 14;
            // 
            // cbox_Role
            // 
            this.cbox_Role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbox_Role.FormattingEnabled = true;
            this.cbox_Role.Location = new System.Drawing.Point(456, 41);
            this.cbox_Role.Name = "cbox_Role";
            this.cbox_Role.Size = new System.Drawing.Size(183, 25);
            this.cbox_Role.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(390, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Level :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(390, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Role :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(390, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Id_User :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(390, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Quantity :";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Quantity.Location = new System.Drawing.Point(466, 111);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(173, 25);
            this.txt_Quantity.TabIndex = 2;
            // 
            // txt_Id_User
            // 
            this.txt_Id_User.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id_User.Location = new System.Drawing.Point(456, 8);
            this.txt_Id_User.Name = "txt_Id_User";
            this.txt_Id_User.Size = new System.Drawing.Size(183, 25);
            this.txt_Id_User.TabIndex = 2;
            // 
            // panel_Data
            // 
            this.panel_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Data.Controls.Add(this.btn_AddCompany);
            this.panel_Data.Controls.Add(this.data_Company);
            this.panel_Data.Controls.Add(this.btn_Undo);
            this.panel_Data.Controls.Add(this.btn_Loading);
            this.panel_Data.Controls.Add(this.btn_SaveCompany);
            this.panel_Data.Controls.Add(this.btn_DeleteCompany);
            this.panel_Data.Location = new System.Drawing.Point(12, 252);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(776, 232);
            this.panel_Data.TabIndex = 11;
            // 
            // btn_AddCompany
            // 
            this.btn_AddCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddCompany.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddCompany.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddCompany.Image")));
            this.btn_AddCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddCompany.Location = new System.Drawing.Point(653, 7);
            this.btn_AddCompany.Name = "btn_AddCompany";
            this.btn_AddCompany.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btn_AddCompany.Size = new System.Drawing.Size(113, 34);
            this.btn_AddCompany.TabIndex = 5;
            this.btn_AddCompany.Text = "Add";
            this.btn_AddCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddCompany.UseVisualStyleBackColor = true;
            // 
            // data_Company
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_Company.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_Company.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Company.Location = new System.Drawing.Point(4, 7);
            this.data_Company.Name = "data_Company";
            this.data_Company.Size = new System.Drawing.Size(643, 218);
            this.data_Company.TabIndex = 3;
            // 
            // btn_Undo
            // 
            this.btn_Undo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Undo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Undo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Undo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Undo.Image")));
            this.btn_Undo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Undo.Location = new System.Drawing.Point(653, 187);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.btn_Undo.Size = new System.Drawing.Size(113, 34);
            this.btn_Undo.TabIndex = 5;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Undo.UseVisualStyleBackColor = true;
            // 
            // btn_Loading
            // 
            this.btn_Loading.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Loading.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Loading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Loading.Image = ((System.Drawing.Image)(resources.GetObject("btn_Loading.Image")));
            this.btn_Loading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Loading.Location = new System.Drawing.Point(653, 143);
            this.btn_Loading.Name = "btn_Loading";
            this.btn_Loading.Size = new System.Drawing.Size(113, 34);
            this.btn_Loading.TabIndex = 5;
            this.btn_Loading.Text = "Loading";
            this.btn_Loading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Loading.UseVisualStyleBackColor = true;
            // 
            // btn_SaveCompany
            // 
            this.btn_SaveCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveCompany.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SaveCompany.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveCompany.Image")));
            this.btn_SaveCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveCompany.Location = new System.Drawing.Point(653, 53);
            this.btn_SaveCompany.Name = "btn_SaveCompany";
            this.btn_SaveCompany.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_SaveCompany.Size = new System.Drawing.Size(113, 34);
            this.btn_SaveCompany.TabIndex = 5;
            this.btn_SaveCompany.Text = "Save";
            this.btn_SaveCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveCompany.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteCompany
            // 
            this.btn_DeleteCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteCompany.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteCompany.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteCompany.Image")));
            this.btn_DeleteCompany.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteCompany.Location = new System.Drawing.Point(653, 98);
            this.btn_DeleteCompany.Name = "btn_DeleteCompany";
            this.btn_DeleteCompany.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btn_DeleteCompany.Size = new System.Drawing.Size(113, 34);
            this.btn_DeleteCompany.TabIndex = 5;
            this.btn_DeleteCompany.Text = "Delete";
            this.btn_DeleteCompany.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteCompany.UseVisualStyleBackColor = true;
            // 
            // frmVecancies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.panel_Data);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.label1);
            this.Name = "frmVecancies";
            this.Text = "QLVecancies";
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.panel_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Company)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HostLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbox_Level;
        private System.Windows.Forms.ComboBox cbox_Role;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Id_User;
        private System.Windows.Forms.Panel panel_Data;
        private System.Windows.Forms.Button btn_AddCompany;
        private System.Windows.Forms.DataGridView data_Company;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Loading;
        private System.Windows.Forms.Button btn_SaveCompany;
        private System.Windows.Forms.Button btn_DeleteCompany;
    }
}