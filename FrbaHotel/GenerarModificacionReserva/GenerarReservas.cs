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
        int codigoRegimen;
        int cantidadPersonas = 1;
        bool conRegimen = false;
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
            // TODO: This line of code loads data into the 'gD1C2018DataSet.REGIMENES' table. You can move, or remove it, as needed.
            this.rEGIMENESTableAdapter.Fill(this.gD1C2018DataSet.REGIMENES);
            this.numericUpDown1_ValueChanged(sender, e);
            this.checkBox1_CheckedChanged(sender, e);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
            
            try
            {
                baseDeDatos.Open();
                SqlCommand queryDisponibildad;
                Console.WriteLine(this.conRegimen);
                if (this.conRegimen)
                {
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
            try
            {

                this.codigoRegimen = (int)this.regimenesComboBox.SelectedValue;
                this.baseDeDatos.Open();
                SqlCommand queryDisponibildad = new SqlCommand("SELECT PRECIO_DOLARES FROM LOS_MAGIOS.REGIMENES WHERE CODIGO_REGIMEN = @CodigoRegimen", baseDeDatos);
                queryDisponibildad.Parameters.Add("@CodigoRegimen", SqlDbType.Int);
                queryDisponibildad.Parameters["@CodigoRegimen"].Value = codigoRegimen;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.conRegimen = this.checkBox1.Checked;
            this.regimenesComboBox.Enabled = this.conRegimen;
            this.regimenesComboBox_SelectedIndexChanged(sender, e);
            this.textBox2.Visible = this.conRegimen;
            this.label2.Visible = this.conRegimen;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.cantidadPersonas = (int) this.numericUpDown1.Value;
            try
            {
                this.baseDeDatos.Open();

                SqlCommand queryStringTipoHabitacion = new SqlCommand("SELECT DESCRIPCION_TIPO_HABITACION FROM LOS_MAGIOS.TIPOS_HABITACION WHERE CANTIDAD_PERSONAS = @CantidadPersonas", baseDeDatos);
                queryStringTipoHabitacion.Parameters.Add("@CantidadPersonas", SqlDbType.Int);
                queryStringTipoHabitacion.Parameters["@CantidadPersonas"].Value = this.cantidadPersonas;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                for (int i = 0; i < this.cantidadPersonas; i++)
                {
                    AbmCliente.BusquedaCliente busquedaCliente = new AbmCliente.BusquedaCliente(false);
                    DialogResult result = busquedaCliente.ShowDialog();
                    Console.WriteLine(i);
                    Console.WriteLine(result);
                    Console.WriteLine(busquedaCliente.idClienteSeleccionado);
                }
                
                this.Hide();
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una habitacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
