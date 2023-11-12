using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    public class Kontakt
    {
        public Kontakt(string name, string surname, string email, int prefix, int phone, string job)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.prefix = prefix;
            this.phone = phone;
            this.job = job;
        }

        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set;}
        public string job { get; set;}
        public int prefix {  get; set;}
        public int phone { get; set;}

        public override string ToString()
        {
            return $"{name} - {surname} - {prefix} - {phone} - {email} - {job}";
        }

    }
}
