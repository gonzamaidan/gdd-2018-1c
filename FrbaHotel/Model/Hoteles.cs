using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Hoteles
    {
        private string nombre;
        private string mail;
        private int telefono;
        private string direccion;
        private int estrellas;
        private string ciudad;
        private string pais;
        private DateTime fechaCreacion;
        private bool estado;
        private List<Habitaciones> habitaciones;

        public string getNombre()
        {
            return this.nombre;

        }
        public void setNombre(string unNombre)
        {
            this.nombre = unNombre;
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

        public int getEstrellas()
        {
            return this.estrellas;

        }
        public void setEstrellas(int unasEstrellas)
        {
            this.estrellas = unasEstrellas;
        }

        public string getCiudad()
        {
            return this.ciudad;

        }
        public void setCiudad(string unaCiudad)
        {
            this.ciudad = unaCiudad;
        }

        public string getPais()
        {
            return this.pais;

        }
        public void setPais(string unPais)
        {
            this.pais = unPais;
        }

        public DateTime getFechaCreacion()
        {
            return this.fechaCreacion;

        }
        public void setFechaCreacion(DateTime unaFechaDeCreacion)
        {
            this.fechaCreacion = unaFechaDeCreacion;
        }

        public bool getEstado()
        {
            return this.estado;

        }
        public void setEstado(bool unEstado)
        {
            this.estado = unEstado;
        }

        public List<Habitaciones> getHabitaciones()
        {
            return this.habitaciones;

        }
        public void setHabitaciones(List<Habitaciones> unasHabitaciones)
        {
            this.habitaciones = unasHabitaciones;
        }
    }
}
