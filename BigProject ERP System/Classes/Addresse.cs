using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPSys
{
    public class  Addresse
    {
        public int AddressId { get; set; }
        public string Land { get; set; } = "";
        public string By { get; set; } = "";
        public string Vej { get; set; } = "";
        public string Husnummer { get; set; } = "";
        public string Postnummer { get; set; } = "";

        public Addresse(int addressId, string vej, string husnummer, string postnummer, string by, string land)
        {
            AddressId = addressId;
            Land = land;
            By = by;
            Vej = vej;
            Husnummer = husnummer;
            Postnummer = postnummer;
        }
    }
}
