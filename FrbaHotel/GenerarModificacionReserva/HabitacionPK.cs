using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.GenerarModificacionReserva
{
    class HabitacionPK
    {
        public int nroHabitacion;
        public int idHotel;
        public int codigoRegimen;

        public HabitacionPK(int nroHabitacion, int idHotel, int codigoRegimen)
        {
            this.nroHabitacion = nroHabitacion;
            this.idHotel = idHotel;
            this.codigoRegimen = codigoRegimen;
        }

    }
}
