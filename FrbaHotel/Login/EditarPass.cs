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

namespace FrbaHotel.Login
{
    public partial class EditarPass : Form
    {
        public EditarPass()
        {
            InitializeComponent();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            Program.baseDeDatos.Open();

            try
            {
                if (this.passwordTb.Text == "") throw new Exception("La password no puede estar vacia");

                SqlCommand editarUsuarioCmd = new SqlCommand("UPDATE LOS_MAGIOS.USUARIOS SET CONTRASENA = HASHBYTES('SHA2_256', @Contrasena) WHERE USUARIO = @Usuario", Program.baseDeDatos);
                editarUsuarioCmd.Parameters.Add("@Usuario", SqlDbType.VarChar);
                editarUsuarioCmd.Parameters.Add("@Contrasena", SqlDbType.VarChar);
                
                editarUsuarioCmd.Parameters["@Usuario"].Value = Program.sesion.getUsuario();
                editarUsuarioCmd.Parameters["@Contrasena"].Value = passwordTb.Text;

                editarUsuarioCmd.ExecuteNonQuery();
                

                MessageBox.Show("Password editada", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Program.baseDeDatos.Close();
            }
        }
    }
}
