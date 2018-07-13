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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class Facturacion : Form
    {
        SqlConnection baseDeDatos;
        private static int numFactura;

        public Facturacion(int numeroFactura)
        {
            InitializeComponent();
            numFactura = numeroFactura;
            baseDeDatos = ConexionBD.conectar();
            getTotal(numFactura);
            getFormasDePago();
            this.textBox1.Enabled = false;
            this.label3.Hide();
            this.label4.Hide();
            this.textBox2.Hide();
            this.textBox3.Hide();
        }

        private void getTotal(int numeroFactura){
            this.baseDeDatos.Open();
            SqlCommand query = new SqlCommand("SELECT ISNULL(SUM(PRECIO_UNIDAD*CANTIDAD),0) FROM LOS_MAGIOS.ITEM_FACTURA WHERE NUMERO_FACTURA=@nroFactura", baseDeDatos);
            query.Parameters.Add("@nroFactura", SqlDbType.Int);
            query.Parameters["@nroFactura"].Value = numeroFactura;
            this.textBox1.Text = ((Decimal)query.ExecuteScalar()).ToString();
            this.baseDeDatos.Close();
        }

        private void getFormasDePago(){
            this.baseDeDatos.Open();
            SqlCommand query = new SqlCommand("SELECT CODIGO_PAGO, DESCRIPCION_PAGO FROM LOS_MAGIOS.FORMAS_DE_PAGO", baseDeDatos);
            SqlDataReader reader;

            reader = query.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CODIGO_PAGO", typeof(int));
            dt.Columns.Add("DESCRIPCION_PAGO", typeof(string));
            dt.Load(reader);

            this.comboBox1.ValueMember = "CODIGO_PAGO";
            this.comboBox1.DisplayMember = "DESCRIPCION_PAGO";
            this.comboBox1.DataSource = dt;

            baseDeDatos.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 1 || this.comboBox1.SelectedIndex == 2)
            {
                this.label3.Show();
                this.label4.Show();
                this.textBox2.Show();
                this.textBox3.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.baseDeDatos.Open();
            try
            {
                SqlCommand commandItemPago = new SqlCommand("INSERT INTO LOS_MAGIOS.ITEM_PAGO(CODIGO_PAGO, NUMERO_FACTURA, NUMERO_TARJETA, VENCIMIENTO_TARJETA)"
                + " VALUES(@codPago, @nroFactura, @nroTarjeta, @vencTarjeta)", baseDeDatos);
                commandItemPago.Parameters.Add("@nroFactura", SqlDbType.Int);
                commandItemPago.Parameters.Add("@codPago", SqlDbType.Int);
                commandItemPago.Parameters.Add("@nroTarjeta", SqlDbType.VarChar);
                commandItemPago.Parameters.Add("@vencTarjeta", SqlDbType.VarChar);

                commandItemPago.Parameters["@nroFactura"].Value = numFactura;
                commandItemPago.Parameters["@codPago"].Value = this.comboBox1.SelectedIndex+1;
                commandItemPago.Parameters["@nroTarjeta"].Value = this.textBox2.Text;
                commandItemPago.Parameters["@vencTarjeta"].Value = this.textBox3.Text;
                commandItemPago.ExecuteNonQuery();
                MessageBox.Show("Pago registrado con exito!");
                this.Close();
           }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo registrar el pago");
                Console.WriteLine(exc.Message + " " + exc.StackTrace);
            }
            finally
            {
                baseDeDatos.Close();
            }


            

        }

    }
}
