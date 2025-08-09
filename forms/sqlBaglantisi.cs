using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastaneProjesi
{
    class sqlBaglantisi

    {
        string adres = System.IO.File.ReadAllText(@"D:\patika_web_tasarım\c#\hastane.txt");

        public SqlConnection baglanti()
            {
                SqlConnection conn = new SqlConnection(adres);
                
                return conn;
            }
       
    }
}
