using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Model
{
    class Rol
    {
        private string nombre;
        private bool estado;
        private List<Funcionalidad> listaFuncionalidades;

        public void setNombre(string unNombre)
        {
            this.nombre = unNombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public void setEstado(bool unEstado)
        {
            this.estado = unEstado;
        }
        public bool getEstado()
        {
            return this.estado;
        }
        public List<Funcionalidad> getListaFuncionalidades()
        {
            return this.listaFuncionalidades;
        }
        public void setListaFuncionalidades(List<Funcionalidad> funcionalidades)
        {
            this.listaFuncionalidades = funcionalidades;
        }

        


    }
}
