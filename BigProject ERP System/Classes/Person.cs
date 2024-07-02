using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSys
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Navn { get; set; }
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }
        public string Tlfnummer { get; set; }
        public string Mail { get; set; }
        
        public Addresse addresse { get; set; }

        public Person(int personid, string navn, string fornavn, string efternavn, string tlfnummer, string mail)
        {
            PersonId = personid;
            Navn = navn;
            Fornavn = fornavn;
            Efternavn = efternavn;
            Tlfnummer = tlfnummer;
            Mail = mail;
        }

        public string Fullname()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }
}
