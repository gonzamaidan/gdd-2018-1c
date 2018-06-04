using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class GenerarReservas : Form
    {
        SqlConnection baseDeDatos;
        DateTime fechaDesde;
        DateTime fechaHasta;
        public GenerarReservas()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaHasta = e.End;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaDesde = e.End;
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void botonGenerarReserva_Click(object sender, EventArgs e)
        {
            String queryStringDisponibilidad = "SELECT * FROM LOS_MAGIOS.DAR_DISPONIBILIDAD(@FechaDesde, @FechaHasta)";
            try
            {
                baseDeDatos.Open();
                Console.WriteLine(fechaDesde);
                Console.WriteLine(fechaHasta);
                SqlCommand queryDisponibildad = new SqlCommand(queryStringDisponibilidad, baseDeDatos);
                queryDisponibildad.Parameters.Add("@FechaDesde", SqlDbType.Date);
                queryDisponibildad.Parameters.Add("@FechaHasta", SqlDbType.Date);
                queryDisponibildad.Parameters["@FechaDesde"].Value = fechaDesde;
                queryDisponibildad.Parameters["@FechaHasta"].Value = fechaHasta;

                SqlDataAdapter adapter = new SqlDataAdapter(queryDisponibildad);
                DataTable resultados = new DataTable();
                adapter.Fill(resultados);

                dataGridView1.DataSource = resultados;
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baseDeDatos.Close();
            }
        }
    }
}
