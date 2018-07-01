using FrbaHotel.Clases_varias;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        public static Sesion sesion;
        public static SqlConnection baseDeDatos = ConexionBD.conectar();

        static void Main()
        {
            sesion = new Sesion(ConexionBD.conectar());
            fechaHoy = DateTime.ParseExact(fechaHoyString, "yyyy-M-d", null);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new GenerarModificacionReserva.GenerarReservas());
            //Application.Run(new GenerarModificacionReserva.ModificarReserva());
            //Application.Run(new CancelarReserva.CancelarReserva());
            //Application.Run(new AbmUsuario.BuscadorForm());
            Application.Run(new Login.ventanaPrincipal());
        }

        public static String hashPassword(String password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed provider = new SHA256Managed();
            byte[] hash = provider.ComputeHash(bytes);
            String hashedPassword = "";
            foreach (byte x in hash)
            {
                hashedPassword += String.Format("{0:X2}", x);
            }
            return hashedPassword;
        }

        
    }
}
