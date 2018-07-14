using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaHotel.Login
{
    public partial class listadoDeRol : Form
    {
        string unUsuario;
        string unHotel;
      
        public listadoDeRol(string usuario)
        {
            unUsuario = usuario;
            InitializeComponent();
        }

        private void listadoDeRol_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void ListarRoles()
        {

            rolesDeUsuario objRoles = new rolesDeUsuario();
            dgvRolesDeUsuario.DataSource = objRoles.listarRoles(unUsuario);


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvRolesDeUsuario.SelectedRows.Count > 0)
            {

                //Program.sesion.setRol(cmbListaRoles.Text);
                Program.sesion.setRol(dgvRolesDeUsuario.CurrentRow.Cells["NOMBRE"].Value.ToString());
                //Program.sesion.setIdRol((Int32)cmbListaRoles.SelectedValue);
                Program.sesion.setIdRol((Int32)dgvRolesDeUsuario.CurrentRow.Cells["ID_ROL"].Value);
                unHotel = dgvRolesDeUsuario.CurrentRow.Cells["NOMBRE_HOTEL"].Value.ToString();
                ventanaAdmin nuevaVentanaAdmin = new ventanaAdmin(unHotel);
                this.Hide();
                this.Close();

                nuevaVentanaAdmin.Show();

                //idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_ROL"].Value.ToString());
                //mostrarFuncionalidadesSegunRol(idRol);
            }

            else
            {
                MessageBox.Show("Selecciona una fila");
            }  
        }



        private void dgvRolesDeUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
