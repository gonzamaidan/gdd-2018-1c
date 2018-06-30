using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //[STAThread]

        public static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static string fechaHoyString = ConfigurationManager.AppSettings["fechaHoy"];
        public static DateTime fechaHoy;

        static void Main()
        {
            fechaHoy = DateTime.ParseExact(fechaHoyString, "yyyy-M-d", null);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new GenerarModificacionReserva.GenerarReservas());
            Application.Run(new GenerarModificacionReserva.ModificarReserva());
            //Application.Run(new CancelarReserva.CancelarReserva());
            //Application.Run(new AbmUsuario.BuscadorForm());
        }

        
    }
}
