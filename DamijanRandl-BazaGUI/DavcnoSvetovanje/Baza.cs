using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace DavcnoSvetovanje
{
    public class Baza
    {
        public SQLiteConnection povezava;

        public Baza()
        {
            povezava = new SQLiteConnection("Data Source=Davcno_Svetovanje.db");
        }

        public void OdpriPovezavo()
        {
            if (povezava.State != System.Data.ConnectionState.Open)
            {
                povezava.Open();
            }
        }

        public void ZapriPovezavo()
        {
            if (povezava.State != System.Data.ConnectionState.Closed)
            {
                povezava.Close();
            }
        }
    }
}
