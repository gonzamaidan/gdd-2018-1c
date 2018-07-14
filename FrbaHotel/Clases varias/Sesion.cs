using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel.Clases_varias
{
    class Sesion
    {
        private String usuario;
        private String rol;
        private List<Int32> funcionalidades = new List<Int32>();
        private SqlConnection baseDeDatos;
        private Int32 idRol;
        private Int32 idHotel;

        public Sesion(SqlConnection baseDeDatos)
        {
            this.baseDeDatos = baseDeDatos;
        }

        public String getUsuario()
        {
            return usuario;
        }
        public void setUsuario(String usuario)
        {
            this.usuario = usuario;
        }
        public String getRol()
        {
            return rol;
        }
        public void setRol(String rol)
        {
            this.rol = rol;
        }

        public void setIdRol(Int32 idRol)
        {
            this.idRol = idRol;
           
               
                SqlCommand getRoles = new SqlCommand("SELECT ID_FUNCIONALIDAD FROM LOS_MAGIOS.FUNCIONALIDADES_POR_ROL WHERE ID_ROL = @IdRol", baseDeDatos);
                getRoles.Parameters.Add("@IdRol", SqlDbType.Int);
                getRoles.Parameters["@IdRol"].Value = this.idRol;

                SqlDataAdapter sda = new SqlDataAdapter(getRoles);    
                DataTable dt = new DataTable();
                sda.Fill(dt);
                foreach (DataRow item in dt.Rows)
                {
                    this.funcionalidades.Add(Int32.Parse(item[0].ToString()));
                }

            

        } 

        public List<Int32> getFuncionalidades()
        {
            return funcionalidades;
        }
        public void setFuncionalidades(List<Int32> funcionalidades)
        {
            this.funcionalidades = funcionalidades;
        }

        public void setIdHotel(Int32 idHotel)
        {
            this.idHotel = idHotel;
        }
        public Int32 getIdHotel()
        {
            return this.idHotel;
        }



    }
}
