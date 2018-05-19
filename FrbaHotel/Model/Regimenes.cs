using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Regimenes
    {
        private string descripcion;
        private decimal precioDolares;
        private bool estado;

        public string getDescripcion()
        {
            return this.descripcion;

        }
        public void setDescripcion(String unaDescripcion)
        {
            this.descripcion = unaDescripcion;
        }

        public decimal getPrecioDolares()
        {
            return this.precioDolares;
        }
        public void setPrecioDolares(decimal unPrecioDolares)
        {
            this.precioDolares = unPrecioDolares;
        }

        public bool getEstado()
        {
            return this.estado;

        }
        public void setEstado(bool unEstado)
        {
            this.estado = unEstado;
        }


    }
}
