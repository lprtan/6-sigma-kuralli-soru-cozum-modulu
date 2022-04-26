using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace YazılımYapımıProje
{
    public class DataBase
    {
        public SqlConnection baglanti = new SqlConnection(@"Data Source=DELL-BILGISAYAR;Initial Catalog=Proje;Integrated Security=True");
    }
}
