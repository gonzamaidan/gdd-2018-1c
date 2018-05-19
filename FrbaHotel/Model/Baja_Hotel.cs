using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Baja_Hotel
    {
        private int idHotel;
        private DateTime fechaInicio;
        private DateTime fechaFin;


        public int getIdHotel()
        {
            return this.idHotel;

        }
        public void setIdHotel(int unIdHotel)
        {
            this.idHotel = unIdHotel;
        }
        public DateTime getFechaInicio()
        {
            return this.fechaInicio;

        }
        public void setFechaInicio(DateTime unaFechaInicio)
        {
            this.fechaInicio = unaFechaInicio;
        }
        public DateTime getFechaFin()
        {
            return this.fechaFin;

        }
        public void setFechaFin(DateTime unaFechaFin)
        {
            this.fechaFin = unaFechaFin;
        }
    }
}
