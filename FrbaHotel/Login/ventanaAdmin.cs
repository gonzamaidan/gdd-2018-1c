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
    }
}
