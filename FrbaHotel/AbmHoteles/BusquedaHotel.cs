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
    public partial class BusquedaHotel : Form
    {   
        Int32 idHotelSeleccionado;
        SqlConnection baseDeDatos;

        public BusquedaHotel()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void BusquedaHotel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.HOTELES' table. You can move, or remove it, as needed.
            this.hOTELESTableAdapter.Fill(this.gD1C2018DataSet.HOTELES);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewHoteles.SelectedRows.Count == 1)
            {
                MessageBox.Show("Se pasa a editar el hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.idHotelSeleccionado = Int32.Parse(dataGridViewHoteles.SelectedRows[0].Cells[0].Value.ToString());
                this.Hide();
                FormNewHotel formHotel = new FormNewHotel(idHotelSeleccionado);
                formHotel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewHoteles.SelectedRows.Count == 1)
            {
                this.Hide();
                BajaHotel bajaHotel = new BajaHotel(Int32.Parse(dataGridViewHoteles.SelectedRows[0].Cells[0].Value.ToString()));
                bajaHotel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBoxNombre.Text == null && this.textBoxPais.Text == null && this.textBoxCiudad.Text == null && this.numericEstrellas.Value != 0)
                MessageBox.Show("Se necesita al menos un criterio de busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    baseDeDatos.Open();


                    StringBuilder queryBuilder = new StringBuilder("SELECT * FROM LOS_MAGIOS.HOTELES WHERE ");
                    SqlCommand queryGetClientes = new SqlCommand();
                    if (this.textBoxNombre.Text != null)
                    {
                        queryBuilder.Append(" upper(NOMBRE) like upper('%' + @Nombre + '%') AND");
                        queryGetClientes.Parameters.Add("@Nombre", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Nombre"].Value = this.textBoxNombre.Text;
                    }
                    if (this.textBoxPais.Text != null)
                    {
                        queryBuilder.Append(" upper(PAIS) like upper('%' + @Pais + '%') AND");
                        queryGetClientes.Parameters.Add("@Pais", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Pais"].Value = this.textBoxPais.Text;
                    }
                    if (this.textBoxCiudad.Text != null)
                    {
                        queryBuilder.Append(" upper(CIUDAD) like upper('%' + @Ciudad + '%') AND");
                        queryGetClientes.Parameters.Add("@Ciudad", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Ciudad"].Value = this.textBoxCiudad.Text;
                    }
                    if (this.numericEstrellas.Value != 0)
                    {
                        queryBuilder.Append(" ESTRELLAS = @Estrellas AND");
                        queryGetClientes.Parameters.Add("@Estrellas", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Estrellas"].Value = this.numericEstrellas.Value;
                    }
                    queryGetClientes.CommandText = queryBuilder.Remove(queryBuilder.Length - 3, 3).ToString();
                    queryGetClientes.Connection = baseDeDatos;

                    SqlDataAdapter adapter = new SqlDataAdapter(queryGetClientes);
                    DataTable resultados = new DataTable();
                    adapter.Fill(resultados);

                    dataGridViewHoteles.DataSource = resultados;

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

        private void buttonNuevoHotel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se pasa a crear un nuevo hotel", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            FormNewHotel formHotel = new FormNewHotel();
            formHotel.ShowDialog();
        }
    }
}
