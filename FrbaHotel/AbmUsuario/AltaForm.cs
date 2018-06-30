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
        Boolean flagEdicion = false;
        String usuarioAModificar;

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

        public AltaForm(String usuario)
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();

            
            usuarioAModificar = usuario;
            flagEdicion = true;
            
            this.guardarBtn.Text = "Modificar";
            this.usuarioTB.Text = usuario;
            this.usuarioTB.Enabled = false;

        }

        private void llenarDatos()
        {
            try
            {
                baseDeDatos.Open();
                SqlCommand getUsuarioCmd = new SqlCommand("SELECT R.ID_ROL, U.NOMBRE, APELLIDO, T.TIPO_IDENTIFICACION, IDENTIFICACION, MAIL, TELEFONO, DIRECCION, FECHA_DE_NACIMIENTO FROM LOS_MAGIOS.USUARIOS U JOIN LOS_MAGIOS.TIPOS_IDENTIFICACION T ON T.TIPO_IDENTIFICACION = U.TIPO_IDENTIFICACION JOIN LOS_MAGIOS.ROLES_POR_USUARIO RU ON RU.USUARIO = U.USUARIO JOIN LOS_MAGIOS.ROLES R ON RU.ID_ROL = R.ID_ROL WHERE U.USUARIO = @Usuario", baseDeDatos);
                getUsuarioCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
                getUsuarioCmd.Parameters["@Usuario"].Value = usuarioAModificar;

                SqlDataReader reader = getUsuarioCmd.ExecuteReader();

                while (reader.Read())
                {
                    usuarioTB.Text = usuarioAModificar;
                    rolComboBox.SelectedValue = reader.GetInt32(0);
                    nombreTB.Text = reader.GetString(1);
                    apellidoTB.Text = reader.GetString(2);
                    tipoIdCB.SelectedValue = reader.GetInt32(3);
                    numeroIdTB.Text = reader.GetInt32(4).ToString();
                    mailTB.Text = reader.GetString(5);
                    telefonoTB.Text = reader.GetInt32(6).ToString();
                    direccionTB.Text = reader.GetString(7);
                    nacimientoDatePicker.Value = reader.GetDateTime(8);
                }
                reader.Close();
                SqlCommand getHotelesCmd = new SqlCommand("SELECT ID_HOTEL FROM LOS_MAGIOS.HOTELES_POR_USUARIO WHERE USUARIO = @Usuario", baseDeDatos);
                getHotelesCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
                getHotelesCmd.Parameters["@Usuario"].Value = usuarioAModificar;

                reader = getHotelesCmd.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < hotelesCLB.Items.Count; i++)
                    {
                        if (((DataRowView)hotelesCLB.Items[i]).Row["ID_HOTEL"].Equals(reader.GetInt32(0)))
                        {
                            hotelesCLB.SetItemChecked(i, true);
                        }

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
            if(flagEdicion)
                llenarDatos();
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
                validarCantidadHoteles();
                validarDatosNumericos();
                if (!flagEdicion)
                {
                    validarUsername();
                    SqlTransaction transaction = baseDeDatos.BeginTransaction("InsertarUsuario");
                    try
                    {
                        insertarUsuario(transaction);
                        insertarAsociacionRol(transaction);
                        insertarAsociacionesHoteles(transaction);
                        transaction.Commit();
                        MessageBox.Show("Usuario creado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                        this.Close();
                    }
                    catch (Exception exc)
                    {
                        transaction.Rollback();
                        throw exc;
                    }

                }
                else
                {
                    SqlTransaction transaction = baseDeDatos.BeginTransaction("EditarUsuario");
                    try
                    {
                        editarUsuario(transaction);
                        
                        eliminarAsociacionRol(transaction);
                        insertarAsociacionRol(transaction);

                        eliminarAsociacionHotel(transaction);
                        insertarAsociacionesHoteles(transaction);
                        
                        transaction.Commit();
                        //MessageBox.Show("Usuario modificado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Hide();
                        this.Close();

                    }
                    catch (Exception exc)
                    {
                        transaction.Rollback();
                        throw exc;
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

        private void validarDatosNumericos()
        {
            int value;
            if (!Int32.TryParse(this.numeroIdTB.Text, out value)) throw new Exception("Ingrese un numero de identificacion valido");
            if (!Int32.TryParse(this.telefonoTB.Text, out value)) throw new Exception("Ingrese un numero de telefono valido");
        }

        private void validarCantidadHoteles()
        {
            for (int i = 0; i < hotelesCLB.Items.Count; i++)
            {
                if (hotelesCLB.GetItemChecked(i)) return;    
            }
            throw new Exception("Seleccione al menos un hotel donde trabaja el usuario");
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

        private void eliminarAsociacionHotel(SqlTransaction transaction)
        {
            SqlCommand eliminarAsociacionHotelCmd = new SqlCommand("DELETE FROM LOS_MAGIOS.HOTELES_POR_USUARIO WHERE USUARIO = @Usuario", baseDeDatos);
            eliminarAsociacionHotelCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            eliminarAsociacionHotelCmd.Parameters["@Usuario"].Value = usuarioAModificar;
            eliminarAsociacionHotelCmd.Transaction = transaction;
            eliminarAsociacionHotelCmd.ExecuteNonQuery();
        }


        private void eliminarAsociacionRol(SqlTransaction transaction)
        {
            SqlCommand eliminarAsociacionRolCmd = new SqlCommand("DELETE FROM LOS_MAGIOS.ROLES_POR_USUARIO WHERE USUARIO = @Usuario", baseDeDatos);
            eliminarAsociacionRolCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            eliminarAsociacionRolCmd.Parameters["@Usuario"].Value = usuarioAModificar;
            eliminarAsociacionRolCmd.Transaction = transaction;
            eliminarAsociacionRolCmd.ExecuteNonQuery();
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

        private void editarUsuario(SqlTransaction transaction)
        {

            SqlCommand editarUsuarioCmd = new SqlCommand("UPDATE LOS_MAGIOS.USUARIOS SET CONTRASENA = @Contrasena, NOMBRE = @Nombre, APELLIDO = @Apellido, MAIL = @Mail, TELEFONO = @Telefono, " +
                                                        "DIRECCION = @Direccion, FECHA_DE_NACIMIENTO = @FechaNac, IDENTIFICACION = @Identificacion, TIPO_IDENTIFICACION = @TipoIdentificacion WHERE USUARIO = @Usuario", baseDeDatos);
            editarUsuarioCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
            editarUsuarioCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar);
            editarUsuarioCmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            editarUsuarioCmd.Parameters.Add("@Apellido", SqlDbType.VarChar);
            editarUsuarioCmd.Parameters.Add("@Mail", SqlDbType.VarChar);
            editarUsuarioCmd.Parameters.Add("@Telefono", SqlDbType.Int);
            editarUsuarioCmd.Parameters.Add("@Direccion", SqlDbType.VarChar);
            editarUsuarioCmd.Parameters.Add("@FechaNac", SqlDbType.Date);
            editarUsuarioCmd.Parameters.Add("@Identificacion", SqlDbType.Int);
            editarUsuarioCmd.Parameters.Add("@TipoIdentificacion", SqlDbType.Int);


            editarUsuarioCmd.Parameters["@Usuario"].Value = usuarioAModificar;
            editarUsuarioCmd.Parameters["@Contrasena"].Value = hashPassword(passwordTB.Text);
            editarUsuarioCmd.Parameters["@Nombre"].Value = nombreTB.Text;
            editarUsuarioCmd.Parameters["@Apellido"].Value = apellidoTB.Text;
            editarUsuarioCmd.Parameters["@Mail"].Value = mailTB.Text;
            editarUsuarioCmd.Parameters["@Telefono"].Value = Int32.Parse(telefonoTB.Text);
            editarUsuarioCmd.Parameters["@Direccion"].Value = direccionTB.Text;
            editarUsuarioCmd.Parameters["@FechaNac"].Value = nacimientoDatePicker.Value;
            editarUsuarioCmd.Parameters["@Identificacion"].Value = Int32.Parse(numeroIdTB.Text);
            editarUsuarioCmd.Parameters["@TipoIdentificacion"].Value = tipoIdCB.SelectedValue;
            editarUsuarioCmd.Transaction = transaction;
            editarUsuarioCmd.ExecuteNonQuery();
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
