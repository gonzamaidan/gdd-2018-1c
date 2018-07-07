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
        public ventanaAdmin()
        {
            InitializeComponent();
            listadoClientesBtn.Enabled = Program.sesion.getFuncionalidades().Contains(1);
            listadoHotelesBtn.Enabled = Program.sesion.getFuncionalidades().Contains(2);
            btnListadoEstadistico.Enabled = Program.sesion.getFuncionalidades().Contains(1);
            btnListadoEstadistico.Enabled = Program.sesion.getFuncionalidades().Contains(2);
            btnListadoRoles.Enabled = Program.sesion.getFuncionalidades().Contains(1);
            btnGenerarReserva.Enabled = Program.sesion.getFuncionalidades().Contains(2);
            btnModificarReserva.Enabled = Program.sesion.getFuncionalidades().Contains(2);
            btnCancelarReserva.Enabled = Program.sesion.getFuncionalidades().Contains(2);
            btnRegistrarEstadia.Enabled = Program.sesion.getFuncionalidades().Contains(2);
            btnRegistrarConsumible.Enabled = Program.sesion.getFuncionalidades().Contains(2);
            btnFacturarEstadia.Enabled = Program.sesion.getFuncionalidades().Contains(2);

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
    }
}
