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
            cmbListaRoles.DataSource = objRoles.listarRoles(unUsuario);
            cmbListaRoles.DisplayMember = "NOMBRE";
            cmbListaRoles.ValueMember = "ID_ROL";

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Program.sesion.setRol(cmbListaRoles.Text);
            Program.sesion.setIdRol((Int32)cmbListaRoles.SelectedValue);
           
            ventanaAdmin nuevaVentanaAdmin = new ventanaAdmin("A");
            //COMO HAGO QUE CARGUE LOS BOTONES SEGUN EL ROL????????
            //LA IDEA ES PASAR EN EL CONSTRUCTOR PARA QUE SE CARGUE, ADEMAS DEL NOMBRE DE HOTEL
            this.Hide();
            this.Close();
            
            nuevaVentanaAdmin.Show();
           
        }

    }
}
