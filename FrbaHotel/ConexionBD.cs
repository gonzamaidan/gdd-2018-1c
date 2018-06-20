using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    class ConexionBD
    {
        public static SqlConnection conectar()
        {
            return new SqlConnection(Program.connectionString);
        }

    }
}
