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
        DateTime fechaDesde = Program.fechaHoy;
        DateTime fechaHasta = Program.fechaHoy;
        DateTime fechaDesdeSeleccionada;
        DateTime fechaHastaSeleccionada;
        int codigoRegimen = -1;
        int cantidadPersonas = 1;
        bool conRegimen = false;
        bool flagModificacionReserva = false;
        int codigoReservaModificacion = -1;
        public GenerarReservas()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }
        public GenerarReservas(int codigoReserva)
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
            codigoReservaModificacion = codigoReserva;
            flagModificacionReserva = true;
            this.generarReservaButton.Text = "Modificar";
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
            // TODO: This line of code loads data into the 'gD1C2018DataSet.REGIMENES' table. You can move, or remove it, as needed.
            this.rEGIMENESTableAdapter.Fill(this.gD1C2018DataSet.REGIMENES);
            this.numericUpDown1_ValueChanged(sender, e);
            this.checkBox1_CheckedChanged(sender, e);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.calendarDesde.TodayDate = Program.fechaHoy;
            this.calendarDesde.SelectionStart = Program.fechaHoy;
            this.calendarDesde.SelectionEnd = Program.fechaHoy;

            this.calendarHasta.TodayDate = Program.fechaHoy;
            this.calendarHasta.SelectionStart = Program.fechaHoy;
            this.calendarHasta.SelectionEnd = Program.fechaHoy;
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

        private void botonBuscarDisponibilidad_Click(object sender, EventArgs e)
        {
            this.conRegimen = this.checkBox1.Checked;
            this.cantidadPersonas = (int)this.numericUpDown1.Value;
            this.fechaDesdeSeleccionada = fechaDesde.Date;
            this.fechaHastaSeleccionada = fechaHasta.Date;
            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha de inicio de la reserva no puede ser anterior a la fecha final de la reserva", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (fechaDesde < Program.fechaHoy)
            {
                MessageBox.Show("La reserva no puede ser anterior al dia de hoy", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else try
                {
                    baseDeDatos.Open();
                    SqlCommand queryDisponibildad;
                    Console.WriteLine(this.conRegimen);
                    if (this.conRegimen)
                    {
                        this.codigoRegimen = (int)this.regimenesComboBox.SelectedValue;
                        String queryStringDisponibilidad = "SELECT * FROM LOS_MAGIOS.DAR_DISPONIBILIDAD_CON_REGIMEN(@FechaDesde, @FechaHasta,@CodigoRegimen, @CantidadPersonas)";
                        queryDisponibildad = new SqlCommand(queryStringDisponibilidad, baseDeDatos);
                        queryDisponibildad.Parameters.Add("@FechaDesde", SqlDbType.Date);
                        queryDisponibildad.Parameters.Add("@FechaHasta", SqlDbType.Date);
                        queryDisponibildad.Parameters.Add("@CodigoRegimen", SqlDbType.Int);
                        queryDisponibildad.Parameters.Add("@CantidadPersonas", SqlDbType.Int);
                        queryDisponibildad.Parameters["@FechaDesde"].Value = fechaDesde;
                        queryDisponibildad.Parameters["@FechaHasta"].Value = fechaHasta;
                        queryDisponibildad.Parameters["@CodigoRegimen"].Value = codigoRegimen;
                        queryDisponibildad.Parameters["@CantidadPersonas"].Value = this.cantidadPersonas;
                    }
                    else
                    {
                        String queryStringDisponibilidad = "SELECT * FROM LOS_MAGIOS.DAR_DISPONIBILIDAD_SIN_REGIMEN(@FechaDesde, @FechaHasta, @CantidadPersonas)";
                        queryDisponibildad = new SqlCommand(queryStringDisponibilidad, baseDeDatos);
                        queryDisponibildad.Parameters.Add("@FechaDesde", SqlDbType.Date);
                        queryDisponibildad.Parameters.Add("@FechaHasta", SqlDbType.Date);
                        queryDisponibildad.Parameters.Add("@CantidadPersonas", SqlDbType.Int);
                        queryDisponibildad.Parameters["@FechaDesde"].Value = fechaDesde;
                        queryDisponibildad.Parameters["@FechaHasta"].Value = fechaHasta;
                        queryDisponibildad.Parameters["@CantidadPersonas"].Value = this.cantidadPersonas;
                    }
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

        private void regimenesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.regimenesComboBox.SelectedValue != null)
            {
                try
                {
                    this.baseDeDatos.Open();
                    SqlCommand queryDisponibildad = new SqlCommand("SELECT PRECIO_DOLARES FROM LOS_MAGIOS.REGIMENES WHERE CODIGO_REGIMEN = @CodigoRegimen", baseDeDatos);
                    queryDisponibildad.Parameters.Add("@CodigoRegimen", SqlDbType.Int);
                    queryDisponibildad.Parameters["@CodigoRegimen"].Value = (int)this.regimenesComboBox.SelectedValue;
                    this.textBox2.Text = "U$S " + queryDisponibildad.ExecuteScalar();


                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.StackTrace);
                    MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.baseDeDatos.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.regimenesComboBox.Enabled = this.checkBox1.Checked;
            this.regimenesComboBox_SelectedIndexChanged(sender, e);
            this.textBox2.Visible = this.checkBox1.Checked;
            this.label2.Visible = this.checkBox1.Checked;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             
            try
            {
                this.baseDeDatos.Open();

                SqlCommand queryStringTipoHabitacion = new SqlCommand("SELECT DESCRIPCION_TIPO_HABITACION FROM LOS_MAGIOS.TIPOS_HABITACION WHERE CANTIDAD_PERSONAS = @CantidadPersonas", baseDeDatos);
                queryStringTipoHabitacion.Parameters.Add("@CantidadPersonas", SqlDbType.Int);
                queryStringTipoHabitacion.Parameters["@CantidadPersonas"].Value = (int) this.numericUpDown1.Value;
                String tipoHabitacion = (String)queryStringTipoHabitacion.ExecuteScalar();
                this.textBox1.Text = tipoHabitacion;


            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.baseDeDatos.Close();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void generarReservaButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                List<HabitacionPK> habitaciones = new List<HabitacionPK>();

                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    int idHotel = Int32.Parse(dataGridView1.SelectedRows[i].Cells[0].Value.ToString());
                    int nroHabitacion = Int32.Parse(dataGridView1.SelectedRows[i].Cells[2].Value.ToString());
                    if (!this.conRegimen)
                    {
                        this.codigoRegimen = Int32.Parse(dataGridView1.SelectedRows[i].Cells[7].Value.ToString());
                    }
                    habitaciones.Add(new HabitacionPK(nroHabitacion, idHotel,codigoRegimen));
                }
                if (!habitaciones.All(habitacion => habitacion.codigoRegimen == this.codigoRegimen))
                {
                    MessageBox.Show("Todas las habitaciones seleccionadas deben pertenecer al mismo regimen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (habitaciones.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos una habitacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    int idClienteSeleccionado = -1;

                    //TODO: Este usuario deberia sacarlo del login
                    String usuario = "admin";
                    if(!flagModificacionReserva)
                        while (idClienteSeleccionado == -1)
                            {
                                AbmCliente.ListadoClientes busquedaCliente = new AbmCliente.ListadoClientes();
                                DialogResult result = busquedaCliente.ShowDialog();

                                /*if (busquedaCliente.idClienteSeleccionado != -1)
                                    idClienteSeleccionado = busquedaCliente.idClienteSeleccionado;
                                else
                                {

                                    MessageBox.Show("Debe seleccionar un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }*/
                            }


                    if (!this.conRegimen)
                    {
                        this.codigoRegimen = Int32.Parse(dataGridView1.SelectedCells[7].Value.ToString());
                    }

                    try
                    {
                        baseDeDatos.Open();
                        if (!flagModificacionReserva)
                        {
                            int codigoReserva = ingresarReserva();
                            List<Int32> clientes = new List<Int32>();
                            clientes.Add(idClienteSeleccionado);
                            ingresarClientePorReserva(clientes, codigoReserva);
                            ingresarHabitacionPorReserva(habitaciones, codigoReserva);
                            ingresarRegistroReserva(usuario, codigoReserva, "GENERACION");
                            MessageBox.Show("Reserva generada con el codigo " + codigoReserva, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {   
                            String estadoReserva = "MODIFICADA";
                            updateFechaReserva();
                            updateEstadoReserva(estadoReserva, this.codigoReservaModificacion);
                            eliminarHabitaciones(this.codigoReservaModificacion);
                            ingresarHabitacionPorReserva(habitaciones, this.codigoReservaModificacion);
                            ingresarRegistroReserva(usuario, codigoReservaModificacion, "MODIFICACION");
                            this.DialogResult = DialogResult.OK;
                            this.Hide();
                            this.Close();
                        }
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine(exc.StackTrace);
                        MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.baseDeDatos.Close();
                    }
                    this.botonBuscarDisponibilidad_Click(sender, e);
                    //this.Hide();
                    //this.Close();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos una habitacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateFechaReserva()
        {
            SqlCommand updateFechaReservaCmd = new SqlCommand("UPDATE LOS_MAGIOS.RESERVAS SET FECHA_DESDE = @FechaDesde, FECHA_HASTA = @FechaHasta "
                                                              + " WHERE CODIGO_RESERVA = @CodigoReserva", baseDeDatos);
            updateFechaReservaCmd.Parameters.Add("@FechaDesde", SqlDbType.Date);
            updateFechaReservaCmd.Parameters.Add("@FechaHasta", SqlDbType.Date);
            updateFechaReservaCmd.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            updateFechaReservaCmd.Parameters["@FechaDesde"].Value = fechaDesdeSeleccionada;
            updateFechaReservaCmd.Parameters["@FechaHasta"].Value = fechaHastaSeleccionada;
            updateFechaReservaCmd.Parameters["@CodigoReserva"].Value = codigoReservaModificacion;
            updateFechaReservaCmd.ExecuteNonQuery();
        }

        private void eliminarHabitaciones(int codigoReserva)
        {
            SqlCommand eliminarHabitacionesCmd = new SqlCommand("DELETE FROM LOS_MAGIOS.HABITACIONES_POR_RESERVA WHERE CODIGO_RESERVA = @CodigoReserva", baseDeDatos);
            eliminarHabitacionesCmd.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            eliminarHabitacionesCmd.Parameters["@CodigoReserva"].Value = codigoReserva;
            eliminarHabitacionesCmd.ExecuteNonQuery();
        }

        private void updateEstadoReserva(String estadoReserva, int codigoReserva)
        {
            SqlCommand updateEstadoReserva = new SqlCommand("UPDATE LOS_MAGIOS.RESERVAS SET ID_ESTADO_RESERVA = (SELECT ID_ESTADO_RESERVA FROM LOS_MAGIOS.ESTADOS_RESERVA WHERE DESCRIPCION_ESTADO_RESERVA = @EstadoReserva) " + 
                                                            "WHERE CODIGO_RESERVA = @CodigoReserva", baseDeDatos);
            updateEstadoReserva.Parameters.Add("@EstadoReserva", SqlDbType.VarChar);
            updateEstadoReserva.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            updateEstadoReserva.Parameters["@EstadoReserva"].Value = estadoReserva;
            updateEstadoReserva.Parameters["@CodigoReserva"].Value = codigoReserva;
            updateEstadoReserva.ExecuteNonQuery();
        }

        private void ingresarRegistroReserva(String usuario, int codigoReserva, String accion)
        {

            SqlCommand ingresarRegistroReservaCmd = new SqlCommand("INSERT INTO LOS_MAGIOS.REGISTRO_RESERVAS(CODIGO_RESERVA, FECHA,	ACCION, USUARIO) " +
                                                                    "VALUES (@CodigoReserva, @FechaHoy, @Accion, @Usuario)", baseDeDatos);
            ingresarRegistroReservaCmd.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            ingresarRegistroReservaCmd.Parameters.Add("@FechaHoy", SqlDbType.Date);
            ingresarRegistroReservaCmd.Parameters["@FechaHoy"].Value = Program.fechaHoy;

            ingresarRegistroReservaCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            ingresarRegistroReservaCmd.Parameters.Add("@Accion", SqlDbType.VarChar);
            ingresarRegistroReservaCmd.Parameters["@CodigoReserva"].Value = codigoReserva;
            ingresarRegistroReservaCmd.Parameters["@Usuario"].Value = usuario;
            ingresarRegistroReservaCmd.Parameters["@Accion"].Value = accion;
            ingresarRegistroReservaCmd.ExecuteNonQuery();
            Console.WriteLine("Registro de reserva generado: " + codigoReserva + "|" + accion);
        }

        private void ingresarHabitacionPorReserva(List<HabitacionPK> habitaciones, int codigoReserva)
        {
            StringBuilder builder = new StringBuilder("INSERT INTO LOS_MAGIOS.HABITACIONES_POR_RESERVA(CODIGO_RESERVA, ID_HOTEL, NUMERO_HABITACION) VALUES");
            SqlCommand ingresarHabitacionPorReserva = new SqlCommand();
            for (int i = 0; i < habitaciones.Count; i++)
            {
                builder.Append("(@CodigoReserva, @IdHotel" + i +", @NroHabitacion"+ i+"), ");
                ingresarHabitacionPorReserva.Parameters.Add("@IdHotel"+i, SqlDbType.Int);
                ingresarHabitacionPorReserva.Parameters.Add("@NroHabitacion"+i, SqlDbType.Int);
                ingresarHabitacionPorReserva.Parameters["@IdHotel"+i].Value = habitaciones[i].idHotel;
                ingresarHabitacionPorReserva.Parameters["@NroHabitacion"+i].Value = habitaciones[i].nroHabitacion;
            }
            builder.Remove(builder.Length - 2, 2);

            ingresarHabitacionPorReserva.CommandText = builder.ToString();
            ingresarHabitacionPorReserva.Connection = baseDeDatos;
            ingresarHabitacionPorReserva.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            ingresarHabitacionPorReserva.Parameters["@CodigoReserva"].Value =  codigoReserva;
            
            ingresarHabitacionPorReserva.ExecuteNonQuery();
            Console.WriteLine("Habitacion por reserva generada");
        }

        private int ingresarReserva()
        {
            String queryCodigoReserva = "SELECT MAX(CODIGO_RESERVA) + 1 FROM LOS_MAGIOS.RESERVAS";
            String ingresarReserva = "INSERT INTO LOS_MAGIOS.RESERVAS(CODIGO_RESERVA, FECHA_RESERVA, FECHA_DESDE, FECHA_HASTA, ID_ESTADO_RESERVA, CODIGO_REGIMEN) "
                                    + " VALUES (@CodigoReserva, @FechaHoy, @FechaDesde, @FechaHasta, 1, @CodigoRegimen)";

            int codigoReserva = (int)(new SqlCommand(queryCodigoReserva, baseDeDatos).ExecuteScalar());
            SqlCommand comandIngresarReserva = new SqlCommand(ingresarReserva, baseDeDatos);
            comandIngresarReserva.Parameters.Add("@FechaDesde", SqlDbType.Date);
            comandIngresarReserva.Parameters.Add("@FechaHasta", SqlDbType.Date);
            comandIngresarReserva.Parameters.Add("@FechaHoy", SqlDbType.Date);
            comandIngresarReserva.Parameters["@FechaHoy"].Value = Program.fechaHoy;
            comandIngresarReserva.Parameters.Add("@CodigoRegimen", SqlDbType.Int);
            comandIngresarReserva.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            comandIngresarReserva.Parameters["@FechaDesde"].Value = fechaDesdeSeleccionada;
            comandIngresarReserva.Parameters["@FechaHasta"].Value = fechaHastaSeleccionada;
            comandIngresarReserva.Parameters["@CodigoRegimen"].Value = codigoRegimen;
            comandIngresarReserva.Parameters["@CodigoReserva"].Value = codigoReserva;
            comandIngresarReserva.ExecuteNonQuery();
            Console.WriteLine("Reserva generada: " + codigoReserva);
            return codigoReserva;
        }

        private void ingresarClientePorReserva(List<Int32> clientes, int codigoReserva)
        {

            StringBuilder clientesPorReservasQueryBuilder = new StringBuilder("INSERT INTO LOS_MAGIOS.CLIENTES_POR_RESERVA(CODIGO_CLIENTE, CODIGO_RESERVA) VALUES ");
            SqlCommand clientesPorReservasCommand = new SqlCommand();
            foreach (int idCliente in clientes)
            {
                clientesPorReservasQueryBuilder.Append(" (@CodigoCliente" + idCliente + ", @CodigoReserva), ");
                clientesPorReservasCommand.Parameters.Add("@CodigoCliente" + idCliente, SqlDbType.Int);
                clientesPorReservasCommand.Parameters["@CodigoCliente" + idCliente].Value = idCliente;
            }
            clientesPorReservasQueryBuilder.Remove(clientesPorReservasQueryBuilder.Length - 2, 2);
            clientesPorReservasCommand.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            clientesPorReservasCommand.Parameters["@CodigoReserva"].Value = codigoReserva;

            clientesPorReservasCommand.CommandText = clientesPorReservasQueryBuilder.ToString();
            clientesPorReservasCommand.Connection = baseDeDatos;
            clientesPorReservasCommand.ExecuteNonQuery();
            Console.WriteLine("Clientes por reserva generados: " + codigoReserva + "|" + clientes.ToString());
        }

    }
}
