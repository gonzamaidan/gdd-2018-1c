using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaHotel
{
    public class conexion
    {
        SqlDataAdapter da;
        DataTable dt;

        private SqlConnection conexionBD = new SqlConnection("Data Source=NICO\\SQLSERVER2012;Initial Catalog=GD1C2018;User ID=gdHotel2018;Password=gd2018");

        public SqlConnection abrirConexion()
        {
            if (conexionBD.State == ConnectionState.Closed)
            {
                conexionBD.Open();
            }
            
                return conexionBD;
            
        }

        public SqlConnection cerrarConexion()
        {
            if (conexionBD.State == ConnectionState.Open)
            {
                conexionBD.Close();
            }

            return conexionBD;

        }


    }
}
