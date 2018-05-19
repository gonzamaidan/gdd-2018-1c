using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Registro_Reservas
    {
        private int codigoReserva;
        private string accion;
        private DateTime fecha;
        private string motivo;
        private string usuario;


        public int getCodigoReserva()
        {
            return this.codigoReserva;
           
        }
        public void setCodigoReserva(int unCodigoReserva)
        {
            this.codigoReserva = unCodigoReserva;
        }

        public string getAccion()
        {
            return this.accion;
           
        }
        public void setAccion(string unaAccion)
        {
            this.accion = unaAccion;
        }

        public DateTime getFecha()
        {
            return this.fecha;
           
        }
        public void setFecha(DateTime unaFecha)
        {
            this.fecha = unaFecha;
        }

        public string getMotivo()
        {
            return this.motivo;
           
        }
        public void setMotivo(string unMotivo)
        {
            this.motivo = unMotivo;
        }

        public string getUsuario()
        {
            return this.usuario;
           
        }
        public void setUsuario(string unUsuario)
        {
            this.usuario = unUsuario;
        }


    }
}
