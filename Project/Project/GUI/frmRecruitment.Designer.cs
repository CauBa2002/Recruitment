namespace Project.GUI
{
    partial class frmRecruitment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecruitment));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.txt_DayofBirth = new System.Windows.Forms.DateTimePicker();
            this.txt_Age = new System.Windows.Forms.TextBox();
            this.txt_HostLine = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbox_Id_Cty = new System.Windows.Forms.ComboBox();
            this.cbox_Role = new System.Windows.Forms.ComboBox();
            this.cbox_Level = new System.Windows.Forms.ComboBox();
            this.panel_Data = new System.Windows.Forms.Panel();
            this.btn_AddStaff = new System.Windows.Forms.Button();
            this.data_Company = new System.Windows.Forms.DataGridView();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Loading = new System.Windows.Forms.Button();
            this.btn_SaveStaff = new System.Windows.Forms.Button();
            this.btn_DeleteStaff = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(362, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Recruitment";
            // 
            // panel_Info
            // 
            this.panel_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Info.Controls.Add(this.cbox_Level);
            this.panel_Info.Controls.Add(this.cbox_Role);
            this.panel_Info.Controls.Add(this.cbox_Id_Cty);
            this.panel_Info.Controls.Add(this.txt_DayofBirth);
            this.panel_Info.Controls.Add(this.txt_Age);
            this.panel_Info.Controls.Add(this.txt_HostLine);
            this.panel_Info.Controls.Add(this.label7);
            this.panel_Info.Controls.Add(this.label5);
            this.panel_Info.Controls.Add(this.txt_Email);
            this.panel_Info.Controls.Add(this.label6);
            this.panel_Info.Controls.Add(this.label11);
            this.panel_Info.Controls.Add(this.label9);
            this.panel_Info.Controls.Add(this.label8);
            this.panel_Info.Controls.Add(this.label2);
            this.panel_Info.Controls.Add(this.label10);
            this.panel_Info.Controls.Add(this.label3);
            this.panel_Info.Controls.Add(this.txt_Address);
            this.panel_Info.Controls.Add(this.label4);
            this.panel_Info.Controls.Add(this.txt_Name);
            this.panel_Info.Controls.Add(this.txt_Id);
            this.panel_Info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_Info.Location = new System.Drawing.Point(12, 69);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(776, 177);
            this.panel_Info.TabIndex = 12;
            // 
            // txt_DayofBirth
            // 
            this.txt_DayofBirth.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DayofBirth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DayofBirth.Location = new System.Drawing.Point(230, 8);
            this.txt_DayofBirth.Name = "txt_DayofBirth";
            this.txt_DayofBirth.Size = new System.Drawing.Size(149, 25);
            this.txt_DayofBirth.TabIndex = 5;
            // 
            // txt_Age
            // 
            this.txt_Age.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Age.Location = new System.Drawing.Point(321, 145);
            this.txt_Age.Name = "txt_Age";
            this.txt_Age.Size = new System.Drawing.Size(58, 25);
            this.txt_Age.TabIndex = 2;
            // 
            // txt_HostLine
            // 
            this.txt_HostLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HostLine.Location = new System.Drawing.Point(118, 145);
            this.txt_HostLine.Name = "txt_HostLine";
            this.txt_HostLine.Size = new System.Drawing.Size(151, 25);
            this.txt_HostLine.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(275, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Age :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(3, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Number Phone :";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(80, 111);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(299, 25);
            this.txt_Email.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(3, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email :";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(133, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Day of Birth :";
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
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id.Location = new System.Drawing.Point(80, 8);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(47, 25);
            this.txt_Id.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(396, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Id_Cty :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(396, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Role :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.Location = new System.Drawing.Point(396, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 1;
            this.label11.Text = "Level :";
            // 
            // cbox_Id_Cty
            // 
            this.cbox_Id_Cty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbox_Id_Cty.FormattingEnabled = true;
            this.cbox_Id_Cty.Location = new System.Drawing.Point(455, 8);
            this.cbox_Id_Cty.Name = "cbox_Id_Cty";
            this.cbox_Id_Cty.Size = new System.Drawing.Size(183, 25);
            this.cbox_Id_Cty.TabIndex = 6;
            // 
            // cbox_Role
            // 
            this.cbox_Role.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbox_Role.FormattingEnabled = true;
            this.cbox_Role.Location = new System.Drawing.Point(455, 41);
            this.cbox_Role.Name = "cbox_Role";
            this.cbox_Role.Size = new System.Drawing.Size(183, 25);
            this.cbox_Role.TabIndex = 6;
            // 
            // cbox_Level
            // 
            this.cbox_Level.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbox_Level.FormattingEnabled = true;
            this.cbox_Level.Location = new System.Drawing.Point(455, 76);
            this.cbox_Level.Name = "cbox_Level";
            this.cbox_Level.Size = new System.Drawing.Size(183, 25);
            this.cbox_Level.TabIndex = 6;
            // 
            // panel_Data
            // 
            this.panel_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Data.Controls.Add(this.btn_AddStaff);
            this.panel_Data.Controls.Add(this.data_Company);
            this.panel_Data.Controls.Add(this.btn_Undo);
            this.panel_Data.Controls.Add(this.btn_Loading);
            this.panel_Data.Controls.Add(this.btn_SaveStaff);
            this.panel_Data.Controls.Add(this.btn_DeleteStaff);
            this.panel_Data.Location = new System.Drawing.Point(12, 252);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(776, 232);
            this.panel_Data.TabIndex = 13;
            // 
            // btn_AddStaff
            // 
            this.btn_AddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddStaff.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddStaff.Image")));
            this.btn_AddStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddStaff.Location = new System.Drawing.Point(653, 7);
            this.btn_AddStaff.Name = "btn_AddStaff";
            this.btn_AddStaff.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btn_AddStaff.Size = new System.Drawing.Size(113, 34);
            this.btn_AddStaff.TabIndex = 5;
            this.btn_AddStaff.Text = "Add";
            this.btn_AddStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddStaff.UseVisualStyleBackColor = true;
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
            this.data_Company.Location = new System.Drawing.Point(3, 7);
            this.data_Company.Name = "data_Company";
            this.data_Company.Size = new System.Drawing.Size(643, 218);
            this.data_Company.TabIndex = 8;
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
            // btn_SaveStaff
            // 
            this.btn_SaveStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_SaveStaff.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveStaff.Image")));
            this.btn_SaveStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SaveStaff.Location = new System.Drawing.Point(653, 53);
            this.btn_SaveStaff.Name = "btn_SaveStaff";
            this.btn_SaveStaff.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn_SaveStaff.Size = new System.Drawing.Size(113, 34);
            this.btn_SaveStaff.TabIndex = 5;
            this.btn_SaveStaff.Text = "Save";
            this.btn_SaveStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SaveStaff.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteStaff
            // 
            this.btn_DeleteStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DeleteStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteStaff.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteStaff.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteStaff.Image")));
            this.btn_DeleteStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteStaff.Location = new System.Drawing.Point(653, 98);
            this.btn_DeleteStaff.Name = "btn_DeleteStaff";
            this.btn_DeleteStaff.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btn_DeleteStaff.Size = new System.Drawing.Size(113, 34);
            this.btn_DeleteStaff.TabIndex = 5;
            this.btn_DeleteStaff.Text = "Delete";
            this.btn_DeleteStaff.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteStaff.UseVisualStyleBackColor = true;
            // 
            // frmRecruitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 494);
            this.Controls.Add(this.panel_Data);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.label1);
            this.Name = "frmRecruitment";
            this.Text = "QLRecruitment";
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
        private System.Windows.Forms.DateTimePicker txt_DayofBirth;
        private System.Windows.Forms.TextBox txt_Age;
        private System.Windows.Forms.TextBox txt_HostLine;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.ComboBox cbox_Level;
        private System.Windows.Forms.ComboBox cbox_Role;
        private System.Windows.Forms.ComboBox cbox_Id_Cty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_Data;
        private System.Windows.Forms.Button btn_AddStaff;
        private System.Windows.Forms.DataGridView data_Company;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Button btn_Loading;
        private System.Windows.Forms.Button btn_SaveStaff;
        private System.Windows.Forms.Button btn_DeleteStaff;
    }
}