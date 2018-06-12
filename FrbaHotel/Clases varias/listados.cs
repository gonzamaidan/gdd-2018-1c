using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FrbaHotel.Clases_varias
{
    public class listados
    {

        private conexion unaConexion = new conexion();
        private SqlCommand comando = new SqlCommand();
        private SqlDataReader LeerFilas;

        public DataTable ListarHotelesConMayorCantidadDeReservasCanceladas(int anio, int trimestre)
        //Hoteles con mayor cantidad de reservas canceladas. 
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = ""; ;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public DataTable ListarHotelesConMayorCantidadDeConsumiblesFacturados(int anio, int trimestre)
        //Hoteles con mayor cantidad de consumibles facturados. 
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT TOP 5 A.NOMBRE,COUNT(F.ID_ITEM_FACTURA) AS CONTADOR FROM LOS_MAGIOS.HOTELES A INNER JOIN LOS_MAGIOS.HABITACIONES B ON A.ID_HOTEL=B.ID_HOTEL INNER JOIN LOS_MAGIOS.HABITACIONES_POR_RESERVA C ON B.NUMERO_HABITACION=C.NUMERO_HABITACION AND B.ID_HOTEL=C.ID_HOTEL INNER JOIN LOS_MAGIOS.RESERVAS D ON C.CODIGO_RESERVA=D.CODIGO_RESERVA INNER JOIN LOS_MAGIOS.FACTURA E ON D.CODIGO_RESERVA = E.CODIGO_RESERVA INNER JOIN LOS_MAGIOS.ITEM_FACTURA F ON E.NUMERO_FACTURA=F.NUMERO_FACTURA INNER JOIN LOS_MAGIOS.CONSUMIBLES G ON F.CODIGO_CONSUMIBLE=G.CODIGO_CONSUMIBLE GROUP BY A.NOMBRE ORDER BY CONTADOR ASC";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }


        public DataTable ListarHotelesConMayorCantidadDeDiasFueraDeServicio(int anio, int trimestre)
            //Hoteles con mayor cantidad de días fuera de servicio.
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public DataTable ListarHabitacionesCon(int anio, int trimestre)
        //Habitaciones con mayor cantidad de días y veces que fueron ocupadas, informando a demás a que hotel perteneces.
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }


        public DataTable ListarClientesConMayorCantidadDePuntos(int anio, int trimestre)
        //Cliente con mayor cantidad de puntos
        {
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }


    }
}
