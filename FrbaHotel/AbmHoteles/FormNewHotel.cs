using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FrbaHotel.AbmHoteles
{

    public partial class FormNewHotel : Form
    {
        List<string> _items = new List<string>();
        Boolean editar;
        Boolean regimenesCargados = false;
        SqlConnection baseDeDatos;
        Int32 id_hotel;
        DataTable dtRegimenesPorHotel;
        DataTable dtRegimenes;
        public static string fechaHoyString = ConfigurationManager.AppSettings["fechaHoy"];
        SqlTransaction tran;

        public FormNewHotel()
        {
            editar = false;
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
            buscarRegimenes();
        }

        private void buscarRegimenes()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From LOS_MAGIOS.REGIMENES", baseDeDatos);
            dtRegimenes = new DataTable();
            sda.Fill(dtRegimenes);
            foreach (DataRow item in dtRegimenes.Rows)
            {
                checkedListBox1.Items.Add(item[1]);
            }
            regimenesCargados = true;
        }

        private void buscarRegimenesPorHotel()
        {
            string consulta = "Select * From LOS_MAGIOS.REGIMENES_POR_HOTEL where ID_HOTEL = @id";
            SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
            comando2.Parameters.Add(new SqlParameter("@id", id_hotel));
            SqlDataAdapter sda = new SqlDataAdapter(comando2);
            dtRegimenesPorHotel = new DataTable();
            sda.Fill(dtRegimenesPorHotel);
            foreach (DataRow item in dtRegimenesPorHotel.Rows)
            {
                checkedListBox1.SetItemChecked(((Int32)item[1]) - 1, true);
            }
        }

        private void setearAdminHotel()
        {
            try
            {
                SqlCommand queryInsert = new SqlCommand("INSERT INTO LOS_MAGIOS.HOTELES_POR_USUARIO(ID_HOTEL,USUARIO)"
                                                 + "VALUES(@id_hotel, @usuario)", baseDeDatos, tran);

                queryInsert.CommandType = CommandType.StoredProcedure;
                queryInsert.Parameters.Clear();
                queryInsert.Parameters.Add(new SqlParameter("@id_hotel", id_hotel));
                queryInsert.Parameters.Add(new SqlParameter("@usuario", Program.sesion.getUsuario()));

                queryInsert.CommandType = CommandType.Text;
                queryInsert.ExecuteNonQuery();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }
        }

        private void setearRegimenes()
        {

            try
            {

                SqlCommand cmd = baseDeDatos.CreateCommand();
                cmd.Transaction = tran;
                cmd.CommandText = "DELETE FROM LOS_MAGIOS.REGIMENES_POR_HOTEL WHERE ID_HOTEL = @id_hotel";
                cmd.Parameters.AddWithValue("@id_hotel", id_hotel);
                cmd.ExecuteNonQuery();

                SqlCommand queryInsert = new SqlCommand("INSERT INTO LOS_MAGIOS.REGIMENES_POR_HOTEL(ID_HOTEL,CODIGO_REGIMEN)"
                                                 + "VALUES(@id_hotel, @codigoRegimen)", baseDeDatos, tran);

                foreach (object itemChecked in checkedListBox1.CheckedItems)
                {
                    foreach (DataRow item in dtRegimenes.Rows)
                    {
                        if (item[1].ToString().Equals(itemChecked.ToString()))
                        {
                            queryInsert.CommandType = CommandType.StoredProcedure;
                            queryInsert.Parameters.Clear();
                            queryInsert.Parameters.Add(new SqlParameter("@id_hotel", id_hotel));
                            queryInsert.Parameters.Add(new SqlParameter("@codigoRegimen", (Int32)item[0]));

                            queryInsert.CommandType = CommandType.Text;
                            queryInsert.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tran.Rollback();
            }
        }

        public FormNewHotel(Int32 id)
        {
            id_hotel = id;
            editar = true;
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();

            string consulta = "Select * From LOS_MAGIOS.HOTELES h Where h.id_hotel = @id";
            SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
            comando2.Parameters.Add(new SqlParameter("@id", id_hotel));
            SqlDataAdapter sda = new SqlDataAdapter(comando2);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                this.textBoxNombre.Text = item[1].ToString();
                this.textBoxMail.Text = item[2].ToString();
                this.textBoxTelefono.Text = item[3].ToString();
                this.textBoxDireccion.Text = item[4].ToString();
                this.numericUpDownEstrellas.Value = (Int32)item[5];
                this.textBoxCiudad.Text = item[6].ToString();
                this.textBoxPais.Text = item[7].ToString();
            }
            buscarRegimenes();
            buscarRegimenesPorHotel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeric;
            if (!int.TryParse(this.textBoxTelefono.Text, out numeric))
            {
                MessageBox.Show("El numero de telefono debe ser numericos. ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (verificarTextBoxNoVacios() || editar)
            {

                baseDeDatos.Open();
                if (!editar)
                {
                    string consulta = "Select * From LOS_MAGIOS.HOTELES h Where h.nombre = @Nombre";
                    SqlCommand comando2 = new SqlCommand(consulta, baseDeDatos);
                    comando2.Parameters.Add(new SqlParameter("@Nombre", this.textBoxNombre.Text));

                    SqlDataReader reader = comando2.ExecuteReader();

                    if (reader.HasRows)
                    {

                        MessageBox.Show("Ya existe una Hotel con este Nombre ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            tran = baseDeDatos.BeginTransaction();

            try
            {
                if (!editar)
                {
                    SqlCommand queryInsert = new SqlCommand("INSERT INTO LOS_MAGIOS.HOTELES(NOMBRE, MAIL, TELEFONO, DIRECCION, ESTRELLAS, CIUDAD, PAIS, FECHA_CREACION)"
                                                                 + "VALUES(@nombre, @mail, @telefono, @direccion, @estrellas, @ciudad, @pais, @fechaCreacion)", baseDeDatos);
                    queryInsert.Transaction = tran;

                    String queryCodigoReserva = "SELECT MAX(ID_HOTEL) + 1 FROM LOS_MAGIOS.HOTELES";

                    // else if (x == 1)
                    //    comando = new SqlCommand("AEFI.actualizar_Habitacion", conexion);
                    SqlCommand querymax = new SqlCommand(queryCodigoReserva, baseDeDatos);
                    querymax.Transaction = tran;
                    id_hotel = (int)(querymax.ExecuteScalar());


                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@nombre", this.textBoxNombre.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@mail", this.textBoxMail.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@telefono", this.textBoxTelefono.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@direccion", this.textBoxDireccion.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@estrellas", this.numericUpDownEstrellas.Value));
                    queryInsert.Parameters.Add(new SqlParameter("@ciudad", this.textBoxCiudad.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@pais", this.textBoxPais.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@fechaCreacion", DateTime.ParseExact(fechaHoyString, "yyyy-M-d", null)));

                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();
                    

                    //SqlDataReader reader = queryInsert.execute();
                    setearRegimenes();
                    setearAdminHotel();
                    MessageBox.Show("El Hotel se creo satisfactoriamente", "Habitacion Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand queryInsert = new SqlCommand("UPDATE LOS_MAGIOS.HOTELES " +
                                                            "SET NOMBRE = @nombre, MAIL = @mail, TELEFONO = @telefono, DIRECCION = @direccion, ESTRELLAS = @estrellas, CIUDAD = @ciudad, PAIS = @pais Where ID_HOTEL = @id", baseDeDatos);
                    queryInsert.Transaction = tran;
                    queryInsert.CommandType = CommandType.StoredProcedure;
                    queryInsert.Parameters.Add(new SqlParameter("@nombre", this.textBoxNombre.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@mail", this.textBoxMail.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@telefono", this.textBoxTelefono.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@direccion", this.textBoxDireccion.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@estrellas", this.numericUpDownEstrellas.Value));
                    queryInsert.Parameters.Add(new SqlParameter("@ciudad", this.textBoxCiudad.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@pais", this.textBoxPais.Text));
                    queryInsert.Parameters.Add(new SqlParameter("@id", id_hotel));
                    setearRegimenes();
                    queryInsert.CommandType = CommandType.Text;
                    queryInsert.ExecuteNonQuery();
                    MessageBox.Show("El Hotel se actualizo correctamente", "Habitacion Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception exc)
            {
                tran.Rollback();
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                tran.Commit();
                baseDeDatos.Close();
                this.Hide();
                BusquedaHotel busqedaHotel = new BusquedaHotel();
                busqedaHotel.ShowDialog();
            }

        }

        private void FormNewHotel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.REGIMENES' table. You can move, or remove it, as needed.
            this.rEGIMENESTableAdapter.Fill(this.gD1C2018DataSet.REGIMENES);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rEGIMENESTableAdapter.FillBy(this.gD1C2018DataSet.REGIMENES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.rEGIMENESTableAdapter.FillBy1(this.gD1C2018DataSet.REGIMENES);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if ("Unchecked".Equals(e.NewValue.ToString()) && regimenesCargados)
            {
                SqlCommand queryDisponibildad;
                String queryStringDisponibilidad = "SELECT * FROM LOS_MAGIOS.RESERVAS A where (A.FECHA_DESDE < @fecha AND A.FECHA_HASTA >  @fecha) and A.CODIGO_REGIMEN = @CodigoRegimen and (A.CODIGO_RESERVA IN (SELECT B.CODIGO_RESERVA FROM [GD1C2018].[LOS_MAGIOS].HABITACIONES_POR_RESERVA B WHERE A.CODIGO_RESERVA = B.CODIGO_RESERVA AND B.ID_HOTEL = @IdHotel))";
                queryDisponibildad = new SqlCommand(queryStringDisponibilidad, baseDeDatos);
                queryDisponibildad.Parameters.Add("@fecha", SqlDbType.Date);
                queryDisponibildad.Parameters.Add("@CodigoRegimen", SqlDbType.Int);
                queryDisponibildad.Parameters.Add("@IdHotel", SqlDbType.Int);
                queryDisponibildad.Parameters["@fecha"].Value = DateTime.ParseExact(fechaHoyString, "yyyy-M-d", null).Date;
                queryDisponibildad.Parameters["@CodigoRegimen"].Value = e.Index + 1;
                queryDisponibildad.Parameters["@IdHotel"].Value = id_hotel;

                SqlDataAdapter adapter = new SqlDataAdapter(queryDisponibildad);
                DataTable resultados = new DataTable();
                adapter.Fill(resultados);

                if (resultados.Rows.Count > 1)
                {
                    checkedListBox1.SetItemChecked(e.Index, true);
                    e.NewValue = e.CurrentValue;

                    MessageBox.Show("El hotel posee una reserva vigente para este regimen. No se puede eliminar.", "Habitacion Creada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BusquedaHotel busqedaHotel = new BusquedaHotel();
            busqedaHotel.ShowDialog();
        }

    }
}
