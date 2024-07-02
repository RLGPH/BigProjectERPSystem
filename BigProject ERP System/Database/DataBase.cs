using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigProject_ERP_System
{
    public partial class DataBase
    {
        public static DataBase Instance { get; private set; } = new DataBase();
    }
}
