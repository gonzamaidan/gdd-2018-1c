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
            this.fechaCancelacionPicker.Value = Program.fechaHoy;
            this.usuarioCanceladorTB.Text = Program.sesion.getUsuario();
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
                int codigoReserva;
                if(!Int32.TryParse(this.codigoReservaTB.Text, out codigoReserva)) {
                    MessageBox.Show("Se debe ingresar un codigo de reserva valido", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                baseDeDatos.Open();
                validarReservaFecha(codigoReserva);
                validarExistenciaUsuario();
                
                var confirmar = MessageBox.Show("Confirme cancelar la reserva", "Cancelacion", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    if(Program.sesion.getRol() == "GUEST")
                        updateEstadoReserva("CANCELADA-CLIENTE", codigoReserva);
                    else 
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

        private void validarExistenciaUsuario()
        {
            SqlCommand validarDatosCmd = new SqlCommand("SELECT COUNT(*) FROM LOS_MAGIOS.USUARIOS" +
                                                        " WHERE USUARIO = @Usuario AND ESTADO = 1", baseDeDatos);
            validarDatosCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            validarDatosCmd.Parameters["@Usuario"].Value = this.usuarioCanceladorTB.Text;
            
            if (validarDatosCmd.ExecuteScalar().Equals(0)) throw new Exception("El usuario cancelador no existe");
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

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
