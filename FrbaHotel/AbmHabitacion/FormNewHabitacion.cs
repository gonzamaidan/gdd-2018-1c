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

namespace FrbaHotel.AbmHabitacion
{
    public partial class FormNewHabitacion : Form
    {
        SqlConnection baseDeDatos;
        String ubicacionHabitacion;
        int codigoTipoHab;
        Int32 idHotel;
        Int32 idHabitacion;
        Boolean editar;

        public FormNewHabitacion(Int32 idHotel)
        {
            this.idHotel = idHotel;
            this.editar = false;
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        public FormNewHabitacion(Int32 idHotel, Int32 idHabitacion)
        {
            this.editar = true;
            this.idHotel = idHotel;
            this.idHabitacion = idHabitacion;
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();

            string consulta = "Select * From LOS_MAGIOS.HABITACIONES h Where h.numero_habitacion = @idHabitacion and h.ID_HOTEL = @idHotel ";
            SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
            comando2.Parameters.Add(new SqlParameter("@idHotel", idHotel));
            comando2.Parameters.Add(new SqlParameter("@idHabitacion", idHabitacion));
            SqlDataAdapter sda = new SqlDataAdapter(comando2);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                this.textNumeroHab.Text = item[1].ToString();
                this.textoPisoHab.Text = item[2].ToString();
                this.ubicacionHabitacion = item[3].ToString();
                this.codigoTipoHab = (Int32)item[4];
                if (item[3].ToString().Equals("INTERIOR"))
                    this.radioBotonInterior.Checked = true;
                if (item[3].ToString().Equals("EXTERIOR"))
                    this.radioBotonExterior.Checked = true;
            }
        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            int numeric;
            if (!int.TryParse(this.textNumeroHab.Text, out numeric) ||
                !int.TryParse(this.textoPisoHab.Text, out numeric))
            {
                MessageBox.Show("Los valores para habitacion y piso deben ser numericos. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (verificarTextBoxNoVacios() && this.ubicacionHabitacion != null)
            {

                baseDeDatos.Open();
                if (!this.editar)
                {
                    string consulta = "Select * From LOS_MAGIOS.HABITACIONES h Where h.numero_habitacion = " + this.textNumeroHab.Text;

                    SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
                    SqlDataReader reader = comando2.ExecuteReader();

                    if (reader.HasRows)
                    {

                        MessageBox.Show("Ya existe una Habitacion con este Numero ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baseDeDatos.Close();

                    }
                    else
                    {
                        reader.Close();
                        MetodoCrear();

                    }
                }
                else
                {
                    MetodoCrear();
                }
            }
            else
            {
                MessageBox.Show("Todos los campos deben ser completados ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    SqlCommand queryInsert = new SqlCommand("INSERT INTO LOS_MAGIOS.HABITACIONES(ID_HOTEL, NUMERO_HABITACION, PISO, UBICACION, CODIGO_TIPO_HABITACION)"
                                                             + "VALUES(@Id_Hotel, @Numero_Habitacion, @Piso, @Ubicacion, @Codigo_tipo_habitacion)", baseDeDatos);

                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@Id_Hotel", this.idHotel));
                    queryInsert.Parameters.Add(new SqlParameter("@Numero_Habitacion", this.textNumeroHab.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@Piso", this.textoPisoHab.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@Ubicacion", this.ubicacionHabitacion));
                    queryInsert.Parameters.Add(new SqlParameter("@Codigo_tipo_habitacion", this.codigoTipoHab));

                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();

                    MessageBox.Show("La Habitacion se creo satisfactoriamente", "Habitacion Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand queryInsert = new SqlCommand("UPDATE LOS_MAGIOS.HABITACIONES " +
                                                            "SET NUMERO_HABITACION = @Numero_Habitacion, PISO = @Piso, UBICACION = @Ubicacion, CODIGO_TIPO_HABITACION = @Codigo_tipo_habitacion Where ID_HOTEL = @idHotel and NUMERO_HABITACION = @idHabitacion", baseDeDatos);
                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@idHotel", this.idHotel));
                    queryInsert.Parameters.Add(new SqlParameter("@idHabitacion", this.idHabitacion));
                    queryInsert.Parameters.Add(new SqlParameter("@Numero_Habitacion", this.textNumeroHab.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@Piso", this.textoPisoHab.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@Ubicacion", this.ubicacionHabitacion));
                    queryInsert.Parameters.Add(new SqlParameter("@Codigo_tipo_habitacion", this.codigoTipoHab));
                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();
                    MessageBox.Show("La Habitacion se actualizo correctamente", "Habitacion Actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

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

        private void FormNewHabitacion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.TIPOS_HABITACION' table. You can move, or remove it, as needed.
            this.tIPOS_HABITACIONTableAdapter.Fill(this.gD1C2018DataSet.TIPOS_HABITACION);

        }

        private void fillByTipoHabitacionToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tIPOS_HABITACIONTableAdapter.FillByTipoHabitacion(this.gD1C2018DataSet.TIPOS_HABITACION);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void seleccionarUbicacionExterior(object sender, EventArgs e)
        {
            this.ubicacionHabitacion = "EXTERIOR";
        }
        private void seleccionarUbicacionInterior(object sender, EventArgs e)
        {
            this.ubicacionHabitacion = "INTERIOR";
        }


        private void tipoHabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Int32.TryParse(this.comboBoxTipoHab.Text, out this.codigoTipoHab);
            }
            catch (System.Exception ex)
            {
                return;
            }
        }

        private void fillByTipoHabToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.tIPOS_HABITACIONTableAdapter.FillByTipoHab(this.gD1C2018DataSet.TIPOS_HABITACION);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void radioBotonInterior_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ListadoHabitaciones formHotel = new ListadoHabitaciones(idHotel);
            //formHotel.ShowDialog();
        }
    }
}
