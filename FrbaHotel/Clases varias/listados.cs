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
            if (trimestre == 1) { return " BETWEEN '" + anio + "-01-01' AND '" + anio + "-03-31'"; }
            if (trimestre == 2) { return " BETWEEN '" + anio + "-04-01' AND '" + anio + "-06-31'"; }
            if (trimestre == 3) { return " BETWEEN '" + anio + "-07-01' AND '" + anio + "-09-31'"; }
            if (trimestre == 4) { return " BETWEEN '" + anio + "-10-01' AND '" + anio + "-12-31'"; }
            else { return "error"; }
        }



        public DataTable ListarHotelesConMayorCantidadDeReservasCanceladas(string anio, int trimestre)
        //Hoteles con mayor cantidad de reservas canceladas. 
        {
            fecha = ajustarFecha(anio, trimestre);
            DataTable Tabla = new DataTable();
            comando.Connection = unaConexion.abrirConexion();
            comando.CommandText = "SELECT TOP 5 HT.ID_HOTEL, HT.NOMBRE, COUNT(1) AS RESERVAS_CANCELADAS FROM LOS_MAGIOS.HOTELES HT JOIN LOS_MAGIOS.HABITACIONES HB ON HT.ID_HOTEL = HB.ID_HOTEL JOIN LOS_MAGIOS.HABITACIONES_POR_RESERVA HBR ON HB.NUMERO_HABITACION = HBR.NUMERO_HABITACION AND HB.ID_HOTEL = HBR.ID_HOTEL JOIN LOS_MAGIOS.RESERVAS R ON R.CODIGO_RESERVA = HBR.CODIGO_RESERVA WHERE R.ID_ESTADO_RESERVA IN (3,4,5) WHERE R.FECHA_RESERVA"+fecha+" GROUP BY HT.ID_HOTEL, HT.NOMBRE ORDER BY COUNT(1) DESC";
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
            comando.CommandText = "SELECT TOP 5 A.NOMBRE,COUNT(F.ID_ITEM_FACTURA) AS CONTADOR FROM LOS_MAGIOS.HOTELES A INNER JOIN LOS_MAGIOS.HABITACIONES B ON A.ID_HOTEL=B.ID_HOTEL INNER JOIN LOS_MAGIOS.HABITACIONES_POR_RESERVA C ON B.NUMERO_HABITACION=C.NUMERO_HABITACION AND B.ID_HOTEL=C.ID_HOTEL INNER JOIN LOS_MAGIOS.RESERVAS D ON C.CODIGO_RESERVA=D.CODIGO_RESERVA INNER JOIN LOS_MAGIOS.FACTURA E ON D.CODIGO_RESERVA = E.CODIGO_RESERVA INNER JOIN LOS_MAGIOS.ITEM_FACTURA F ON E.NUMERO_FACTURA=F.NUMERO_FACTURA INNER JOIN LOS_MAGIOS.CONSUMIBLES G ON F.CODIGO_CONSUMIBLE=G.CODIGO_CONSUMIBLE WHERE E.FECHA_FACTURA"+fecha+" GROUP BY A.NOMBRE ORDER BY CONTADOR ASC";
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
            comando.CommandText = "SELECT TOP 5 ID_HOTEL, SUM(DATEDIFF(DAY,  FECHA_FIN_BAJA, FECHA_INICIO_BAJA)) AS SUMA FROM LOS_MAGIOS.BAJA_HOTELES WHERE FECHA_INICIO"+fecha+" GROUP BY ID_HOTEL ORDER BY SUMA desc";
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
            comando.CommandText = "SELECT TOP 5 HB.NUMERO_HABITACION 'Numero habitacion', HT.NOMBRE 'Nombre hotel', SUM(DATEDIFF(day,E.FECHA_INGRESO,E.FECHA_EGRESO)) 'Dias ocupados', COUNT(DISTINCT E.CODIGO_RESERVA) 'Veces ocupado' FROM LOS_MAGIOS.ESTADIAS E JOIN LOS_MAGIOS.HABITACIONES_POR_RESERVA HPR ON E.CODIGO_RESERVA = HPR.CODIGO_RESERVA JOIN LOS_MAGIOS.HABITACIONES HB ON HB.ID_HOTEL = HPR.ID_HOTEL AND HB.NUMERO_HABITACION = HPR.NUMERO_HABITACION JOIN LOS_MAGIOS.HOTELES HT ON HT.ID_HOTEL =  HB.ID_HOTEL WHERE E.FECHA_INGRESO"+fecha+" GROUP BY HB.NUMERO_HABITACION, HT.NOMBRE ORDER BY SUM(DATEDIFF(day,E.FECHA_INGRESO,E.FECHA_EGRESO)) DESC, COUNT(DISTINCT E.CODIGO_RESERVA) DESC";
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
            comando.CommandText = "SELECT TOP 5 C.CODIGO_CLIENTE 'Codigo cliente',C.APELLIDO 'Apellido',C.NOMBRE 'Nombre',(CONVERT(int,SUM(CASE WHEN I.CODIGO_CONSUMIBLE IS NULL THEN I.PRECIO_UNIDAD * I.CANTIDAD END) / 20) + CONVERT(int,SUM(CASE WHEN I.CODIGO_CONSUMIBLE IS NOT NULL THEN I.PRECIO_UNIDAD * I.CANTIDAD END) / 10)) 'Puntos' FROM LOS_MAGIOS.CLIENTES C JOIN LOS_MAGIOS.CLIENTES_POR_RESERVA CPR ON CPR.CODIGO_CLIENTE = C.CODIGO_CLIENTE JOIN LOS_MAGIOS.FACTURA F ON F.CODIGO_RESERVA = CPR.CODIGO_RESERVA JOIN LOS_MAGIOS.ITEM_FACTURA I ON I.NUMERO_FACTURA = F.NUMERO_FACTURA WHERE F.FECHA_FACTURA"+fecha+" GROUP BY C.CODIGO_CLIENTE, C.APELLIDO, C.NOMBRE ORDER BY 'Puntos' desc";
            LeerFilas = comando.ExecuteReader();
            Tabla.Load(LeerFilas);
            LeerFilas.Close();
            unaConexion.cerrarConexion();
            return Tabla;
        }


    }
}
