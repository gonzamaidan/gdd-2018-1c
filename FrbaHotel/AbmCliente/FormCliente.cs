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

namespace FrbaHotel.AbmCliente
{
    public partial class FormCliente : Form
    {
        public Int32 codigoClienteCreado = -1;
        Boolean editar;
        SqlConnection baseDeDatos;
        Int32 id_cliente;
        int tipoDni;
        String tipoDniEditar;

        public FormCliente()
        {
            editar = false;
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        public FormCliente(Int32 id)
        {
            id_cliente = id;
            editar = true;
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();

            string consulta = "Select * From LOS_MAGIOS.CLIENTES h Where h.codigo_cliente = @id";
            SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
            comando2.Parameters.Add(new SqlParameter("@id", id_cliente));
            SqlDataAdapter sda = new SqlDataAdapter(comando2);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                this.textBoxNombre.Text = item[1].ToString();
                this.textBoxApellido.Text = item[2].ToString();
                this.textBoxNroDoc.Text = item[3].ToString();
                this.comboBoxTipoDoc.Text = item[4].ToString();
                tipoDniEditar = item[4].ToString();
                this.textBoxMail.Text = item[5].ToString();
                this.textBoxTelefono.Text = item[6].ToString();
                this.textBoxDireccion.Text = item[7].ToString();
                this.textBoxLocalidad.Text = item[8].ToString();
                this.textBoxPais.Text = item[9].ToString();
                this.textBoxNacionalidad.Text = item[10].ToString();
                this.dateTimePickerNacimiento.Value = DateTime.Parse(item[11].ToString());


            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeric;
            if (!int.TryParse(this.textBoxTelefono.Text, out numeric) ||
                !int.TryParse(this.textBoxNroDoc.Text, out numeric))
            {
                MessageBox.Show("El numero de telefono y dni deben ser numericos. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dateTimePickerNacimiento.Value > Program.fechaHoy)
            {
                MessageBox.Show("La fecha de nacimiento es invalida ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (verificarTextBoxNoVacios() || editar)
            {
                baseDeDatos.Open();

                string consulta = "Select * From LOS_MAGIOS.CLIENTES h Where h.IDENTIFICACION = @id AND h.TIPO_IDENTIFICACION = @tipoId";
                if (editar)
                    consulta = consulta + " AND CODIGO_CLIENTE !=" + id_cliente;
                SqlCommand comando = new SqlCommand(consulta, baseDeDatos);
                comando.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(this.textBoxNroDoc.Text)));
                comando.Parameters.Add(new SqlParameter("@tipoId", tipoDni));
 

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {

                    MessageBox.Show("Ya existe una Cliente con esta identificacion", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    baseDeDatos.Close();
                    return;
                }
                reader.Close();

                
                        string consulta2 = "Select * From LOS_MAGIOS.CLIENTES h Where h.MAIL = @mail";
                        if (editar)
                            consulta2 = consulta2 + " AND CODIGO_CLIENTE !=" + id_cliente;

                        SqlCommand comando2 = new SqlCommand(consulta2, baseDeDatos);
                        comando2.Parameters.Add(new SqlParameter("@mail", this.textBoxMail.Text));

                        reader = comando2.ExecuteReader();

                        if (reader.HasRows)
                        {
                            MessageBox.Show("Ya existe una Cliente con este mail", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            baseDeDatos.Close();
                            return;
                        }
                        reader.Close();

                MetodoCrear();
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados correctamente ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Boolean verificarTextBoxNoVacios()
        {
            bool textBoxNoVacio = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return textBoxNoVacio;
        }

        private void MetodoCrear()
        {
            try
            {
                if (!editar)
                {
                    SqlCommand queryInsert = new SqlCommand("INSERT INTO LOS_MAGIOS.CLIENTES(NOMBRE,APELLIDO,IDENTIFICACION,TIPO_IDENTIFICACION,MAIL,TELEFONO,DIRECCION,LOCALIDAD,PAIS,NACIONALIDAD,FECHA_NACIMIENTO,DUPLICADO)"
                                                                 + " VALUES( @nombre, @apellido, @id, @tipoId, @mail, @telefono, @direccion, @localidad, @pais, @nacionalidad, @fechaNacimiento,@duplicado)", baseDeDatos);

                    // else if (x == 1)
                    //    comando = new SqlCommand("AEFI.actualizar_Habitacion", conexion);

                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@nombre", this.textBoxNombre.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@apellido", this.textBoxApellido.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(this.textBoxNroDoc.Text)));
                    queryInsert.Parameters.Add(new SqlParameter("@tipoId", tipoDni));
                    queryInsert.Parameters.Add(new SqlParameter("@mail", this.textBoxMail.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@telefono", Convert.ToInt32(this.textBoxTelefono.Text)));
                    queryInsert.Parameters.Add(new SqlParameter("@direccion", this.textBoxDireccion.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@localidad", this.textBoxLocalidad.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@pais", this.textBoxPais.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@nacionalidad", this.textBoxNacionalidad.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@fechaNacimiento", dateTimePickerNacimiento.Value));
                    queryInsert.Parameters.Add(new SqlParameter("@duplicado", false));

                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();
                    //SqlDataReader reader = queryInsert.execute();

                    SqlCommand getIdCliente = new SqlCommand("SELECT MAX(CODIGO_CLIENTE) FROM LOS_MAGIOS.CLIENTES", baseDeDatos);
                    codigoClienteCreado = Int32.Parse(getIdCliente.ExecuteScalar().ToString());

                    MessageBox.Show("El Cliente se creo satisfactoriamente", "Cliente Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    SqlCommand queryInsert = new SqlCommand("UPDATE LOS_MAGIOS.CLIENTES " +
                                                            "SET NOMBRE = @nombre, APELLIDO = @apellido, IDENTIFICACION = @id, TIPO_IDENTIFICACION = @tipoId, MAIL = @mail, TELEFONO = @telefono, DIRECCION = @direccion, LOCALIDAD = @localidad, PAIS = @pais, NACIONALIDAD = @nacionalidad, FECHA_NACIMIENTO = @fechaNacimiento Where CODIGO_CLIENTE = @idCliente", baseDeDatos);
                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@nombre", this.textBoxNombre.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@apellido", this.textBoxApellido.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@id", Convert.ToInt32(this.textBoxNroDoc.Text)));
                    queryInsert.Parameters.Add(new SqlParameter("@tipoId", tipoDni));
                    queryInsert.Parameters.Add(new SqlParameter("@mail", this.textBoxMail.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@telefono", Convert.ToInt32(this.textBoxTelefono.Text)));
                    queryInsert.Parameters.Add(new SqlParameter("@direccion", this.textBoxDireccion.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@localidad", this.textBoxLocalidad.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@pais", this.textBoxPais.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@nacionalidad", this.textBoxNacionalidad.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@fechaNacimiento", dateTimePickerNacimiento.Value));
                    queryInsert.Parameters.Add(new SqlParameter("@idCliente", id_cliente));

                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();
                    MessageBox.Show("El cliente se actualizo correctamente", "Cliente modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Hide();
                this.Close();

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

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.TIPOS_IDENTIFICACION' table. You can move, or remove it, as needed.
            this.tIPOS_IDENTIFICACIONTableAdapter.Fill(this.gD1C2018DataSet.TIPOS_IDENTIFICACION);

            foreach (DataRowView item in this.comboBoxTipoDoc.Items)
            {
                if (item.Row.ItemArray[0].ToString() == tipoDniEditar)
                {
                    this.comboBoxTipoDoc.SelectedIndex = this.comboBoxTipoDoc.Items.IndexOf(item);
                    tipoDni = this.gD1C2018DataSet.TIPOS_IDENTIFICACION[this.comboBoxTipoDoc.Items.IndexOf(item)].TIPO_IDENTIFICACION;
                    return;
                }
            }
            tipoDni = this.gD1C2018DataSet.TIPOS_IDENTIFICACION[0].TIPO_IDENTIFICACION;
        }

        private void comboBoxTipoDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cmb = (ComboBox)sender;
                tipoDni = (int)cmb.SelectedValue;
            }
            catch
            {
                return;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
