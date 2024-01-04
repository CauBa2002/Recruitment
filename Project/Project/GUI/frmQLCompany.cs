using System;
using Project.DAO;
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
    public partial class frmQLCompany : Form
    {
        Connecting connect = new Connecting();
        DataTable data;
        DateTime now = DateTime.Now;
        public frmQLCompany()
        {
            InitializeComponent();
            foreach(DataGridViewRow row in data_Company.Rows)
            {
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
        }
        
        private void frmQLCompany_Load(object sender, EventArgs e)
        {
            data = connect.LoadDataCompany();
            while(data_Company.Columns.Count > 0)
            {
                data_Company.Columns.RemoveAt(0);
            }
            data_Company.DataSource = data;
        }
    }
}
