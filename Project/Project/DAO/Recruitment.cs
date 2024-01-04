using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class Recruitment
    {
        string Company;
        string Role;
        string Level;

        public Recruitment()
        {
        }

        public Recruitment(string company, string role, string level)
        {
            Company = company;
            Role = role;
            Level = level;
        }

        public string company { get => Company; set => Company = value; }
        public string role { get => Role; set => Role = value; }
        public string level { get => Level; set => Level = value; }
    }
}
