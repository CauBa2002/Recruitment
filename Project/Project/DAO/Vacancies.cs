using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class Vacancies
    {
        string Role;
        string Level;
        int Quantity;

        public Vacancies()
        {
        }

        public Vacancies(string role, string level, int quantity)
        {
            Role = role;
            Level = level;
            Quantity = quantity;
        }

        public string role { get => Role; set => Role = value; }
        public string level { get => Role; set => Role = value; }
        public int quantity { get => Quantity; set => Quantity = value; }
    }
}
