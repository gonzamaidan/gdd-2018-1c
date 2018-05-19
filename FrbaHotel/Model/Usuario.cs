﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Usuario
    {
        private string password;
        private string nombre;
        private string apellido;
        private string mail;
        private int telefono;
        private string direccion;
        private DateTime fechaDeNacimiento;

        public string getPassword()
        {
            return this.password;

        }
        public void setPassword(unaPass)
        {
            this.password = unaPass;
        }
        
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

         public DateTime getFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
           
        }
        public void setFechaDeNacimiento(unaFechaDeNacimiento)
        {
            this.fechaDeNacimiento = unaFechaDeNacimiento;
        }
    }
}
