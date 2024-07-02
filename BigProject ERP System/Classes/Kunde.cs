using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSys
{
    public class Kunde : Person
    {
        public int KundeNummer { get; set; }
        public DateTime Dato { get; set; }
        
        public Kunde(int personid, string navn, string fornavn, string efternavn, string tlfnummer, string mail, int kundenummer, DateTime dato)
            : base(personid, navn, fornavn, efternavn, tlfnummer, mail )
        {
            KundeNummer = kundenummer;
            Dato = dato;
        }     
    }
}
