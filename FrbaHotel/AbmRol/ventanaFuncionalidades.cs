using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class ventanaFuncionalidades : Form
    {
        rolesDeUsuario objRoles = new rolesDeUsuario();
        private int idRol = 0;
        private bool Editar = false;
        public ventanaFuncionalidades()
        {
            InitializeComponent();
        }

        private void ventanaFuncionalidades_Load(object sender, EventArgs e)
        {
            mostrarProductos();
            mostrarFuncionalidades();
        }

        //private void listarRolesParaFuncionalidad()
        //{
        //    rolesDeUsuario objRoles = new rolesDeUsuario();
        //    cmbRol.DataSource = objRoles.listarRolesParaFuncionalidad();
        //    cmbRol.DisplayMember = "NOMBRE";
        //    cmbRol.ValueMember = "ID_ROL";

        //}

        private void mostrarProductos()
        {
            dgvRoles.DataSource = objRoles.listarRolesParaFuncionalidad();
        }

        private void mostrarFuncionalidades()
        {
            dgvFuncionalidades.DataSource = objRoles.listarFuncionalidades();
        }

        public void mostrarFuncionalidadesSegunRol(int unRol)
        {
            dgvFuncionalidadesPorRol.DataSource = objRoles.listarFuncionesSegunRol(unRol);
        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_ROL"].Value.ToString());
                mostrarFuncionalidadesSegunRol(idRol);
            }

            else
            {
                MessageBox.Show("Selecciona una fila");
            }
        }

 
        public void insertarFuncionalidadEnRol(int idRol, int idFuncionalidad)
        {
            objRoles.insertarFuncionalidadEnRol(idRol, idFuncionalidad);
        }

        public void modificarFuncionalidadEnRol(int idFuncionalidad, string descripcionFuncionalidad)
        {
            objRoles.modificarFuncionalidadEnRol(idFuncionalidad,descripcionFuncionalidad);
        }

        public void eliminarFuncionalidadEnRol(int idFuncionalidad)
        {
            objRoles.eliminarFuncionalidadEnRol(idFuncionalidad);
        }
        private void limpiarForm()
        {
            txtFuncionalidad.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                insertarFuncionalidadEnRol(Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_ROL"].Value.ToString()), Convert.ToInt32(dgvFuncionalidades.CurrentRow.Cells["ID_FUNCIONALIDAD"].Value.ToString()));
                MessageBox.Show("Se inserto correctamente");
                mostrarProductos();
                limpiarForm();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al querer insertar: " + error.Message);
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtFuncionalidad.Text != "")
            {
                modificarFuncionalidadEnRol(Convert.ToInt32(dgvFuncionalidades.CurrentRow.Cells["ID_FUNCIONALIDAD"].Value.ToString()), txtFuncionalidad.Text);
                mostrarFuncionalidades();
            }

            else
            {
                MessageBox.Show("ingrese una nueva descripcion");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionalidades.SelectedRows.Count > 0)
            {
               eliminarFuncionalidadEnRol(Convert.ToInt32(dgvFuncionalidades.CurrentRow.Cells["ID_FUNCIONALIDAD"].Value.ToString()));
               mostrarProductos();
               mostrarFuncionalidadesSegunRol(0);
                
            }

            else
            {
                MessageBox.Show("seleccione una funcionalidad a quitar");
            }
        }


    }
}
