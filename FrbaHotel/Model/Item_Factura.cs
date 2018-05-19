using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Item_Factura
    {
        private int numeroFactura;
        private int cantidad;
        private decimal precioCantidad;
        private int codigoConsumible;

        public int getNumeroFactura()
        {
            return this.numeroFactura;
        }
        public void setNumeroFactura(int unNumeroFactura)
        {
            this.numeroFactura = unNumeroFactura;
        }
        public int getCantidad()
        {
            return this.cantidad;
        }
        public void setCantidad(int unaCantidad)
        {
            this.cantidad = unaCantidad;
        }
        public decimal getPrecioCantidad()
        {
            return this.precioCantidad;
        }
        public void setPrecioCantidad(decimal unPrecioCantidad)
        {
            this.precioCantidad = unPrecioCantidad;
        }
        public int getCodigoConsumible()
        {
            return this.codigoConsumible;
        }
        public void setCodigoConsumible(int unCodigoConsumible)
        {
            this.codigoConsumible = unCodigoConsumible;
        }

    }
}
