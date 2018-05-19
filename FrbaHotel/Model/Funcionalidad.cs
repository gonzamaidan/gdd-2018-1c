using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    class Funcionalidad
    {
        private string descripcion;
        public string getDescripcion()
        {
            return this.descripcion;
        }
        public void setDescripcion(string unaDescripcion)
        {
            this.descripcion = unaDescripcion;
        }
    }
}
