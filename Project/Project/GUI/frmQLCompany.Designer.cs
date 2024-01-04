namespace Project.GUI
{
    partial class frmQLCompany
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLCompany));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_HostLine = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.data_Company = new System.Windows.Forms.DataGridView();
            this.tree_Vecancies = new System.Windows.Forms.TreeView();
            this.btn_AddCompany = new System.Windows.Forms.Button();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.panel_Vecancies = new System.Windows.Forms.Panel();
            this.btn_AddVecancies = new System.Windows.Forms.Button();
            this.btn_DeleteVecancies = new System.Windows.Forms.Button();
            this.btn_SaveCompany = new System.Windows.Forms.Button();
            this.btn_DeleteCompany = new System.Windows.Forms.Button();
            this.btn_Loading = new System.Windows.Forms.Button();
            this.panel_Data = new System.Windows.Forms.Panel();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.cbox_Search = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_Company)).BeginInit();
            this.panel_Info.SuspendLayout();
            this.panel_Vecancies.SuspendLayout();
            this.panel_Data.SuspendLayout();
            this.panel_Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Company";
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
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Id.Location = new System.Drawing.Point(80, 8);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(299, 25);
            this.txt_Id.TabIndex = 2;
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Name.Location = new System.Drawing.Point(80, 41);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(299, 25);
            this.txt_Name.TabIndex = 2;
            // 
            // txt_Address
            // 
            this.txt_Address.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Address.Location = new System.Drawing.Point(80, 76);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(299, 25);
            this.txt_Address.TabIndex = 2;
            // 
            // txt_HostLine
            // 
            this.txt_HostLine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_HostLine.Location = new System.Drawing.Point(80, 111);
            this.txt_HostLine.Name = "txt_HostLine";
            this.txt_HostLine.Size = new System.Drawing.Size(299, 25);
            this.txt_HostLine.TabIndex = 2;
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(80, 145);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(299, 25);
            this.txt_Email.TabIndex = 2;
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
            // tree_Vecancies
            // 
            this.tree_Vecancies.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tree_Vecancies.Location = new System.Drawing.Point(8, 5);
            this.tree_Vecancies.Name = "tree_Vecancies";
            this.tree_Vecancies.Size = new System.Drawing.Size(250, 165);
            this.tree_Vecancies.TabIndex = 4;
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
            // panel_Info
            // 
            this.panel_Info.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Info.Controls.Add(this.txt_Email);
            this.panel_Info.Controls.Add(this.label2);
            this.panel_Info.Controls.Add(this.txt_HostLine);
            this.panel_Info.Controls.Add(this.label3);
            this.panel_Info.Controls.Add(this.txt_Address);
            this.panel_Info.Controls.Add(this.label4);
            this.panel_Info.Controls.Add(this.txt_Name);
            this.panel_Info.Controls.Add(this.label5);
            this.panel_Info.Controls.Add(this.txt_Id);
            this.panel_Info.Controls.Add(this.label6);
            this.panel_Info.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel_Info.Location = new System.Drawing.Point(12, 65);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(386, 177);
            this.panel_Info.TabIndex = 6;
            // 
            // panel_Vecancies
            // 
            this.panel_Vecancies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Vecancies.Controls.Add(this.btn_AddVecancies);
            this.panel_Vecancies.Controls.Add(this.tree_Vecancies);
            this.panel_Vecancies.Controls.Add(this.btn_DeleteVecancies);
            this.panel_Vecancies.Location = new System.Drawing.Point(404, 65);
            this.panel_Vecancies.Name = "panel_Vecancies";
            this.panel_Vecancies.Size = new System.Drawing.Size(384, 177);
            this.panel_Vecancies.TabIndex = 6;
            // 
            // btn_AddVecancies
            // 
            this.btn_AddVecancies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AddVecancies.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddVecancies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddVecancies.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_AddVecancies.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddVecancies.Image")));
            this.btn_AddVecancies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddVecancies.Location = new System.Drawing.Point(264, 6);
            this.btn_AddVecancies.Name = "btn_AddVecancies";
            this.btn_AddVecancies.Padding = new System.Windows.Forms.Padding(18, 0, 18, 0);
            this.btn_AddVecancies.Size = new System.Drawing.Size(113, 34);
            this.btn_AddVecancies.TabIndex = 5;
            this.btn_AddVecancies.Text = "Add";
            this.btn_AddVecancies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddVecancies.UseVisualStyleBackColor = false;
            // 
            // btn_DeleteVecancies
            // 
            this.btn_DeleteVecancies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_DeleteVecancies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteVecancies.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_DeleteVecancies.Image = ((System.Drawing.Image)(resources.GetObject("btn_DeleteVecancies.Image")));
            this.btn_DeleteVecancies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DeleteVecancies.Location = new System.Drawing.Point(264, 46);
            this.btn_DeleteVecancies.Name = "btn_DeleteVecancies";
            this.btn_DeleteVecancies.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.btn_DeleteVecancies.Size = new System.Drawing.Size(113, 34);
            this.btn_DeleteVecancies.TabIndex = 5;
            this.btn_DeleteVecancies.Text = "Delete";
            this.btn_DeleteVecancies.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DeleteVecancies.UseVisualStyleBackColor = true;
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
            // panel_Data
            // 
            this.panel_Data.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Data.Controls.Add(this.btn_AddCompany);
            this.panel_Data.Controls.Add(this.data_Company);
            this.panel_Data.Controls.Add(this.btn_Undo);
            this.panel_Data.Controls.Add(this.btn_Loading);
            this.panel_Data.Controls.Add(this.btn_SaveCompany);
            this.panel_Data.Controls.Add(this.btn_DeleteCompany);
            this.panel_Data.Location = new System.Drawing.Point(13, 303);
            this.panel_Data.Name = "panel_Data";
            this.panel_Data.Size = new System.Drawing.Size(776, 232);
            this.panel_Data.TabIndex = 6;
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
            // panel_Search
            // 
            this.panel_Search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Search.Controls.Add(this.btn_Search);
            this.panel_Search.Controls.Add(this.cbox_Search);
            this.panel_Search.Controls.Add(this.txt_Search);
            this.panel_Search.Controls.Add(this.label8);
            this.panel_Search.Location = new System.Drawing.Point(13, 248);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(774, 49);
            this.panel_Search.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(357, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tìm kiếm :";
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Search.Location = new System.Drawing.Point(437, 12);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(121, 25);
            this.txt_Search.TabIndex = 1;
            // 
            // cbox_Search
            // 
            this.cbox_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbox_Search.FormattingEnabled = true;
            this.cbox_Search.Items.AddRange(new object[] {
            "Name",
            "Address",
            "Email"});
            this.cbox_Search.Location = new System.Drawing.Point(564, 12);
            this.cbox_Search.Name = "cbox_Search";
            this.cbox_Search.Size = new System.Drawing.Size(121, 25);
            this.cbox_Search.TabIndex = 2;
            this.cbox_Search.Text = "Id";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Search.Location = new System.Drawing.Point(691, 7);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 33);
            this.btn_Search.TabIndex = 3;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // frmQLCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.panel_Vecancies);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_Data);
            this.Name = "frmQLCompany";
            this.Text = "frmQLCompany";
            this.Load += new System.EventHandler(this.frmQLCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Company)).EndInit();
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.panel_Vecancies.ResumeLayout(false);
            this.panel_Data.ResumeLayout(false);
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_HostLine;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.DataGridView data_Company;
        private System.Windows.Forms.TreeView tree_Vecancies;
        private System.Windows.Forms.Button btn_AddCompany;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Panel panel_Vecancies;
        private System.Windows.Forms.Button btn_AddVecancies;
        private System.Windows.Forms.Button btn_DeleteVecancies;
        private System.Windows.Forms.Button btn_SaveCompany;
        private System.Windows.Forms.Button btn_DeleteCompany;
        private System.Windows.Forms.Button btn_Loading;
        private System.Windows.Forms.Panel panel_Data;
        private System.Windows.Forms.Button btn_Undo;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.ComboBox cbox_Search;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label label8;
    }
}