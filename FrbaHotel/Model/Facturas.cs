using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Facturas
    {
        private int codigoReserva;
        private DateTime fechaFactura;
        private decimal totalFactura;
        private bool inconsistente;

        public int getCodigoReserva()
        {
            return this.codigoReserva;
        }
        public void setCodigoReserva(int unCodigoReserva)
        {
            this.codigoReserva = unCodigoReserva;
        }
        public DateTime getFechaFactura()
        {
            return this.fechaFactura;
        }
        public void setFechaFactura(DateTime unaFechaFactura)
        {
            this.fechaFactura = unaFechaFactura;
        }
        public decimal getTotalFactura()
        {
            return this.totalFactura;
        }
        public void setTotalFactura(decimal unTotalFactura)
        {
            this.totalFactura = unTotalFactura;
        }
        public bool getInconsistente()
        {
            return this.inconsistente;
        }
        public void setInconsistente(bool unInconsistente)
        {
            this.inconsistente = unInconsistente;
        }
    }
}
