using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAO
{
    public class Staff
    {
        int Id;
        string Name;
        DateTime DayofBirth;
        string Address;
        string Email;
        string NumberPhone;
        int Age;
        List<Recruitment> Recruitment;
        List<Account> Accounts;

        public Staff()
        {
        }

        public Staff(List<Recruitment> recruitment)
        {
            Recruitment = recruitment;
        }

        public Staff(List<Account> accounts)
        {
            Accounts = accounts;
        }

        public Staff(int id, string name, DateTime dayofBirth, string address, string email, string numberPhone, int age)
        {
            Id = id;
            Name = name;
            DayofBirth = dayofBirth;
            Address = address;
            Email = email;
            NumberPhone = numberPhone;
            Age = age;
        }

        public int id { get => Id; set => Id = value; }
        public string name { get => Name; set => Name = value; }
        public DateTime dayofBirth { get => DayofBirth; set => DayofBirth = value; }
        public string address { get => Address; set => Address = value; }
        public string email { get => Email; set => Email = value; }
        public string numberPhone { get => NumberPhone; set => NumberPhone = value; }
        public int age { get => Age; set => Age = value; }
        public List<Recruitment> recruitments { get => Recruitment; set => Recruitment = value; }
        public List<Account> accounts { get => Accounts; set => Accounts = value; }
    }
}
