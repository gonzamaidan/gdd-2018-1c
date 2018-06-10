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

namespace FrbaHotel.AbmCliente
{
    
    public partial class BusquedaCliente : Form
    {
        SqlConnection baseDeDatos;
        bool buscaPorTipoID = false;
        Int32 tipoIdentificacion = -1;
        Int32 identificacion = -1;
        String email;
        public int idClienteSeleccionado = -1;
        public BusquedaCliente(bool editable)
        {
            this.baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
            this.modificarClienteBtn.Visible = editable;
            this.modificarClienteBtn.Enabled = editable;
            this.tipoIdentificacionComboBox.SelectedIndex = -1;
            
        }

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.TIPOS_IDENTIFICACION' table. You can move, or remove it, as needed.
            this.gD1C2018DataSet.TIPOS_IDENTIFICACION.AddTIPOS_IDENTIFICACIONRow("ABC");
            this.tIPOS_IDENTIFICACIONTableAdapter.Fill(this.gD1C2018DataSet.TIPOS_IDENTIFICACION);
            this.tipoIdentificacionCheckBox_CheckedChanged(sender, e);
        }

        private void tipoIdentificacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tipoIdentificacionComboBox.SelectedValue != null) this.tipoIdentificacion = (int) this.tipoIdentificacionComboBox.SelectedValue;
        }

        private void buscarClienteBtn_Click(object sender, EventArgs e)
        {
            if (!this.buscaPorTipoID && email == null && identificacion == -1)
                MessageBox.Show("Se necesita al menos un criterio de busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try {
                    baseDeDatos.Open();

                    
                    StringBuilder queryBuilder = new StringBuilder("SELECT * FROM LOS_MAGIOS.CLIENTES WHERE ");
                    SqlCommand queryGetClientes = new SqlCommand();
                    if (buscaPorTipoID)
                    {
                        queryBuilder.Append(" TIPO_IDENTIFICACION = @TipoIdentificacion AND");
                        queryGetClientes.Parameters.Add("@TipoIdentificacion", SqlDbType.Int);
                        queryGetClientes.Parameters["@TipoIdentificacion"].Value = this.tipoIdentificacion;
                    }
                    if (email != null)
                    {
                        queryBuilder.Append(" upper(MAIL) like upper('%' + @Email + '%') AND");
                        queryGetClientes.Parameters.Add("@Email", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Email"].Value = this.email;
                    }
                    if (identificacion != -1)
                    {
                        queryBuilder.Append(" IDENTIFICACION = @Id AND");
                        queryGetClientes.Parameters.Add("@Id", SqlDbType.Int);
                        queryGetClientes.Parameters["@Id"].Value = this.identificacion;
                    }

                    queryGetClientes.CommandText = queryBuilder.Remove(queryBuilder.Length - 3, 3).ToString();
                    queryGetClientes.Connection = baseDeDatos;

                    SqlDataAdapter adapter = new SqlDataAdapter(queryGetClientes);
                    DataTable resultados = new DataTable();
                    adapter.Fill(resultados);

                    clientesDataGridView.DataSource = resultados;
                    
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

        private void tipoIdentificacionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.buscaPorTipoID = this.tipoIdentificacionCheckBox.Checked;
            this.tipoIdentificacionComboBox.Enabled = this.buscaPorTipoID;
            this.tipoIdentificacionComboBox_SelectedIndexChanged(sender, e);
        }

        private void identificacionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (identificacionTextBox.Text != null)
            {
                this.identificacion = Convert.ToInt32(identificacionTextBox.Text);
            }
            else
            {
                this.identificacion = -1;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            this.email = emailTextBox.Text;
        }

        private void clientesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            if (this.clientesDataGridView.SelectedRows.Count == 1)
            {
                MessageBox.Show("Cliente seleccionado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.idClienteSeleccionado = Int32.Parse(this.clientesDataGridView.SelectedCells[0].Value.ToString());
                this.Hide();
                this.Close();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
