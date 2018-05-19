using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Consumibles
    {
        private string descripcion;
        private decimal precioConsumible;

        public string getDescripcion()
        {
            return this.descripcion;
        }
        public void setDescripcion(string unaDescripcion)
        {
            this.descripcion = unaDescripcion;
        }

        public decimal getPrecioConsumible()
        {
            return this.precioConsumible;
        }
        public void setPrecioConsumible(decimal unPrecioConsumible)
        {
            this.precioConsumible = unPrecioConsumible;
        }
    }
}
