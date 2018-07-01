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

namespace FrbaHotel.AbmHabitacion
{
    public partial class ListadoHabitaciones : Form
    {
        Int32 idHotelSeleccionado;
        SqlConnection baseDeDatos;

        public ListadoHabitaciones(Int32 id)
        {
            baseDeDatos = ConexionBD.conectar();
            idHotelSeleccionado = id;
            InitializeComponent();
        }

        private void ListadoHabitaciones_Load(object sender, EventArgs e)
        {
            string consulta = "Select * From LOS_MAGIOS.HABITACIONES where ID_HOTEL = @id";
            SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
            comando2.Parameters.Add(new SqlParameter("@id", idHotelSeleccionado));
            SqlDataAdapter adapter = new SqlDataAdapter(comando2);
            DataTable resultados = new DataTable();
            adapter.Fill(resultados);
            dataGridViewHabitaciones.DataSource = resultados;

        }

        private void buttonNuevoHotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewHabitacion formNewHabitacion = new FormNewHabitacion(this.idHotelSeleccionado);
            formNewHabitacion.ShowDialog();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewHabitaciones.SelectedRows.Count == 1)
            {
                MessageBox.Show("Se pasa a editar la habitacion", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Int32 idHabitacion = Int32.Parse(dataGridViewHabitaciones.SelectedRows[0].Cells[0].Value.ToString());

                this.Hide();
                FormNewHabitacion formNewHabitacion = new FormNewHabitacion(this.idHotelSeleccionado, idHabitacion);
                formNewHabitacion.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewHabitaciones.SelectedRows.Count == 1)
            {
                this.Hide();
                //AbmHoteles.BajaHotel bajaHotel = new AbmHoteles.BajaHotel(Int32.Parse(dataGridViewHabitaciones.SelectedRows[0].Cells[0].Value.ToString()));
                //bajaHotel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
