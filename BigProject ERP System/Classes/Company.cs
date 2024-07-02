using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ERPSys.Currency;


namespace ERPSys
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; } = "";
        
        public Addresse addresse { get; set; }
        public Currency.Valuta Money { get; set; } 

        public Company(int id, string companyName, Currency.Valuta currency, Addresse aDdresse)
        {
            Id = id;
            CompanyName = companyName;
            Money = currency;
            addresse = aDdresse;
        }
    }
}
