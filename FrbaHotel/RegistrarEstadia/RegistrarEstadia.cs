using FrbaHotel.GenerarModificacionReserva;
using FrbaHotel.CancelarReserva;
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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistrarEstadia : Form
    {
        SqlConnection baseDeDatos;

        public RegistrarEstadia()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void botonConsumibles_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDeDatos.Open();
                SqlCommand query = new SqlCommand("SELECT a.CODIGO_RESERVA FROM LOS_MAGIOS.ESTADIAS a, LOS_MAGIOS.RESERVAS b WHERE a.CODIGO_RESERVA = @codReserva AND b.CODIGO_RESERVA = @codReserva AND A.FECHA_EGRESO IS NULL AND B.FECHA_DESDE<=@fecha", baseDeDatos);
                query.Parameters.Add("@codReserva", SqlDbType.Int);
                query.Parameters["@codReserva"].Value = this.textBox1.Text;
                query.Parameters.Add("@fecha", SqlDbType.Date);
                query.Parameters["@fecha"].Value = Program.fechaHoy;
                int reserva = (int)query.ExecuteScalar();
                registrarEgreso(reserva);
                new RegistrarConsumible.RegistrarConsumible(this.textBox1.Text).ShowDialog();
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message + exc.StackTrace);
                MessageBox.Show("No Existe el numero de reserva ingresado");
            }
            finally
            {
                this.baseDeDatos.Close();
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDeDatos.Open();
                SqlCommand query = new SqlCommand("SELECT CODIGO_RESERVA, FECHA_DESDE FROM LOS_MAGIOS.RESERVAS WHERE CODIGO_RESERVA = @codReserva AND FECHA_DESDE <= @fecha AND FECHA_HASTA>= @fecha AND (ID_ESTADO_RESERVA=1 OR ID_ESTADO_RESERVA=2)", baseDeDatos);
                query.Parameters.Add("@codReserva", SqlDbType.Int);
                query.Parameters["@codReserva"].Value = this.textBox1.Text;
                query.Parameters.Add("@fecha", SqlDbType.Date);
                query.Parameters["@fecha"].Value = Program.fechaHoy;
                SqlDataReader reader = query.ExecuteReader();

                reader.Read();
                int reserva = (int)reader[0];
                if (Program.fechaHoy == (DateTime)reader[1])
                {
                    reader.Close();
                    SqlTransaction transaction = baseDeDatos.BeginTransaction();
                    try
                    {
                        nuevaEstadia(reserva, transaction);
                        registrarClientes(reserva, transaction);
                        transaction.Commit();
                        MessageBox.Show("Estadia registrada con exito!");
                    }
                    catch
                    {
                        transaction.Rollback();
                    }

                    this.baseDeDatos.Close();
                }
                else
                {
                    reader.Close();
                    cancelarReserva(reserva);
                    DialogResult dialogResult = MessageBox.Show("La reserva fue cancelada. Desea generar una nueva reserva?", "Atencion", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        new GenerarReservas().ShowDialog();
                    }
                }
                               
            }
            catch (Exception exc)
            {
                this.baseDeDatos.Close();
                Console.WriteLine(exc.Message + " " + exc.StackTrace);
                DialogResult dialogResult = MessageBox.Show("El numero de reserva no es correcto o la reserva fue cancelada. Desea generar una nueva reserva?", "Atencion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    new GenerarReservas().ShowDialog();
                }
               
            }

        }


        private void nuevaEstadia(int reserva, SqlTransaction transaction)
        {
                SqlCommand queryNuevaEstadia = new SqlCommand("INSERT INTO LOS_MAGIOS.ESTADIAS(CODIGO_RESERVA, FECHA_INGRESO) VALUES (@codReserva, @ingreso)", baseDeDatos);
                queryNuevaEstadia.Connection = baseDeDatos;
                queryNuevaEstadia.Transaction = transaction;
                queryNuevaEstadia.Parameters.Add("@codReserva", SqlDbType.Int);
                queryNuevaEstadia.Parameters["@codReserva"].Value = reserva;
                queryNuevaEstadia.Parameters.Add("@ingreso", SqlDbType.Date);
                queryNuevaEstadia.Parameters["@ingreso"].Value = Program.fechaHoy;
                queryNuevaEstadia.ExecuteNonQuery();
                
        }

        private void registrarEgreso(int numeroReserva)
        {
            SqlCommand queryNuevaEstadia = new SqlCommand("UPDATE LOS_MAGIOS.ESTADIAS SET FECHA_EGRESO = @fecha WHERE CODIGO_RESERVA=@codReserva", baseDeDatos);
      
            queryNuevaEstadia.Parameters.Add("@codReserva", SqlDbType.Int);
            queryNuevaEstadia.Parameters["@codReserva"].Value = numeroReserva;
            queryNuevaEstadia.Parameters.Add("@fecha", SqlDbType.Date);
            queryNuevaEstadia.Parameters["@fecha"].Value = Program.fechaHoy;
            queryNuevaEstadia.ExecuteNonQuery();
   
        }

        private void cancelarReserva(int numeroReserva)
        {
            SqlTransaction transaction = baseDeDatos.BeginTransaction();
            try
            {
                SqlCommand updateFechaReservaCmd = new SqlCommand("UPDATE LOS_MAGIOS.RESERVAS SET ID_ESTADO_RESERVA = 5 "
                                                  + " WHERE CODIGO_RESERVA = @CodigoReserva", baseDeDatos);
                updateFechaReservaCmd.Connection = baseDeDatos;
                updateFechaReservaCmd.Transaction = transaction;
                updateFechaReservaCmd.Parameters.Add("@CodigoReserva", SqlDbType.Int);
                updateFechaReservaCmd.Parameters["@CodigoReserva"].Value = numeroReserva;
                updateFechaReservaCmd.ExecuteNonQuery();
                
                SqlCommand ingresarRegistroReservaCmd = new SqlCommand("INSERT INTO LOS_MAGIOS.REGISTRO_RESERVAS(CODIGO_RESERVA, FECHA,	ACCION, USUARIO) " +
                     "VALUES (@CodigoReserva, @FechaHoy, @Accion, @Usuario)", baseDeDatos);
                ingresarRegistroReservaCmd.Connection = baseDeDatos;
                ingresarRegistroReservaCmd.Transaction = transaction;
                ingresarRegistroReservaCmd.Parameters.Add("@CodigoReserva", SqlDbType.Int);
                ingresarRegistroReservaCmd.Parameters.Add("@FechaHoy", SqlDbType.Date);
                ingresarRegistroReservaCmd.Parameters["@FechaHoy"].Value = Program.fechaHoy;
                ingresarRegistroReservaCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
                ingresarRegistroReservaCmd.Parameters.Add("@Accion", SqlDbType.VarChar);

                ingresarRegistroReservaCmd.Parameters["@CodigoReserva"].Value = numeroReserva;
                ingresarRegistroReservaCmd.Parameters["@Usuario"].Value = Program.sesion.getUsuario();
                ingresarRegistroReservaCmd.Parameters["@Accion"].Value = "CANCELADA-NO-SHOW";
                ingresarRegistroReservaCmd.ExecuteNonQuery();
                Console.WriteLine("Registro de reserva generado: " + numeroReserva + "|" + " Cancelacion por NO-SHOW");

                transaction.Commit();
                MessageBox.Show("La fecha de ingreso no corresponde a la fecha actual. La reserva ha sido cancelada");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.StackTrace);
                MessageBox.Show(e.Message, "La fecha de ingreso no corresponde a la fecha actual. No se ha podido cancelar la reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                transaction.Rollback();
            }


        }

        private void registrarClientes(int nroReserva, SqlTransaction transaction)
        {
            SqlCommand queryHuespedes = new SqlCommand("SELECT TH.CANTIDAD_PERSONAS FROM LOS_MAGIOS.TIPOS_HABITACION TH, "+
            "LOS_MAGIOS.HABITACIONES_POR_RESERVA HR, LOS_MAGIOS.HABITACIONES H WHERE HR.CODIGO_RESERVA = @codReserva AND HR.ID_HOTEL = H.ID_HOTEL AND HR.NUMERO_HABITACION = H.NUMERO_HABITACION AND H.CODIGO_TIPO_HABITACION = TH.CODIGO_TIPO_HABITACION", baseDeDatos);
            queryHuespedes.Connection = baseDeDatos;
            queryHuespedes.Transaction = transaction;
            queryHuespedes.Parameters.Add("@codReserva", SqlDbType.Int);
            queryHuespedes.Parameters["@codReserva"].Value = nroReserva;
            int cantidad = (int)queryHuespedes.ExecuteScalar();
            cantidad--;
            int idCliente;

            for (int i = 1; i <= cantidad; i++)
            {
                DialogResult dialogResult = MessageBox.Show("El huesped " + i +" es nuevo?", "Atencion", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AbmCliente.FormCliente ventana = new AbmCliente.FormCliente();
                    ventana.ShowDialog();
                    if (ventana.codigoClienteCreado != -1)
                        idCliente = ventana.codigoClienteCreado;
                    else
                    {
                        MessageBox.Show("No se creo el cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("No se creo el cliente");
                    }
                }
                else
                {
                    ListadoClientesEstadia busquedaCliente = new ListadoClientesEstadia(true);
                    DialogResult result = busquedaCliente.ShowDialog();

                    if (busquedaCliente.idClienteSeleccionado != -1)
                        idCliente = busquedaCliente.idClienteSeleccionado;
                    else
                    {
                        MessageBox.Show("Debe seleccionar un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        throw new Exception("Debe seleccionar un cliente");
                    }
                }
                ingresarClientePorReserva(idCliente, nroReserva, transaction);
            }


        }

        private void ingresarClientePorReserva(int idCliente, int nroReserva, SqlTransaction transaction)
        {
            try
            {
                SqlCommand queryClientePorReserva = new SqlCommand("INSERT INTO LOS_MAGIOS.CLIENTES_POR_RESERVA(CODIGO_CLIENTE, CODIGO_RESERVA) VALUES(@CodigoCliente, @codReserva)", baseDeDatos);
                queryClientePorReserva.Connection = baseDeDatos;
                queryClientePorReserva.Transaction = transaction;
                queryClientePorReserva.Parameters.Add("@codReserva", SqlDbType.Int);
                queryClientePorReserva.Parameters["@codReserva"].Value = nroReserva;
                queryClientePorReserva.Parameters.Add("@CodigoCliente", SqlDbType.Int);
                queryClientePorReserva.Parameters["@CodigoCliente"].Value = idCliente;
                queryClientePorReserva.ExecuteNonQuery();
                Console.WriteLine("Cliente por reserva generado: " + nroReserva + "|" + idCliente.ToString());
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }
        }

    }
}
