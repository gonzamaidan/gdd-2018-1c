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
using FrbaHotel.AbmCliente;


namespace FrbaHotel.RegistrarEstadia
{
    public partial class ListadoClientesEstadia : Form
    {
        public Int32 idClienteSeleccionado = -1;
        Boolean obtenerCliente = false;
        SqlConnection baseDeDatos;
        int tipoDni;

        public ListadoClientesEstadia()
        {
            InitializeComponent();
            baseDeDatos = ConexionBD.conectar();
            this.selecClienteBTN.Visible = false;
            this.selecClienteBTN.Enabled = false;

        }
        public ListadoClientesEstadia(Boolean obtenerCliente)
        {
            InitializeComponent();
            baseDeDatos = ConexionBD.conectar();
            this.obtenerCliente = obtenerCliente;
            if (obtenerCliente)
            {
                this.selecClienteBTN.Enabled = true;
                this.selecClienteBTN.Visible = true;
                this.button1.Enabled = false;
                this.button1.Visible = false;
                this.buttonBorrar.Visible = false;
                this.buttonBorrar.Enabled = false;
                this.buttonEditar.Visible = true;
                this.buttonEditar.Enabled = true;
                this.buttonHabilitar.Visible = false;
                this.buttonHabilitar.Enabled = false;
                this.textBoxNombre.Visible = false;
                this.textBoxApellido.Visible = false;
                this.label1.Visible = false;
                this.label2.Visible = false;
            }
        }

        private void ListadoClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.CLIENTES_POR_RESERVA' table. You can move, or remove it, as needed.
            //this.cLIENTES_POR_RESERVATableAdapter.Fill(this.gD1C2018DataSet.CLIENTES_POR_RESERVA);
            // TODO: This line of code loads data into the 'gD1C2018DataSet.TIPOS_IDENTIFICACION' table. You can move, or remove it, as needed.
            this.tIPOS_IDENTIFICACIONTableAdapter.Fill(this.gD1C2018DataSet.TIPOS_IDENTIFICACION);
            // TODO: This line of code loads data into the 'gD1C2018DataSet.CLIENTES' table. You can move, or remove it, as needed.
            //this.cLIENTESTableAdapter.Fill(this.gD1C2018DataSet.CLIENTES);

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewClientes.SelectedRows.Count == 1)
            {
                MessageBox.Show("Se pasa a editar al cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.idClienteSeleccionado = Int32.Parse(dataGridViewClientes.SelectedRows[0].Cells[0].Value.ToString());
                this.Hide();
                FormCliente formHotel = new FormCliente(idClienteSeleccionado);
                formHotel.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (this.textBoxNombre.Text == null && this.textBoxApellido.Text == null && this.textBoxMail.Text == null && this.textBoxNumeroDoc.Text == null)
                MessageBox.Show("Se necesita al menos un criterio de busqueda", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    baseDeDatos.Open();


                    StringBuilder queryBuilder = new StringBuilder("SELECT * FROM LOS_MAGIOS.CLIENTES WHERE ");
                    SqlCommand queryGetClientes = new SqlCommand();
                    if (this.textBoxNombre.Text != null && this.textBoxNombre.Text != "")
                    {
                        queryBuilder.Append(" upper(NOMBRE) like upper('%' + @Nombre + '%') AND");
                        queryGetClientes.Parameters.Add("@Nombre", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Nombre"].Value = this.textBoxNombre.Text;
                    }
                    if (this.textBoxApellido.Text != null && this.textBoxApellido.Text != "")
                    {
                        queryBuilder.Append(" upper(APELLIDO) like upper('%' + @Apellido + '%') AND");
                        queryGetClientes.Parameters.Add("@Apellido", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Apellido"].Value = this.textBoxApellido.Text;
                    }
                    if (this.textBoxMail.Text != null && this.textBoxMail.Text != "")
                    {
                        queryBuilder.Append(" upper(MAIL) like upper('%' + @Mail + '%') AND");
                        queryGetClientes.Parameters.Add("@Mail", SqlDbType.VarChar);
                        queryGetClientes.Parameters["@Mail"].Value = this.textBoxMail.Text;
                    }
                    if (this.textBoxNumeroDoc.Text != null && this.textBoxNumeroDoc.Text != "")
                    {
                        queryBuilder.Append(" IDENTIFICACION = @Id AND");
                        queryGetClientes.Parameters.Add("@Id", SqlDbType.Int);
                        queryGetClientes.Parameters["@Id"].Value = Convert.ToInt32(this.textBoxNumeroDoc.Text);
                    }
                    if (tipoDni != 0)
                    {
                        queryBuilder.Append(" TIPO_IDENTIFICACION = @tipoDni AND");
                        queryGetClientes.Parameters.Add("@tipoDni", SqlDbType.Int);
                        queryGetClientes.Parameters["@tipoDni"].Value = tipoDni;
                    }
                    if (obtenerCliente) 
                    {
                        queryBuilder.Append(" DUPLICADO = 0 AND HABILITADO = 1 AND");
                    }

                    queryGetClientes.CommandText = queryBuilder.Remove(queryBuilder.Length - 3, 3).ToString();
                    queryGetClientes.Connection = baseDeDatos;

                    SqlDataAdapter adapter = new SqlDataAdapter(queryGetClientes);
                    DataTable resultados = new DataTable();
                    adapter.Fill(resultados);

                    dataGridViewClientes.DataSource = resultados;

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
            MessageBox.Show("Se pasa a crear un nuevo cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            FormCliente formHotel = new FormCliente();
            formHotel.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            if(cmb.SelectedValue!=null)
                tipoDni = (int)cmb.SelectedValue;
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if ((Boolean)(dataGridViewClientes.SelectedRows[0].Cells[13].Value) == true)
            {
                baseDeDatos.Open();

                this.idClienteSeleccionado = Int32.Parse(dataGridViewClientes.SelectedRows[0].Cells[0].Value.ToString());
                SqlCommand queryInsert = new SqlCommand("UPDATE LOS_MAGIOS.CLIENTES " +
                                                                "SET HABILITADO = 0 Where CODIGO_CLIENTE = @idCliente", baseDeDatos);
                queryInsert.CommandType = CommandType.StoredProcedure;
                queryInsert.Parameters.Add(new SqlParameter("@idCliente", idClienteSeleccionado));
                queryInsert.CommandType = CommandType.Text;
                queryInsert.ExecuteNonQuery();
                MessageBox.Show("El cliente se deshabilito correctamente", "Cliente deshabilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizar();
                baseDeDatos.Close();
            }
            else
            {
                MessageBox.Show("El cliente ya ésta deshabilitado", "Cliente habilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void actualizar()
        {
            string consulta = "Select * From LOS_MAGIOS.CLIENTES h";
            SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
            SqlDataAdapter sda = new SqlDataAdapter(comando2);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            dataGridViewClientes.DataSource = dt;
        }

        private void buttonHabilitar_Click(object sender, EventArgs e)
        {
            if ((Boolean)(dataGridViewClientes.SelectedRows[0].Cells[13].Value)==false)
            {
                baseDeDatos.Open();

                this.idClienteSeleccionado = Int32.Parse(dataGridViewClientes.SelectedRows[0].Cells[0].Value.ToString());
                SqlCommand queryInsert = new SqlCommand("UPDATE LOS_MAGIOS.CLIENTES " +
                                                                "SET HABILITADO = 1 Where CODIGO_CLIENTE = @idCliente", baseDeDatos);
                queryInsert.CommandType = CommandType.StoredProcedure;
                queryInsert.Parameters.Add(new SqlParameter("@idCliente", idClienteSeleccionado));
                queryInsert.CommandType = CommandType.Text;
                queryInsert.ExecuteNonQuery();
                MessageBox.Show("El cliente se habilito correctamente", "Cliente habilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualizar();
                baseDeDatos.Close();
            }
            else
            {
                MessageBox.Show("El cliente ya ésta habilitado", "Cliente habilitado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void seleccionClienteBtn_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewClientes.SelectedRows.Count == 1)
            {
                MessageBox.Show("Cliente seleccionado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.idClienteSeleccionado = Int32.Parse(dataGridViewClientes.SelectedRows[0].Cells[0].Value.ToString());
                this.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void selecClienteBTN_Click(object sender, EventArgs e)
        {
            seleccionClienteBtn_Click(sender, e);
        }
    }
}
