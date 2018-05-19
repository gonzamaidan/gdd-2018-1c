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
        public void setNombre(unNombre)
        {
            this.nombre = unNombre;
        }

        public string getApellido()
        {
            return this.apellido;

        }
        public void setApellido(unApellido)
        {
            this.apellido = unApellido;
        }

        public int getIdentificacion()
        {
            return this.identificacion;

        }
        public void setIdentificacion(unaIdentificacion)
        {
            this.identificacion = unaIdentificacion;
        }

        public int getTipoIdentificacion()
        {
            return this.tipoIdentificacion;

        }
        public void setTipoIdentificacion(unTipoDeIdentificacion)
        {
            this.tipoIdentificacion = unTipoDeIdentificacion;
        }



        public string getMail()
        {
            return this.mail;

        }
        public void setMail(unMail)
        {
            this.mail = unMail;
        }

        public int getTelefono()
        {
            return this.telefono;

        }
        public void setTelefono(unTelefono)
        {
            this.telefono = unTelefono;
        }

        public string getDireccion()
        {
            return this.direccion;
           
        }
        public void setDireccion(unaDireccion)
        {
            this.direccion = unaDireccion;
        }

        public string getLocalidad()
        {
            return this.localidad;
           
        }
        public void setLocalidad(unaLocalidad)
        {
            this.localidad = unaLocalidad;
        }

        public string getPais()
        {
            return this.pais;
           
        }
        public void setPais(unPais)
        {
            this.pais = unPais;
        }

        public string getPais()
        {
            return this.pais;
           
        }
        public void setNacionalidad(unaNacionalidad)
        {
            this.nacionalidad = unaNacionalidad;
        }


         public DateTime getFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
           
        }
        public void setFechaDeNacimiento(unaFechaDeNacimiento)
        {
            this.fechaDeNacimiento = unaFechaDeNacimiento;
        }

        public bool getDuplicado()
        {
            return this.duplicado;
           
        }
        public void setDuplicado(unDuplicado)
        {
            this.duplicado = unDuplicado;
        }

    }
}
