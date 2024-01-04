using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Project.DAO;
using System.Security.Principal;
using System.Xml.Linq;

namespace Project.GUI
{
    public partial class frmAccount : Form
    {
        Connecting connect = new Connecting();
        MongoClient client;
        IMongoDatabase database;
        IMongoCollection<BsonDocument> admin;
        DataTable data;
        public frmAccount()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("Recruitment");
            admin = database.GetCollection<BsonDocument>("Admin");
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            data = connect.LoadAccount();
            while (data_Account.Columns.Count > 0)
            {
                data_Account.Columns.RemoveAt(0);
            }
            data_Account.DataSource = data;
        }

        private void data_Account_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow Rows= data_Account.Rows[e.RowIndex];

                if (Rows.Cells.Count >= 4)
                {
                    txt_Id.Text = Rows.Cells[0].Value.ToString();
                    txt_Name.Text = Rows.Cells[1].Value.ToString();
                    txt_NameAccount.Text = Rows.Cells[2].Value.ToString();
                    txt_PassAccount.Text = Rows.Cells[3].Value.ToString();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var account = new Account
            {
                name = txt_NameAccount.Text,
                pass = txt_PassAccount.Text
            };
            string connectionString = "mongodb://localhost:27017";
            client = new MongoClient(connectionString);
            database = client.GetDatabase("Recruitment");
            var adminCollection = database.GetCollection<Account>("Admin");
            adminCollection.InsertOne(account);
            connect.LoadAccount();
        }

        private void btn_Loading_Click(object sender, EventArgs e)
        {
            connect.LoadAccount();
        }
    }
}
