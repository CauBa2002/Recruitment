using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class Account
    {
        string Name;
        string Pass;

        public Account()
        {
        }

        public Account(string name, string pass)
        {
            Name = name;
            Pass = pass;
        }

        public string name { get => Name; set => Name = value; }
        public string pass { get => Pass; set => Pass = value; }
    }
}
