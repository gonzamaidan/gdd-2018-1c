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
            CargarTabla();
        }

        private void CargarTabla(){
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
                Int32 idHabitacion = Int32.Parse(dataGridViewHabitaciones.SelectedRows[0].Cells[1].Value.ToString());

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
            baseDeDatos.Open();

            if (this.dataGridViewHabitaciones.SelectedRows.Count == 1)
            {
                if ((Boolean)(dataGridViewHabitaciones.SelectedRows[0].Cells[5].Value) == true)
                { 
                    SqlCommand queryInsert = new SqlCommand("UPDATE LOS_MAGIOS.HABITACIONES " +
                                                            "SET HABILITADO = 0 Where ID_HOTEL = @idHotel and NUMERO_HABITACION = @idHabitacion", baseDeDatos);
                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@idHabitacion", Int32.Parse(dataGridViewHabitaciones.SelectedRows[0].Cells[1].Value.ToString())));
                    queryInsert.Parameters.Add(new SqlParameter("@idHotel", idHotelSeleccionado));
                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();
                    CargarTabla();
                    MessageBox.Show("La Habitacion se dio de baja correctamente", "Habitacion dada de baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Habitacion ya se encuentra dada de baja", "Habitacion dada de baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Debe seleccionar una habitacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baseDeDatos.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AbmHoteles.BusquedaHotel formHotel = new AbmHoteles.BusquedaHotel();
            formHotel.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baseDeDatos.Open();
            if (this.dataGridViewHabitaciones.SelectedRows.Count == 1)
            {
                if ((Boolean)(dataGridViewHabitaciones.SelectedRows[0].Cells[5].Value) == false)
                {
                    SqlCommand queryInsert = new SqlCommand("UPDATE LOS_MAGIOS.HABITACIONES " +
                                                            "SET HABILITADO = 1 Where ID_HOTEL = @idHotel and NUMERO_HABITACION = @idHabitacion", baseDeDatos);
                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@idHabitacion", Int32.Parse(dataGridViewHabitaciones.SelectedRows[0].Cells[1].Value.ToString())));
                    queryInsert.Parameters.Add(new SqlParameter("@idHotel", idHotelSeleccionado));
                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();
                    CargarTabla();
                    MessageBox.Show("La Habitacion se habilito correctamente", "Habitacion habilitada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Habitacion ya se encuentra habilitada", "Habitacion dada de baja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una habitacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baseDeDatos.Close();
        }
    }
}
