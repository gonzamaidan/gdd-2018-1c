using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel.AbmRol
{
    public partial class ventanaRoles : Form
    {
        rolesDeUsuario objRoles = new rolesDeUsuario();
        private int idRol = 0;
        private bool Editar = false;

        public ventanaRoles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void insertarRol(string descripcion, string estado)
        {
            int unEstado;
            unEstado = (cmbEstado.Text == "Habilitado") ? 1 : 0;
            objRoles.insertarRol(descripcion, unEstado);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    if (!(string.IsNullOrEmpty(txtNombreRol.Text)))
                    {
                        insertarRol(txtNombreRol.Text, cmbEstado.Text);
                        MessageBox.Show("Se inserto correctamente");
                        mostrarProductos();
                        limpiarForm();
                    }
                    else
                    {
                        MessageBox.Show("El nombre del Rol se encuentra vacio");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al querer insertar: " + error.Message);
                }
                
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    if (!(string.IsNullOrEmpty(txtNombreRol.Text)))
                    {
                        ModificarRol(idRol, txtNombreRol.Text, cmbEstado.Text);
                        MessageBox.Show("Se inserto correctamente");
                        mostrarProductos();
                        limpiarForm();
                        Editar = false;
                    }
                    else
                    {
                        MessageBox.Show("El nombre del Rol se encuentra vacio");
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error al querer insertar: " + error.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ventanaRoles_Load(object sender, EventArgs e)
        {

            mostrarProductos();
        }

        private void mostrarProductos()
        {
            dgvRoles.DataSource = objRoles.listarRoles();
        }

        public void ModificarRol(int id, string descripcion, string estado)
        {
            int unEstado;
            unEstado = (cmbEstado.Text == "Habilitado") ? 1 : 0;
            objRoles.modificarRol(id, descripcion, unEstado);
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                try
                {
                    Editar = true;
                    txtNombreRol.Text = dgvRoles.CurrentRow.Cells["NOMBRE"].Value.ToString();
                    cmbEstado.Text = dgvRoles.CurrentRow.Cells["ESTADO"].Value.ToString();
                    idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_ROL"].Value.ToString());
                 /*   ModificarRol(Convert.ToInt32(txtIdRol.Text), txtNombreRol.Text, cmbEstado.Text);*/
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Seleccione una fila a editar");
                }
            }

        }

        private void limpiarForm()
        {
            txtNombreRol.Clear();
            cmbEstado.Text = "";
        }

        public void eliminarRol(int id)
        {
            objRoles.eliminarRol(id);
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells["ID_ROL"].Value.ToString());
                objRoles.eliminarRol(idRol);
                MessageBox.Show("Eliminado con exito");
                mostrarProductos();
            }
            else
            {
                MessageBox.Show("Seleccione una fila a eliminar");
            }
            
        }

        private void btnFuncionalidades_Click(object sender, EventArgs e)
        {
            ventanaFuncionalidades nuevaVentanaFuncionalidades = new ventanaFuncionalidades();
            this.Hide();
            nuevaVentanaFuncionalidades.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
