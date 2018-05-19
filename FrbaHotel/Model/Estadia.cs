using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Estadia
    {
        private DateTime fecha_ingreso;
        private DateTime fecha_egreso;

        public DateTime getFechaIngreso()
        {
            return this.fechaIngreso;
        }
        public void setFechaIngreso(DateTime unaFechaIngreso)
        {
            this.fechaIngreso = unaFechaIngreso;
        }

        public DateTime getFechaEgreso()
        {
            return this.fechaEgreso;
        }
        public void setFechaEgreso(DateTime unaFechaEgreso)
        {
            this.fechaEgreso = unaFechaEgreso;
        }

    }
}
