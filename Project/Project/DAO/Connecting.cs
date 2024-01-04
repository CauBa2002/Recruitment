using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;


namespace Project.DAO
{
    public class Connecting
    {
        private MongoClient client;
        private IMongoDatabase database;

        //private static IMongoCollection<BsonDocument> coll;
        IMongoCollection<BsonDocument> staff;
        IMongoCollection<BsonDocument> company;
        IMongoCollection<BsonDocument> admin;

        public Connecting()
        {
            if (connectDB() == true)
            {
                staff = database.GetCollection<BsonDocument>("Staff");
                company = database.GetCollection<BsonDocument>("Company");
                admin = database.GetCollection<BsonDocument>("Admin");
            }
        }

        public bool connectDB()
        {
            //Localhost
            string connectionString = "mongodb://localhost:27017";

            try
            {
                // Tạo đối tượng MongoClient từ địa chỉ kết nối
                client = new MongoClient(connectionString);

                // Kết nối đến cơ sở dữ liệu "CSKH"
                database = client.GetDatabase("Recruitment");

                // Hiển thị thông báo kết nối thành công
                Console.WriteLine("Connected successfully!!");

                return true;
                //LoadDataToDataGridView();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có lỗi kết nối
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable LoadDataCompany()
        {
            var results = company.Find(_ => true).ToList();
            DataTable dt_Cp = new DataTable();
            if(results.Count > 0)
            {
                dt_Cp.Columns.Add("ID");
                dt_Cp.Columns.Add("Name");
                dt_Cp.Columns.Add("Address");
                dt_Cp.Columns.Add("Hostline");
                dt_Cp.Columns.Add("Email");
                foreach(var result in results)
                {
                    if(result.GetValue("delete_at", "").ToString() == "")
                    {
                        DataRow row = dt_Cp.NewRow();
                        row["ID"] = result.GetValue("ID", "").ToString();
                        row["Name"] = result.GetValue("Name", "").ToString();
                        row["Address"] = result.GetValue("Address", "").ToString();
                        row["Hostline"] = result.GetValue("Hostline", "").ToString();
                        row["Email"] = result.GetValue("Email", "").ToString();
                        dt_Cp.Rows.Add(row);
                    }
                }
            }
            return dt_Cp;
        }

        public List<Account> GetAccountCSDL()
        {
            var cps = company.Find(_ => true).ToList();
            var sts = staff.Find(_ => true).ToList();
            var ads = admin.Find(_ => true).ToList();
            List<Account> accounts = new List<Account>();
            if (cps.Count > 0)
            {
                foreach (var result in cps)
                {
                    if (result.GetValue("delete_at", "").ToString() == "")
                    {
                        Account account = new Account();
                        account.name = result.GetValue("Account.Name", "").ToString();
                        account.pass = result.GetValue("Account.Pass", "").ToString();
                        if (account.name == "")
                            break;
                        else
                            accounts.Add(account);
                    }
                }
            }
            if(sts.Count > 0)
            {
                foreach (var result in sts)
                {
                    if (result.GetValue("delete_at", "").ToString() == "")
                    {
                        Account account = new Account();
                        account.name = result.GetValue("Account.Name", "").ToString();
                        account.pass = result.GetValue("Account.Pass", "").ToString();
                        if (account.name == "")
                            break;
                        else
                            accounts.Add(account);
                    }
                }
            }
            if(ads.Count > 0)
            {
                foreach (var result in ads)
                {
                    if (result.GetValue("delete_at", "").ToString() == "")
                    {
                        Account account = new Account();
                        account.name = result.GetValue("Name", "").ToString();
                        account.pass = result.GetValue("Pass", "").ToString();
                        if (account.name == "")
                            break;
                        else
                            accounts.Add(account);
                    }
                }
            }
            return accounts;
        }

        public DataTable LoadAccount()
        {
            List<Account> accounts = GetAccountCSDL();
            DataTable dt = new DataTable();
            if(accounts.Count > 0)
            {
                dt.Columns.Add("Id");
                dt.Columns.Add("Name");
                dt.Columns.Add("NameAccount");
                dt.Columns.Add("PassAccount");
                foreach (var account in accounts)
                {
                    DataRow row = dt.NewRow();
                    //row["Id"] = account.Id;
                    //row["Name"] = account.Name;
                    row["NameAccount"] = account.name;
                    row["PassAccount"] = account.pass;
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
    }
}
