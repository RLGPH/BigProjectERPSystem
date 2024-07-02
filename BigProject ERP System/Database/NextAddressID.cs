using ERPSys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject_ERP_System.Database
{
    public partial class DataBase
    {
        public int NextUsableAddressId(Addresse addresse)
        {
            List<Addresse> Addresses = new();

            if (addresse == null)
            {
                Addresse address1 = new(1, "Vej1", "1", "1000", "By1", "Land1");
                Addresse address2 = new(2, "Vej2", "2", "2000", "By2", "Land2");
                Addresse address3 = new(3, "Vej3", "3", "3000", "By3", "Land3");
                Addresse address4 = new(4, "Vej4", "4", "4000", "By4", "Land4");
                Addresses.Add(address1);
                Addresses.Add(address2);
                Addresses.Add(address3);
                Addresses.Add(address4);
            }

            if (addresse.AddressId >= 0)
            {
                int maxId = 0;
                if (Addresses.Count > 0)
                {
                    maxId = Addresses.Max(a => a.AddressId);
                }

                addresse.AddressId = maxId + 1;
                Addresses.Add(addresse);

                return addresse.AddressId;
            }
            return 0;
        }
    }
}
