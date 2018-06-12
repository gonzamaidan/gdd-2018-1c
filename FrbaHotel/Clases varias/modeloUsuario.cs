using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaHotel
{
    public class modeloUsuario
    {
        private conexionUsuarios objDato = new conexionUsuarios();
        private String _usuario;
        private String _contrasena;
        private String _nombre;
        private String _apellido;
        private String _mail;
        private int _telefono;
        private String _direccion;
        private DateTime _fechaNacimiento;

        public String usuario
        {
            set { _usuario = value; }
            get {return _usuario; }
        }

        public String contrasena
        {
            set{_contrasena=value;}
            get {return _contrasena ;}
        }

        public modeloUsuario() { }

        public SqlDataReader iniciarSesion() 
        {
            SqlDataReader loguear;
            loguear = objDato.iniciarSesion(usuario,contrasena);
            return loguear;
        }
    }
}
