using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.AbmUsuario
{
    class Hotel
    {

        public int IdHotel;
        public String NombreHotel;
        
        public Hotel(int idHotel, String nombreHotel)
        {
            this.IdHotel = idHotel;
            this.NombreHotel = nombreHotel;
        }

        public String getNombreHotel()
        {
            return NombreHotel;
        }
        public int getIdHotel()
        {
            return IdHotel;
        }

    }
}
