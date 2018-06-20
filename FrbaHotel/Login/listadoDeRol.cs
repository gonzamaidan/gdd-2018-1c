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
        public listadoDeRol()
        {
            InitializeComponent();
        }

        private void listadoDeRol_Load(object sender, EventArgs e)
        {
            ListarRoles();
        }

        private void ListarRoles()
        {

            rolesDeUsuario objRoles = new rolesDeUsuario();
            cmbListaRoles.DataSource = objRoles.listarRoles();
            cmbListaRoles.DisplayMember = "NOMBRE";
            cmbListaRoles.ValueMember = "ID_ROL";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(cmbListaRoles.Text == "ADMINISTRADOR" || cmbListaRoles.Text == "administrador")
            {
                ventanaAdmin nuevaVentanaAdmin = new ventanaAdmin();
                this.Hide();
                nuevaVentanaAdmin.Show();
            }

            if (cmbListaRoles.Text == "RECEPCIONISTA" || cmbListaRoles.Text == "recepcionista")
            {
                ventanaRecepcionista nuevaVentanaRecepcionista = new ventanaRecepcionista();
                this.Hide();
                nuevaVentanaRecepcionista.Show();
            }
            
        }

    }
}
