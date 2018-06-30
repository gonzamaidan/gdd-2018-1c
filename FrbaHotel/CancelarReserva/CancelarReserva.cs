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

namespace FrbaHotel.CancelarReserva
{
    public partial class CancelarReserva : Form
    {
        SqlConnection baseDeDatos;
        public CancelarReserva()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fechaCancelacion_Click(object sender, EventArgs e)
        {
                   
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.codigoReservaTB.Text == "") throw new Exception("Ingrese el codigo de reserva");
                if (this.motivoReservaTB.Text == "") throw new Exception("Ingrese un motivo");
                if (this.fechaCancelacionPicker.Value == null) throw new Exception("Ingrese la fecha de cancelacion");
                if (this.usuarioCanceladorTB.Text == "") throw new Exception("Ingrese el usuario cancelador");
                int codigoReserva = Int32.Parse(this.codigoReservaTB.Text);
                baseDeDatos.Open();
                validarReservaFecha(codigoReserva);
                
                var confirmar = MessageBox.Show("Confirme cancelar la reserva", "Cancelacion", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    //chequear usuario para saber si es cancelad por cliente o recepcion
                    updateEstadoReserva("CANCELADA-RECEPCION", codigoReserva);
                    ingresarRegistroReserva(usuarioCanceladorTB.Text, codigoReserva, "CANCELACION");
                    MessageBox.Show("Reserva cancelada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void validarReservaFecha(int codigoReserva)
        {

            SqlCommand validarDatosCmd = new SqlCommand("SELECT COUNT(*) FROM LOS_MAGIOS.RESERVAS " +
                                                        " WHERE CODIGO_RESERVA = @CodigoReserva AND FECHA_DESDE > @FechaDesde AND ID_ESTADO_RESERVA IN (1, 2)", baseDeDatos);
            validarDatosCmd.Parameters.Add("@CodigoReserva", SqlDbType.Int);
            validarDatosCmd.Parameters.Add("@FechaDesde", SqlDbType.Date);
            validarDatosCmd.Parameters["@CodigoReserva"].Value = codigoReserva;
            validarDatosCmd.Parameters["@FechaDesde"].Value = this.fechaCancelacionPicker.Value;
            if (validarDatosCmd.ExecuteScalar().Equals(0)) throw new Exception("La reserva ya no se puede cancelar o no existe");
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
    }
}
