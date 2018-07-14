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
    public partial class ventanaPrincipal : Form
    {
        public ventanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLogin ventanaLogin = new FormLogin();
            this.Hide();
            ventanaLogin.Show();
        }

        private void btnGenerarReserva_Click(object sender, EventArgs e)
        {
            Program.sesion.setUsuario("guest");
            Program.sesion.setRol("GUEST");
            Program.sesion.setIdRol(3);
            GenerarModificacionReserva.GenerarReservas ventana = new GenerarModificacionReserva.GenerarReservas();
            ventana.Show();
           
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            Program.sesion.setUsuario("guest");
            Program.sesion.setRol("GUEST");
            Program.sesion.setIdRol(3);
            GenerarModificacionReserva.ModificarReserva ventana = new GenerarModificacionReserva.ModificarReserva();
            ventana.Show();

        }

        private void cancelarReserva_Click(object sender, EventArgs e)
        {
            Program.sesion.setUsuario("guest");
            Program.sesion.setRol("GUEST");
            Program.sesion.setIdRol(3);
            CancelarReserva.CancelarReserva ventana = new CancelarReserva.CancelarReserva();
            ventana.Show();
        }
    }
}
