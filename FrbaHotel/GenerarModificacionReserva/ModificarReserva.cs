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
    public partial class ModificarReserva : Form
    {
        SqlConnection baseDeDatos;
        public ModificarReserva()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.codigoReservaTB.Text == null)
            {
                MessageBox.Show("Se debe ingresar un numero de reserva", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int codigoReserva = Int32.Parse(this.codigoReservaTB.Text);
                try
                {
                    baseDeDatos.Open();
                    SqlCommand verificarCodigoReserva = new SqlCommand("SELECT COUNT(*) FROM LOS_MAGIOS.RESERVAS " +
                                                                        "WHERE CODIGO_RESERVA = @CodigoReserva AND ID_ESTADO_RESERVA IN (1,2)", baseDeDatos);
                    verificarCodigoReserva.Parameters.Add("@CodigoReserva", SqlDbType.Int);
                    verificarCodigoReserva.Parameters["@CodigoReserva"].Value = codigoReserva;

                    if (!verificarCodigoReserva.ExecuteScalar().Equals(1))
                        throw new Exception("No existe el codigo de reserva, o la reserva fue efectivizada o cancelada");
                    else
                    {
                        GenerarReservas generarReserva = new GenerarReservas(codigoReserva);
                        DialogResult result = generarReserva.ShowDialog();
                        if (result.Equals(DialogResult.OK))
                        {
                            MessageBox.Show("Reserva modifica exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se modifico la reserva", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        }
    }
}
