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

namespace FrbaHotel.RegistrarConsumible
{
    public partial class Consumibles : Form
    {
        SqlConnection baseDeDatos;
        private RegistrarConsumible registrarConsumible;

        public Consumibles(RegistrarConsumible formRegistrarConsumible)
        {
            baseDeDatos = ConexionBD.conectar();
            registrarConsumible = formRegistrarConsumible;
            InitializeComponent();
            actualizarTabla();
            this.dataGridView1.AllowUserToAddRows = false;
            this.button4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.registrarConsumible.agregarConsumible(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDeDatos.Open();
                SqlCommand updateConsumible = new SqlCommand("UPDATE LOS_MAGIOS.CONSUMIBLES SET DESCRIPCION = @descripcion, PRECIO_CONSUMIBLE = @precioConsumible " +
                                                              "WHERE CODIGO_CONSUMIBLE = @CodigoConsumible", baseDeDatos);
                updateConsumible.Parameters.Add("@descripcion", SqlDbType.VarChar);
                updateConsumible.Parameters.Add("@precioConsumible", SqlDbType.Decimal);
                updateConsumible.Parameters.Add("@CodigoConsumible", SqlDbType.Int);
                updateConsumible.Parameters["@CodigoConsumible"].Value = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                updateConsumible.Parameters["@descripcion"].Value = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                updateConsumible.Parameters["@precioConsumible"].Value = Convert.ToDecimal(this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString());

                updateConsumible.ExecuteNonQuery();

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.baseDeDatos.Close();
                actualizarTabla();
            }
        }

        public void actualizarTabla()
        {
            this.dataGridView1.Rows.Clear();
            try
            {
                this.baseDeDatos.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM LOS_MAGIOS.CONSUMIBLES", baseDeDatos);
                SqlDataReader reader = query.ExecuteReader();
                int cont = 0;
                while (reader.Read())
                {
                    this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[cont].Cells[0].Value = reader[0].ToString();
                    this.dataGridView1.Rows[cont].Cells[1].Value = reader[1].ToString();
                    this.dataGridView1.Rows[cont].Cells[2].Value = reader[2].ToString();
                    cont++;
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Hide();
            this.button2.Hide();
            this.dataGridView1.Rows.Add();
            this.baseDeDatos.Open();
            try
            {
                String queryCodigoConsumible = "SELECT MAX(CODIGO_CONSUMIBLE) + 1 FROM LOS_MAGIOS.CONSUMIBLES";
                int codigoReserva = (int)(new SqlCommand(queryCodigoConsumible, baseDeDatos).ExecuteScalar());
                this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[0].Value = codigoReserva;
                this.button4.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDeDatos.Open();
                int pos = this.dataGridView1.Rows.Count - 1;
                SqlCommand comandIngresarConsumible = new SqlCommand("INSERT INTO LOS_MAGIOS.CONSUMIBLES(CODIGO_CONSUMIBLE, DESCRIPCION, PRECIO_CONSUMIBLE) VALUES (@codigo, @descripcion, @precio)", baseDeDatos);
                comandIngresarConsumible.Parameters.Add("@descripcion", SqlDbType.VarChar);
                comandIngresarConsumible.Parameters.Add("@precio", SqlDbType.Decimal);
                comandIngresarConsumible.Parameters.Add("@codigo", SqlDbType.Int);
                comandIngresarConsumible.Parameters["@codigo"].Value = this.dataGridView1.Rows[pos].Cells[0].Value.ToString();
                comandIngresarConsumible.Parameters["@descripcion"].Value = this.dataGridView1.Rows[pos].Cells[1].Value.ToString();
                comandIngresarConsumible.Parameters["@precio"].Value = Convert.ToDecimal(this.dataGridView1.Rows[pos].Cells[2].Value.ToString());
                comandIngresarConsumible.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show(exc.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.baseDeDatos.Close();
                this.button4.Hide();
                this.button3.Show();
                this.button2.Show();
            }
        }
    }
}
