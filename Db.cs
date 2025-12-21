using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Npgsql;

namespace B241210094_VTYS
{
    public class Db
    {
        public static string ConnString =
            "Host=localhost;Port=5432;Database=AracTakip;Username=postgres;Password=Y1201.;";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnString);
        }
    }
}
