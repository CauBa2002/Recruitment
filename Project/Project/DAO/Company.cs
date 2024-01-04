using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class Company
    {
        string Id;
        string Name;
        string Address;
        int Hostline;
        string Email;
        List<Vacancies> Vacancies;
        List<Account> Accounts;

        public Company()
        {
        }

        public Company(List<Vacancies> vacancies)
        {
            Vacancies = vacancies;
        }

        public Company(List<Account> accounts)
        {
            Accounts = accounts;
        }

        public Company(string id, string name, string address, int hostline, string email)
        {
            Id = id;
            Name = name;
            Address = address;
            Hostline = hostline;
            Email = email;
        }

        public string id { get => Id; set => Id = value; }
        public string name { get => Name; set => Name = value; }
        public string address { get => Address; set => Address = value; }
        public int hostline { get => Hostline; set => Hostline = value; }
        public string email { get => Email; set => Email = value; }
        public List<Vacancies> vacanciess { get => Vacancies; set => Vacancies = value; }
        public List<Account> accounts { get => Accounts; set => Accounts = value; }
    }
}
