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

namespace FrbaHotel.AbmHoteles
{
    public partial class BajaHotel : Form
    {
        SqlConnection baseDeDatos;
        DateTime fechaDesde;
        DateTime fechaHasta;
        Int32 idHotel;

        public BajaHotel(Int32 id)
        {
            idHotel = id;
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void dateTimePicker2_DateChanged(object sender, DateRangeEventArgs e)
        {
            fechaHasta = e.End;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechaHasta = dateTimePicker2.Value;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechaDesde = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("La fecha desde no puede ser mayor a la fecha hasta.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                baseDeDatos.Open();
                if (verificarReservas())
                {
                    DialogResult dialogResult = MessageBox.Show("Esta seguro de dar de baja este hotel?", "Baja hotel", MessageBoxButtons.OKCancel);
                    if (dialogResult == DialogResult.OK)
                    {
                        SqlCommand queryInsert = new SqlCommand("INSERT INTO LOS_MAGIOS.BAJA_HOTELES(ID_HOTEL, FECHA_INICIO_BAJA, FECHA_FIN_BAJA) "
                                                     + "VALUES(@idHotel, @fechaInicioBaja, @fechaFinBaja)", baseDeDatos);

                        queryInsert.CommandType = CommandType.StoredProcedure;
                        queryInsert.Parameters.Add(new SqlParameter("@idHotel", idHotel));
                        queryInsert.Parameters.Add(new SqlParameter("@fechaInicioBaja", dateTimePicker1.Value));
                        queryInsert.Parameters.Add(new SqlParameter("@fechaFinBaja", dateTimePicker2.Value));

                        queryInsert.CommandType = CommandType.Text;
                        queryInsert.ExecuteNonQuery();
                        MessageBox.Show("La baja del hotel fue exitosa", "Habitacion Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Hide();
                        BusquedaHotel busqedaHotel = new BusquedaHotel();
                        busqedaHotel.ShowDialog();
                    }
                    else if (dialogResult == DialogResult.Cancel)
                    {
                        //
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            baseDeDatos.Close();
        }

        private Boolean verificarReservas()
        {
            SqlCommand queryDisponibildad;
            String queryStringDisponibilidad = "SELECT * FROM LOS_MAGIOS.RESERVAS A where ((A.FECHA_DESDE <= @fechaDesde AND A.FECHA_HASTA >= @fechaHasta) " +
                                               " OR (A.FECHA_DESDE >=  @fechaDesde AND A.FECHA_HASTA <=  @fechaHasta) " +
                                               " OR (A.FECHA_DESDE <=  @fechaDesde AND (A.FECHA_HASTA <=  @fechaHasta AND A.FECHA_HASTA >=  @fechaDesde)) " +
                                               " OR ((A.FECHA_DESDE >=  @fechaDesde AND A.FECHA_DESDE <=  @fechaHasta) AND A.FECHA_HASTA >=  @fechaHasta)) AND (A.CODIGO_RESERVA IN (SELECT B.CODIGO_RESERVA FROM [GD1C2018].[LOS_MAGIOS].HABITACIONES_POR_RESERVA B WHERE A.CODIGO_RESERVA = B.CODIGO_RESERVA AND B.ID_HOTEL = @IdHotel))";
            queryDisponibildad = new SqlCommand(queryStringDisponibilidad, baseDeDatos);
            queryDisponibildad.Parameters.Add(new SqlParameter("@fechaDesde", dateTimePicker2.Value));
            queryDisponibildad.Parameters.Add(new SqlParameter("@fechaHasta", dateTimePicker1.Value));
            queryDisponibildad.Parameters.Add(new SqlParameter("@IdHotel", idHotel));


            SqlDataAdapter adapter = new SqlDataAdapter(queryDisponibildad);
            DataTable resultados = new DataTable();
            adapter.Fill(resultados);

            if (resultados.Rows.Count > 1)
            {
                MessageBox.Show("El hotel posee una reserva vigente para la fecha seleccionada. No se puede dar de baja.", "Habitacion Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaHotel busqedaHotel = new BusquedaHotel();
            busqedaHotel.ShowDialog();
        }


    }
}
