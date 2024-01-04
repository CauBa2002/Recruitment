using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.GUI
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void url_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin form = new frmLogin();
            form.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome form = new frmHome();
            form.ShowDialog();
        }
    }
}
