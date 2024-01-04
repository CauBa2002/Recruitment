using System;
using Project.DAO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MongoDB.Driver;
using MongoDB.Bson;

namespace Project.GUI
{
    public partial class frmLogin : Form
    {
        Connecting connect = new Connecting();
        public frmLogin()
        {
            InitializeComponent();
            //connect.connectDB();
            txt_Name.Focus();
            this.Name = txt_Name.Text;
        }

        private void url_Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister form = new frmRegister();
            form.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string nameAccount = txt_Name.Text;
            Program.check = checkAccount(nameAccount);
            if (checkAccount(nameAccount) == 1 || checkAccount(nameAccount) == -1 || checkAccount(nameAccount) == 0)
            {
                this.Hide();
                frmHome home = new frmHome();
                home.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng Nhập không thành công!");
                txt_Name.Clear();
                txt_Pass.Clear();
            }
        }

        public int checkAccount(string name)
        {
            if (name == "company")
                return 1;
            else if (name == "user")
                return -1;
            else if (name == "admin")
                return 0;
            return -2;
        }
    }
}
