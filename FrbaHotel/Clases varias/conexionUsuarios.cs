using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel
{
    public class conexionUsuarios
    {
        private conexion unaConexion = new conexion();
        private SqlDataReader leer;

        public SqlDataReader iniciarSesion(string user, string pass)
        {
            string sql = "SELECT * FROM LOS_MAGIOS.USUARIOS WHERE USUARIO = @Usuario AND CONTRASENA = @Password";
            SqlCommand comando = new SqlCommand();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = sql;
            comando.Parameters.Add("@Usuario", SqlDbType.VarChar);
            comando.Parameters["@Usuario"].Value = user;
            comando.Parameters.Add("@Password", SqlDbType.VarChar);
            comando.Parameters["@Password"].Value = Program.hashPassword(pass);
            leer = comando.ExecuteReader();
            return leer;
        }

        //public SqlDataReader leerRolDeUsuario(string user)
        //{
        //    string sql = "SELECT * FROM LOS_MAGIOS.USUARIOS A INNER JOIN LOS_MAGIOS.ROLES_POR_USUARIO B ON A.USUARIO = B.USUARIO  WHERE USUARIO =" + user ;
        //    SqlCommand comando = new SqlCommand();
        //    comando.Connection = unaConexion.abrirConexion();
        //    comando.CommandText = sql;
        //    leer = comando.ExecuteReader();
        //    return leer;
        //}


    }
}
