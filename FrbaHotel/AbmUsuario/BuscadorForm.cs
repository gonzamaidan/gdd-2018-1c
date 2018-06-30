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

namespace FrbaHotel.AbmUsuario
{
    public partial class BuscadorForm : Form
    {
        SqlConnection baseDeDatos;
        public BuscadorForm()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baseDeDatos.Open();
                validarDatosNumericos();
                SqlCommand buscarUsuariosCmd = new SqlCommand();
                StringBuilder buscarUsuariosQuery = new StringBuilder("SELECT U.USUARIO, R.NOMBRE AS ROL, U.NOMBRE, APELLIDO, MAIL, TELEFONO, DIRECCION, FECHA_DE_NACIMIENTO, IDENTIFICACION, T.DESCRIPCION FROM LOS_MAGIOS.USUARIOS U JOIN LOS_MAGIOS.TIPOS_IDENTIFICACION T ON T.TIPO_IDENTIFICACION = U.TIPO_IDENTIFICACION JOIN LOS_MAGIOS.ROLES_POR_USUARIO RU ON RU.USUARIO = U.USUARIO JOIN LOS_MAGIOS.ROLES R ON RU.ID_ROL = R.ID_ROL WHERE U.ESTADO = 1");
                llenarCmdBusqueda(buscarUsuariosCmd, buscarUsuariosQuery);
                buscarUsuariosCmd.CommandText = buscarUsuariosQuery.ToString();
                buscarUsuariosCmd.Connection = baseDeDatos;

                SqlDataAdapter adapter = new SqlDataAdapter(buscarUsuariosCmd);
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
                this.baseDeDatos.Close();
            }
        }

        private String agregarPorcentajes(String str)
        {
            return "%" + str + "%";
        }

        private void validarDatosNumericos()
        {
            int value;
            if (this.numeroIdTB.Text != "" && !Int32.TryParse(this.numeroIdTB.Text, out value)) throw new Exception("Ingrese un numero de identificacion valido");
            if (this.telefonoTB.Text != "" && !Int32.TryParse(this.telefonoTB.Text, out value)) throw new Exception("Ingrese un numero de telefono valido");
        }

        private void llenarCmdBusqueda(SqlCommand cmd, StringBuilder query)
        {
            if (usuarioTB.Text != "")
            {
                query.Append(" AND UPPER(U.USUARIO) LIKE UPPER(@Usuario)");
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
                cmd.Parameters["@Usuario"].Value = agregarPorcentajes(usuarioTB.Text);
            }
            if (rolCB.Checked){
                query.Append(" AND R.ID_ROL = @IdRol");
                cmd.Parameters.Add("@IdRol", SqlDbType.Int);
                cmd.Parameters["@IdRol"].Value = rolComboBox.SelectedValue;
            }
            if (nombreTB.Text != "")
            {
                query.Append(" AND UPPER(U.NOMBRE) LIKE UPPER(@Nombre)");
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = agregarPorcentajes(nombreTB.Text);
            }
            if (apellidoTB.Text != "")
            {
                query.Append(" AND UPPER(U.APELLIDO) LIKE UPPER(@Apellido)");
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar);
                cmd.Parameters["@Apellido"].Value = agregarPorcentajes(apellidoTB.Text);
            }
            if (tipoIdCheckBox.Checked)
            {
                query.Append(" AND U.TIPO_IDENTIFICACION = @TipoIdentificacion");
                cmd.Parameters.Add("@TipoIdentificacion", SqlDbType.Int);
                cmd.Parameters["@TipoIdentificacion"].Value = rolComboBox.SelectedValue;
            }
            if (numeroIdTB.Text != "")
            {
                query.Append(" AND STR(U.IDENTIFICACION) LIKE @Identificacion");
                cmd.Parameters.Add("@Identificacion", SqlDbType.VarChar);
                cmd.Parameters["@Identificacion"].Value = agregarPorcentajes(numeroIdTB.Text);
            }
            if (mailTB.Text != "")
            {
                query.Append(" AND UPPER(U.MAIL) LIKE UPPER(@Mail)");
                cmd.Parameters.Add("@Mail", SqlDbType.VarChar);
                cmd.Parameters["@Mail"].Value = agregarPorcentajes(mailTB.Text);
            }
            if (telefonoTB.Text != "")
            {
                query.Append(" AND STR(U.TELEFONO) LIKE @Telefono");
                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar);
                cmd.Parameters["@Telefono"].Value = agregarPorcentajes(telefonoTB.Text);
            }
            if (direccionTB.Text != "")
            {
                query.Append(" AND UPPER(U.DIRECCION) LIKE UPPER(@Direccion)");
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
                cmd.Parameters["@Direccion"].Value = agregarPorcentajes(direccionTB.Text);
            }
            if (fechaNacimientoCB.Checked)
            {
                query.Append(" AND U.FECHA_DE_NACIMIENTO = @FechaNac");
                cmd.Parameters.Add("@FechaNac", SqlDbType.Date);
                cmd.Parameters["@FechaNac"].Value = nacimientoDatePicker.Value;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BuscadorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.TIPOS_IDENTIFICACION' table. You can move, or remove it, as needed.
            this.tIPOS_IDENTIFICACIONTableAdapter.Fill(this.gD1C2018DataSet.TIPOS_IDENTIFICACION);
            // TODO: This line of code loads data into the 'gD1C2018DataSet.ROLES' table. You can move, or remove it, as needed.
            this.rOLESTableAdapter.Fill(this.gD1C2018DataSet.ROLES);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rOLESTableAdapter.FillBy1(this.gD1C2018DataSet.ROLES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1) throw new Exception("Seleccione 1 usuario");
            AltaForm editarUsuario = new AbmUsuario.AltaForm(dataGridView1.SelectedRows[0].Cells["USUARIO"].Value.ToString());
            DialogResult result = editarUsuario.ShowDialog();
            if(result == DialogResult.OK)
                MessageBox.Show("Usuario editado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("El usuario no se edito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buscarBtn_Click(sender, e);
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                baseDeDatos.Open();
                if (dataGridView1.SelectedRows.Count != 1) throw new Exception("Seleccione 1 usuario");
                SqlCommand eliminarUsuarioCmd = new SqlCommand("UPDATE LOS_MAGIOS.USUARIOS SET ESTADO = 0 WHERE USUARIO = @Usuario", baseDeDatos);
                eliminarUsuarioCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
                eliminarUsuarioCmd.Parameters["@Usuario"].Value = dataGridView1.SelectedRows[0].Cells["USUARIO"].Value;
                eliminarUsuarioCmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.buscarBtn_Click(sender, e);

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
