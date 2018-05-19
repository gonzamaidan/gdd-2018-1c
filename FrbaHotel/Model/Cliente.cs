using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int identificacion;
        private Tipos_Identificacion tipoIdentificacion;
        private string mail;
        private int telefono;
        private string direccion;
        private string localidad;
        private string pais;
        private string nacionalidad;
        private DateTime fechaDeNacimiento;
        private bool duplicado;


        public string getNombre()
        {
            return this.nombre;

        }
        public void setNombre(string unNombre)
        {
            this.nombre = unNombre;
        }

        public string getApellido()
        {
            return this.apellido;

        }
        public void setApellido(string unApellido)
        {
            this.apellido = unApellido;
        }

        public int getIdentificacion()
        {
            return this.identificacion;

        }
        public void setIdentificacion(int unaIdentificacion)
        {
            this.identificacion = unaIdentificacion;
        }

        public int getTipoIdentificacion()
        {
            return this.tipoIdentificacion;

        }
        public void setTipoIdentificacion(int unTipoDeIdentificacion)
        {
            this.tipoIdentificacion = unTipoDeIdentificacion;
        }

        public string getMail()
        {
            return this.mail;

        }
        public void setMail(string unMail)
        {
            this.mail = unMail;
        }

        public int getTelefono()
        {
            return this.telefono;

        }
        public void setTelefono(int unTelefono)
        {
            this.telefono = unTelefono;
        }

        public string getDireccion()
        {
            return this.direccion;
           
        }
        public void setDireccion(string unaDireccion)
        {
            this.direccion = unaDireccion;
        }

        public string getLocalidad()
        {
            return this.localidad;
           
        }
        public void setLocalidad(string unaLocalidad)
        {
            this.localidad = unaLocalidad;
        }

        public string getPais()
        {
            return this.pais;
           
        }
        public void setPais(string unPais)
        {
            this.pais = unPais;
        }

        public string getNacionalidad()
        {
            return this.nacionalidad;
           
        }
        public void setNacionalidad(string unaNacionalidad)
        {
            this.nacionalidad = unaNacionalidad;
        }


         public DateTime getFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
           
        }
        public void setFechaDeNacimiento(DateTime unaFechaDeNacimiento)
        {
            this.fechaDeNacimiento = unaFechaDeNacimiento;
        }

        public bool getDuplicado()
        {
            return this.duplicado;
           
        }
        public void setDuplicado(bool unDuplicado)
        {
            this.duplicado = unDuplicado;
        }

    }
}
