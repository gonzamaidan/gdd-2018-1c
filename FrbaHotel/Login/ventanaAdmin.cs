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
    public partial class ventanaAdmin : Form
    {
        private static Int32 ABM_CLIENTES = 1;
        private static Int32 ABM_HOTELES = 2;
        private static Int32 ABM_ROL = 3;
        private static Int32 ABM_USUARIO = 4;
        private static Int32 CANCELAR_RESERVA = 5;
        private static Int32 GENERAR_RESERVA = 6;
        private static Int32 MODIFICAR_RESERVA = 7;
        private static Int32 LISTADO_ESTADISTICO = 8;
        private static Int32 REGISTRAR_CONSUMIBLE = 9;
        private static Int32 REGISTRAR_ESTADIA = 10;
        private static Int32 FACTURAR_ESTADIA = 11;
        public ventanaAdmin(string unHotelLogueado)
        {
            InitializeComponent();
            listadoClientesBtn.Enabled = Program.sesion.getFuncionalidades().Contains(ABM_CLIENTES);
            listadoHotelesBtn.Enabled = Program.sesion.getFuncionalidades().Contains(ABM_HOTELES);
            btnListadoEstadistico.Enabled = Program.sesion.getFuncionalidades().Contains(LISTADO_ESTADISTICO);
            btnListadoRoles.Enabled = Program.sesion.getFuncionalidades().Contains(ABM_ROL);

            btnGenerarReserva.Enabled = Program.sesion.getFuncionalidades().Contains(GENERAR_RESERVA);
            btnModificarReserva.Enabled = Program.sesion.getFuncionalidades().Contains(MODIFICAR_RESERVA);
            btnCancelarReserva.Enabled = Program.sesion.getFuncionalidades().Contains(CANCELAR_RESERVA);

            btnRegistrarEstadia.Enabled = Program.sesion.getFuncionalidades().Contains(REGISTRAR_ESTADIA);
            btnRegistrarConsumible.Enabled = Program.sesion.getFuncionalidades().Contains(REGISTRAR_CONSUMIBLE);
            btnFacturarEstadia.Enabled = Program.sesion.getFuncionalidades().Contains(FACTURAR_ESTADIA);
            txtBoxHotelLogueado.Text = unHotelLogueado;
        }

        private void listadoCliente_Click(object sender, EventArgs e)
        {
            AbmCliente.ListadoClientes ventana  = new AbmCliente.ListadoClientes();
            ventana.Show();
        }

        private void listadoHotelesBtn_Click(object sender, EventArgs e)
        {
            AbmHoteles.BusquedaHotel ventana = new AbmHoteles.BusquedaHotel();
            ventana.Show();
        }

        private void ventanaAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.GenerarReservas ventana = new GenerarModificacionReserva.GenerarReservas();
            ventana.Show();
        }

        private void ventanaAdmin_Load_1(object sender, EventArgs e)
        {

        }

        private void btnListadoEstadistico_Click(object sender, EventArgs e)
        {
            FrbaHotel.ListadoEstadistico.listadoEstadistico ventana = new FrbaHotel.ListadoEstadistico.listadoEstadistico();
            ventana.Show();
        }

        private void btnListadoRoles_Click(object sender, EventArgs e)
        {
            AbmRol.ventanaRoles ventana = new AbmRol.ventanaRoles();
            ventana.Show();
        }

        private void btnListadoHabitacion_Click(object sender, EventArgs e)
        {
            //le hardcodie un entero
            //Esto se accede por mediod e la pantalla de hoteles
            AbmHabitacion.ListadoHabitaciones ventana = new AbmHabitacion.ListadoHabitaciones(1);
            ventana.Show();
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            GenerarModificacionReserva.ModificarReserva ventana = new GenerarModificacionReserva.ModificarReserva();
            ventana.Show();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            CancelarReserva.CancelarReserva ventana = new CancelarReserva.CancelarReserva();
            ventana.Show();
        }

        private void btnRegistrarEstadia_Click(object sender, EventArgs e)
        {
            RegistrarEstadia.RegistrarEstadia ventana = new RegistrarEstadia.RegistrarEstadia();
            ventana.Show();
        }

        private void btnListadoUsuarios_Click(object sender, EventArgs e)
        {
            AbmUsuario.BuscadorForm ventana = new AbmUsuario.BuscadorForm();
            ventana.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnRegistrarConsumible_Click(object sender, EventArgs e)
        {
           // RegistrarConsumible.CodigoReserva ventana = new RegistrarConsumible.CodigoReserva();
           // ventana.Show();
        }
    }
}
