using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Tipos_Habitacion
    {
        private string descripcion;
        private decimal porcentaje;

        public string getDescripcion()
        {
            return this.descripcion;

        }
        public void setDescripcion(String unaDescripcion)
        {
            this.descripcion = unaDescripcion;
        }

        public decimal getPorcentaje()
        {
            return this.porcentaje;

        }
        public void setPorcentaje(decimal unPorcentaje)
        {
            this.porcentaje = unPorcentaje;
        }
    }
}
