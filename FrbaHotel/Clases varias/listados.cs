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
        string fecha;

        public string ajustarFecha(string anio,int trimestre)
        {
            if (trimestre == 1) {return "FECHA_FACTURA BETWEEN '" + anio + "-01-01' AND '" + anio + "-03-31'"; }
            if (trimestre == 2) { return "FECHA_FACTURA BETWEEN '" + anio + "-04-01' AND '" + anio + "-06-31'"; }
            if (trimestre == 3) { return "FECHA_FACTURA BETWEEN '" + anio + "-07-01' AND '" + anio + "-09-31'"; }
            if (trimestre == 4) { return "FECHA_FACTURA BETWEEN '" + anio + "-10-01' AND '" + anio + "-12-31'"; }
            else { return "error"; }
        }


        public DataTable ListarHotelesConMayorCantidadDeReservasCanceladas(string anio, int trimestre)
        //Hoteles con mayor cantidad de reservas canceladas. 
        {
            fecha = ajustarFecha(anio, trimestre);
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = ""; ;
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public DataTable ListarHotelesConMayorCantidadDeConsumiblesFacturados(string anio, int trimestre)
        //Hoteles con mayor cantidad de consumibles facturados. 
        {
            fecha = ajustarFecha(anio, trimestre);
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT TOP 5 A.NOMBRE,COUNT(F.ID_ITEM_FACTURA) AS CONTADOR FROM LOS_MAGIOS.HOTELES A INNER JOIN LOS_MAGIOS.HABITACIONES B ON A.ID_HOTEL=B.ID_HOTEL INNER JOIN LOS_MAGIOS.HABITACIONES_POR_RESERVA C ON B.NUMERO_HABITACION=C.NUMERO_HABITACION AND B.ID_HOTEL=C.ID_HOTEL INNER JOIN LOS_MAGIOS.RESERVAS D ON C.CODIGO_RESERVA=D.CODIGO_RESERVA INNER JOIN LOS_MAGIOS.FACTURA E ON D.CODIGO_RESERVA = E.CODIGO_RESERVA INNER JOIN LOS_MAGIOS.ITEM_FACTURA F ON E.NUMERO_FACTURA=F.NUMERO_FACTURA INNER JOIN LOS_MAGIOS.CONSUMIBLES G ON F.CODIGO_CONSUMIBLE=G.CODIGO_CONSUMIBLE GROUP BY A.NOMBRE ORDER BY CONTADOR ASC";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }


        public DataTable ListarHotelesConMayorCantidadDeDiasFueraDeServicio(string anio, int trimestre)
            //Hoteles con mayor cantidad de días fuera de servicio.
        {
            fecha = ajustarFecha(anio, trimestre);
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }

        public DataTable ListarHabitacionesCon(string anio, int trimestre)
        //Habitaciones con mayor cantidad de días y veces que fueron ocupadas, informando a demás a que hotel perteneces.
        {
            fecha = ajustarFecha(anio, trimestre);
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }


        public DataTable ListarClientesConMayorCantidadDePuntos(string anio, int trimestre)
        //Cliente con mayor cantidad de puntos
        {
            fecha = ajustarFecha(anio, trimestre);
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
