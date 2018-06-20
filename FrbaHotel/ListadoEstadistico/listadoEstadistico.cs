using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaHotel.Clases_varias;

namespace FrbaHotel.ListadoEstadistico
{
    public partial class listadoEstadistico : Form
    {
        listados objLista = new listados();
        public listadoEstadistico()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listadoEstadistico_Load(object sender, EventArgs e)
        {
 
        }

        private void mostrarListas()
        {
            if(cmbListado.Text == "Hoteles con mayor cantidad de reservas canceladas")
            {
                dgvListas.DataSource = objLista.ListarHotelesConMayorCantidadDeReservasCanceladas(txtAnio.Text,Convert.ToInt32(cmbTrimestre.Text));
            }

            if(cmbListado.Text == "Hoteles con mayor cantidad de consumibles facturados")
            {
                dgvListas.DataSource = objLista.ListarHotelesConMayorCantidadDeConsumiblesFacturados(txtAnio.Text, Convert.ToInt32(cmbTrimestre.Text));
            }

            if(cmbListado.Text == "Hoteles con mayor cantidad de días fuera de servicio")
            {
                dgvListas.DataSource = objLista.ListarHotelesConMayorCantidadDeDiasFueraDeServicio(txtAnio.Text, Convert.ToInt32(cmbTrimestre.Text));
            }

            if(cmbListado.Text == "Habitaciones con mayor cantidad de días y veces que fueron ocupadas")
            {
                dgvListas.DataSource = objLista.ListarHabitacionesCon(txtAnio.Text, Convert.ToInt32(cmbTrimestre.Text));
            }

            if(cmbListado.Text == "Cliente con mayor cantidad de punto")
            {
                dgvListas.DataSource = objLista.ListarClientesConMayorCantidadDePuntos(txtAnio.Text, Convert.ToInt32(cmbTrimestre.Text));
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            mostrarListas();
        }
    }
}

/*
Hoteles con mayor cantidad de reservas canceladas
Hoteles con mayor cantidad de consumibles facturados
Hoteles con mayor cantidad de días fuera de servicio
Habitaciones con mayor cantidad de días y veces que fueron ocupadas
Cliente con mayor cantidad de punto
*/