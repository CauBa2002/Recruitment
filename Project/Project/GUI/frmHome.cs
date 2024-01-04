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
    public partial class frmHome : Form
    {
        frmLogin login = new frmLogin();
        frmAccount account = new frmAccount();
        frmQLCompany company = new frmQLCompany();
        frmQLStaff staff = new frmQLStaff();
        frmRecruitment recruitment = new frmRecruitment();
        frmVecancies vecancies = new frmVecancies();
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            int result = Program.check;
            if(result == 1)
            {
                btn_QLAccount.Visible = false;
                btn_QLStaff.Visible = false;
                btn_QLCompany.Visible = false;
                btn_Recruitment.Visible = false;

                btn_Infomation.Visible = true;
                btn_Infomation.Top = 3;
                btn_Vecancies.Visible = true;
                btn_Vecancies.Top = 69;
                btn_Logout.Visible = true;
                btn_Logout.Top = 135;

                panel_Navbar.Controls.SetChildIndex(btn_Infomation, 0);
                panel_Navbar.Controls.SetChildIndex(btn_Vecancies, 1);
                panel_Navbar.Controls.SetChildIndex(btn_Logout, 2);
            } else if (result == -1)
            {
                btn_QLAccount.Visible = false;
                btn_QLStaff.Visible = false;
                btn_QLCompany.Visible = false;
                btn_Vecancies.Visible = false;

                btn_Infomation.Visible = true;
                btn_Infomation.Top = 3;
                btn_Recruitment.Visible = true;
                btn_Recruitment.Top = 69;
                btn_Logout.Visible = true;
                btn_Logout.Top = 135;

                panel_Navbar.Controls.SetChildIndex(btn_Infomation, 0);
                panel_Navbar.Controls.SetChildIndex(btn_Recruitment, 1);
                panel_Navbar.Controls.SetChildIndex(btn_Logout, 2);
            }
        }

        private void changBackgroundClick(Button _click)
        {
            Button[] _btn = new Button[] { btn_QLAccount, btn_Infomation, btn_Logout, btn_Recruitment, btn_Vecancies, btn_QLStaff, btn_Infomation };
            foreach (Button i in _btn)
            {
                i.BackColor = Color.FromArgb(60, 112, 253);
            }
            _click.BackColor = Color.FromArgb(42, 98, 250);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

        private void btn_QLAccount_Click(object sender, EventArgs e)
        {
            changBackgroundClick(btn_QLAccount);
            account.TopLevel = false;
            panel_Change.Controls.Clear();
            panel_Change.Controls.Add(account);
            account.Show();
        }

        private void btn_QLCompany_Click(object sender, EventArgs e)
        {
            changBackgroundClick(btn_QLCompany);
            company.TopLevel = false;
            panel_Change.Controls.Clear();
            panel_Change.Controls.Add(company);
            company.Show();
        }

        private void btn_QLStaff_Click(object sender, EventArgs e)
        {
            changBackgroundClick(btn_QLStaff);
            staff.TopLevel = false;
            panel_Change.Controls.Clear();
            panel_Change.Controls.Add(staff);
            staff.Show();
        }

        private void btn_Infomation_Click(object sender, EventArgs e)
        {

        }

        private void btn_Recruitment_Click(object sender, EventArgs e)
        {
            changBackgroundClick(btn_Recruitment);
            recruitment.TopLevel = false;
            panel_Change.Controls.Clear();
            panel_Change.Controls.Add(recruitment);
            recruitment.Show();
        }

        private void btn_Vecancies_Click(object sender, EventArgs e)
        {
            changBackgroundClick(btn_Vecancies);
            vecancies.TopLevel = false;
            panel_Change.Controls.Clear();
            panel_Change.Controls.Add(vecancies);
            vecancies.Show();
        }
    }
}
