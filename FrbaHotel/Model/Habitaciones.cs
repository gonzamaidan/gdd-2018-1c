using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    public class Habitaciones
    {
        private int piso;
        private bool estado;
        private string ubicacion;
        private int codigoTipoHabitacion;

        public int getPiso()
        {
            return this.piso;

        }
        public void setPiso(int unPiso)
        {
            this.piso = unPiso;
        }
        public bool getEstado()
        {
            return this.estado;

        }
        public void setEstado(bool unEstado)
        {
            this.estado = unEstado;
        }
        public string getUbicacion()
        {
            return this.ubicacion;

        }
        public void setUbicacion(string unaUbicacion)
        {
            this.ubicacion = unaUbicacion;
        }
        public int getCodigoTipoHabitacion()
        {
            return this.codigoTipoHabitacion;

        }
        public void setCodigoTipoHabitacion(int unCodigoTipoHabitacion)
        {
            this.codigoTipoHabitacion = unCodigoTipoHabitacion;
        }
    }
}
