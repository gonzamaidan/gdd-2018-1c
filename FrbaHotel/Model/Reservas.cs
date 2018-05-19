using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Reservas
    {
        private DateTime fechaReserva;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private string estadoReserva;

        public DateTime getFechaReserva()
        {
            return this.fechaReserva;
        }
        public void setFechaReserva(DateTime unaFechaReserva)
        {
            this.fechaReserva = unaFechaReserva;
        }

        public DateTime getFechaDesde()
        {
            return this.fechaDesde;
        }
        public void setFechaDesde(DateTime unaFechaDesde)
        {
            this.fechaDesde = unaFechaDesde;
        }

        public DateTime getFechaHasta()
        {
            return this.fechaHasta;
        }
        public void setFechaHasta(DateTime unaFechaHasta)
        {
            this.fechaHasta = unaFechaHasta;
        }

        public string getEstadoReserva()
        {
            return this.estadoReserva;
        }
        public void setEstadoReserva(string unEstadoReserva)
        {
            this.estadoReserva = unEstadoReserva;
        }

    }
}
