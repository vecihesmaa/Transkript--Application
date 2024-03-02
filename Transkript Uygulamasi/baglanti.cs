using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Npgsql.Internal;

namespace degisikdeneme
{
    public class baglanti
    {
        public NpgsqlConnection conn()
        {
            NpgsqlConnection baglan = new NpgsqlConnection("Server=localhost;Port=5432;Database=DERS;User Id=postgres;Password=1234");
            baglan.Open(); 
            return baglan;
        }
    }
}
