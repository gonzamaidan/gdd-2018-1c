using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrbaHotel
{
    public class rolesDeUsuario
    {
        private conexion unaConexion = new conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarRolesSegunUsuario(string user)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT A.USUARIO,B.ID_ROL FROM LOS_MAGIOS.USUARIOS A INNER JOIN LOS_MAGIOS.ROLES_POR_USUARIO B ON A.USUARIO = B.USUARIO  WHERE USUARIO =" + user;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public int contarRolesSegunUsuario(string user)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT A.USUARIO,B.ID_ROL FROM LOS_MAGIOS.USUARIOS A INNER JOIN LOS_MAGIOS.ROLES_POR_USUARIO B ON A.USUARIO = B.USUARIO  WHERE A.USUARIO ='"+ user+"'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla.Rows.Count;
        }

        public int encontrarRolSegunUsuario(string user, int unRol)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT A.USUARIO,B.ID_ROL FROM LOS_MAGIOS.USUARIOS A INNER JOIN LOS_MAGIOS.ROLES_POR_USUARIO B ON A.USUARIO = B.USUARIO  WHERE A.USUARIO ='"+ user+"'";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            unRol = (from DataRow dr in Tabla.Rows
                     where (string)dr["USUARIO"] == user
                     select (int)dr["ID_ROL"]).FirstOrDefault();

            return unRol;
        }

        public DataTable listarRoles() 
        {
          
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT * FROM LOS_MAGIOS.ROLES WHERE NOMBRE != 'GUEST' OR NOMBRE != 'guest' OR NOMBRE != 'HUESPED' OR NOMBRE != 'huesped' ";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public DataTable listarFuncionalidades()
        {

            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT * FROM LOS_MAGIOS.FUNCIONALIDADES  ";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public DataTable listarRolesParaFuncionalidad()
        {

            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT ID_ROL,NOMBRE FROM LOS_MAGIOS.ROLES ";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public DataTable listarFuncionesSegunRol(int unRol)
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT A.ID_FUNCIONALIDAD,A.DESCRIPCION FROM LOS_MAGIOS.FUNCIONALIDADES A INNER JOIN LOS_MAGIOS.FUNCIONALIDADES_POR_ROL B ON A.ID_FUNCIONALIDAD=B.ID_FUNCIONALIDAD INNER JOIN LOS_MAGIOS.ROLES C ON B.ID_ROL=C.ID_ROL WHERE B.ID_ROL="+unRol;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }


        public void insertarRol(string descripcionRol, int estado)
        {
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "INSERT INTO LOS_MAGIOS.ROLES VALUES ('"+descripcionRol+"',"+estado+")";
            comando.ExecuteNonQuery();

        }
        public void modificarRol(int id, string descripcionRol, int estado)
        {
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "UPDATE LOS_MAGIOS.ROLES SET NOMBRE = '" + descripcionRol + "', ESTADO = " + estado+" WHERE ID_ROL = "+id+" " ;
            comando.ExecuteNonQuery();

        }

        public void eliminarRol(int id)
        {
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "DELETE LOS_MAGIOS.ROLES WHERE ID_ROL="+id;
            comando.ExecuteNonQuery();
        }

        public void insertarFuncionalidadEnRol(int idRol, int idFuncionalidad)
        {
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "INSERT INTO LOS_MAGIOS.FUNCIONALIDADES_POR_ROL VALUES (" + idRol + "," + idFuncionalidad + ")";
            comando.ExecuteNonQuery();

        }
        public void modificarFuncionalidadEnRol(int idFuncionalidad, string descripcionFuncionalidad)
        {
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "UPDATE LOS_MAGIOS.FUNCIONALIDADES SET DESCRIPCION = '" + descripcionFuncionalidad + "' WHERE ID_FUNCIONALIDAD = " + idFuncionalidad + " ";
            comando.ExecuteNonQuery();

        }

        public void eliminarFuncionalidadEnRol(int idFuncionalidad)
        {
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "DELETE LOS_MAGIOS.FUNCIONALIDADES_POR_ROL WHERE ID_FUNCIONALIDAD=" + idFuncionalidad;
            comando.ExecuteNonQuery();
        }
    }
}
/*string countryName = "USA";
DataTable dt = new DataTable();
int id = (from DataRow dr in dt.Rows
              where (string)dr["CountryName"] == countryName
              select (int)dr["id"]).FirstOrDefault();*/