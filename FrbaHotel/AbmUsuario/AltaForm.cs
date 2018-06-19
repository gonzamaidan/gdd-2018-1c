using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class AltaForm : Form
    {
        SqlConnection baseDeDatos;
        List<Hotel> hoteles = new List<Hotel>();

        private void llenarListaCheckbox()
        {
            try
            {
                baseDeDatos.Open();
                SqlCommand obtenerHotelesCmd = new SqlCommand("SELECT ID_HOTEL, NOMBRE FROM LOS_MAGIOS.HOTELES", this.baseDeDatos);
                SqlDataReader reader = obtenerHotelesCmd.ExecuteReader();
                while (reader.Read())
                {
                    Hotel hotel = new Hotel((int)reader["ID_HOTEL"], reader["NOMBRE"].ToString());
                    hoteles.Add(hotel);
                }
                hotelesCLB.DisplayMember = "NombreHotel";
                hotelesCLB.ValueMember = "IdHotel";
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

        public AltaForm()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet1.TIPOS_IDENTIFICACION' table. You can move, or remove it, as needed.
            this.tIPOS_IDENTIFICACIONTableAdapter.Fill(this.gD1C2018DataSet1.TIPOS_IDENTIFICACION);
            // TODO: This line of code loads data into the 'gD1C2018DataSet.HOTELES' table. You can move, or remove it, as needed.
            this.hOTELESTableAdapter.Fill(this.gD1C2018DataSet.HOTELES);
            // TODO: This line of code loads data into the 'gD1C2018DataSet.ROLES' table. You can move, or remove it, as needed.
            this.rOLESTableAdapter.Fill(this.gD1C2018DataSet.ROLES);
            //llenarListaCheckbox();

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private String hashPassword(String password) {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed provider = new SHA256Managed();
            byte[] hash = provider.ComputeHash(bytes);
            String hashedPassword = "";
            foreach (byte x in hash)
            {
                hashedPassword += String.Format("{0:X2}", x);
            }
            return hashedPassword;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baseDeDatos.Open();
            
            try
            {
                validarTBNoVacios();
                validarUsername();
                validarCantidadHoteles();
                SqlTransaction transaction = baseDeDatos.BeginTransaction("InsertarUsuario");
                try
                {
                    insertarUsuario(transaction);
                    insertarAsociacionRol(transaction);
                    insertarAsociacionesHoteles(transaction);
                    transaction.Commit();
                    MessageBox.Show("Usuario creado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception exc)
                {
                    transaction.Rollback();
                    throw exc;
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

        private void validarCantidadHoteles()
        {
            if (hotelesCLB.SelectedItems.Count == 0) throw new Exception("Seleccione al menos un hotel donde trabaja el usuario");
        }

        private void insertarAsociacionesHoteles(SqlTransaction transaction)
        {
            SqlCommand insertarAsociacionHotelesCmd = new SqlCommand();
            insertarAsociacionHotelesCmd.Connection = baseDeDatos;
            StringBuilder insertarAsociacionesHotelesQuery = new StringBuilder("INSERT INTO LOS_MAGIOS.HOTELES_POR_USUARIO(ID_HOTEL, USUARIO)  VALUES ");

            for (int i = 0; i < hotelesCLB.Items.Count; i++)
            {
                if (hotelesCLB.GetItemChecked(i))
                {
                    insertarAsociacionesHotelesQuery.Append("(@IdHotel" + i + ", @Usuario), ");
                    insertarAsociacionHotelesCmd.Parameters.Add("@IdHotel" + i, SqlDbType.Int);
                    insertarAsociacionHotelesCmd.Parameters["@IdHotel" + i].Value = ((DataRowView)hotelesCLB.Items[i]).Row["ID_HOTEL"];
                }
            }
            insertarAsociacionHotelesCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            insertarAsociacionHotelesCmd.Parameters["@Usuario"].Value = usuarioTB.Text;
            insertarAsociacionHotelesCmd.CommandText = insertarAsociacionesHotelesQuery.Remove(insertarAsociacionesHotelesQuery.Length - 2, 2).ToString();
            insertarAsociacionHotelesCmd.Transaction = transaction;
            insertarAsociacionHotelesCmd.ExecuteNonQuery();
        }

        private void insertarAsociacionRol(SqlTransaction transaction)
        {
            SqlCommand insertarAsociacionRolCmd = new SqlCommand("INSERT INTO LOS_MAGIOS.ROLES_POR_USUARIO(ID_ROL, USUARIO) VALUES (@IdRol, @Usuario)", baseDeDatos);
            insertarAsociacionRolCmd.Parameters.Add("@IdRol", SqlDbType.Int);
            insertarAsociacionRolCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            insertarAsociacionRolCmd.Parameters["@IdRol"].Value = rolComboBox.SelectedValue;
            insertarAsociacionRolCmd.Parameters["@Usuario"].Value = usuarioTB.Text;
            insertarAsociacionRolCmd.Transaction = transaction;
            insertarAsociacionRolCmd.ExecuteNonQuery();
        }

        private void validarUsername()
        {
            SqlCommand validarUsernameCmd = new SqlCommand("SELECT COUNT(*) FROM LOS_MAGIOS.USUARIOS WHERE USUARIO = @Usuario", baseDeDatos);
            validarUsernameCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            validarUsernameCmd.Parameters["@Usuario"].Value = usuarioTB.Text;
            if ((int)validarUsernameCmd.ExecuteScalar() == 1) throw new Exception("El nombre de usuario ya existe");
        }

        private void insertarUsuario(SqlTransaction transaction)
        {

            SqlCommand insertarUsuarioCmd = new SqlCommand("INSERT INTO LOS_MAGIOS.USUARIOS(USUARIO, CONTRASENA, NOMBRE, APELLIDO, MAIL, TELEFONO, DIRECCION, FECHA_DE_NACIMIENTO, IDENTIFICACION, TIPO_IDENTIFICACION) " +
                                                        " VALUES(@Usuario, @Contrasena, @Nombre, @Apellido, @Mail, @Telefono, @Direccion, @FechaNac, @Identificacion, @TipoIdentificacion)", baseDeDatos);
            insertarUsuarioCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            insertarUsuarioCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar);
            insertarUsuarioCmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            insertarUsuarioCmd.Parameters.Add("@Apellido", SqlDbType.VarChar);
            insertarUsuarioCmd.Parameters.Add("@Mail", SqlDbType.VarChar);
            insertarUsuarioCmd.Parameters.Add("@Telefono", SqlDbType.Int);
            insertarUsuarioCmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
            insertarUsuarioCmd.Parameters.Add("@FechaNac", SqlDbType.Date);
            insertarUsuarioCmd.Parameters.Add("@Identificacion", SqlDbType.Int);
            insertarUsuarioCmd.Parameters.Add("@TipoIdentificacion", SqlDbType.Int);


            insertarUsuarioCmd.Parameters["@Usuario"].Value = usuarioTB.Text;
            insertarUsuarioCmd.Parameters["@Contrasena"].Value = hashPassword(passwordTB.Text);
            insertarUsuarioCmd.Parameters["@Nombre"].Value = nombreTB.Text;
            insertarUsuarioCmd.Parameters["@Apellido"].Value = apellidoTB.Text;
            insertarUsuarioCmd.Parameters["@Mail"].Value = mailTB.Text;
            insertarUsuarioCmd.Parameters["@Telefono"].Value = Int32.Parse(telefonoTB.Text);
            insertarUsuarioCmd.Parameters["@Direccion"].Value = direccionTB.Text;
            insertarUsuarioCmd.Parameters["@FechaNac"].Value = nacimientoDatePicker.Value;
            insertarUsuarioCmd.Parameters["@Identificacion"].Value = Int32.Parse(numeroIdTB.Text);
            insertarUsuarioCmd.Parameters["@TipoIdentificacion"].Value = tipoIdCB.SelectedValue;
            insertarUsuarioCmd.Transaction = transaction;
            insertarUsuarioCmd.ExecuteNonQuery();
        }

        private void validarTBNoVacios()
        {
            
            foreach (Control c in this.Controls)
            {

                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        throw new Exception("Ningun campo puede estar vacio");
                    }
                    
                }


            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rOLESTableAdapter.FillBy(this.gD1C2018DataSet.ROLES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.rOLESTableAdapter.FillBy(this.gD1C2018DataSet.ROLES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
