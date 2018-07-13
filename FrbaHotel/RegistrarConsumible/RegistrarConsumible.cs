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
using FrbaHotel.RegistrarEstadia;

namespace FrbaHotel.RegistrarConsumible
{
    public partial class RegistrarConsumible : Form
    {
        SqlConnection baseDeDatos;
        private string numeroDeReserva;
        bool isAllInclusive;

        public RegistrarConsumible(string numeroReserva)
        {
            InitializeComponent();
            baseDeDatos = ConexionBD.conectar();
            this.dataGridView1.AllowUserToAddRows = false;
            isAllInclusive = false;
            numeroDeReserva = numeroReserva;
            obtenerRegimenes();
        }

        public void agregarConsumible(string codigo, string producto, string precio)
        {
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[0].Value = codigo;
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[1].Value = producto;
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[2].Value = precio;
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[3].Value = 1;
            if (isAllInclusive)
            {
                actualizarAllInclusive();
            }
                    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Consumibles(this).ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            baseDeDatos.Open();
            int numeroFactura = 0;
            try
            {
                String queryNumeroFactura = "SELECT MAX(NUMERO_FACTURA) + 1 FROM LOS_MAGIOS.FACTURA";
                numeroFactura = (int)(new SqlCommand(queryNumeroFactura, baseDeDatos).ExecuteScalar());

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw new Exception();
            }
            if (isAllInclusive)actualizarAllInclusive();
            SqlTransaction transaction = baseDeDatos.BeginTransaction();
            try
            {
                
                SqlCommand commandFactura = new SqlCommand("INSERT INTO LOS_MAGIOS.FACTURA(NUMERO_FACTURA, CODIGO_RESERVA, FECHA_FACTURA,"
                + " TOTAL_FACTURA, INCONSISTENTE) VALUES(@nroFactura, @codReserva, @fecha, @total, 0)", baseDeDatos);
                commandFactura.Connection = baseDeDatos;
                commandFactura.Transaction = transaction;
                commandFactura.Parameters.Add("@nroFactura", SqlDbType.Int);
                commandFactura.Parameters.Add("@codReserva", SqlDbType.Int);
                commandFactura.Parameters.Add("@fecha", SqlDbType.Date);
                commandFactura.Parameters.Add("@total", SqlDbType.Decimal);

                commandFactura.Parameters["@nroFactura"].Value = numeroFactura;
                commandFactura.Parameters["@codReserva"].Value = numeroDeReserva;
                commandFactura.Parameters["@fecha"].Value = Program.fechaHoy;
                commandFactura.Parameters["@total"].Value = calcularTotal();
                commandFactura.ExecuteNonQuery();

                commandFactura = new SqlCommand("SELECT MAX(ID_ITEM_FACTURA) + 1 FROM LOS_MAGIOS.ITEM_FACTURA ", baseDeDatos);
                commandFactura.Connection = baseDeDatos;
                commandFactura.Transaction = transaction;
                int lastItem = (int)commandFactura.ExecuteScalar();

                foreach (DataGridViewRow row in this.dataGridView1.Rows)
                {
                    if(row.Index == 0)
                    {
                        commandFactura = new SqlCommand("INSERT INTO LOS_MAGIOS.ITEM_FACTURA(NUMERO_FACTURA, CANTIDAD, PRECIO_UNIDAD"
                            + ") VALUES(@nroFactura, @cantidad, @precio)", baseDeDatos);
                    }
                    else{
                    commandFactura = new SqlCommand("INSERT INTO LOS_MAGIOS.ITEM_FACTURA(NUMERO_FACTURA, CANTIDAD, PRECIO_UNIDAD,"
                            + " CODIGO_CONSUMIBLE) VALUES(@nroFactura, @cantidad, @precio, @codConsumible)", baseDeDatos);
                        commandFactura.Parameters.Add("@codConsumible", SqlDbType.Int);
                        commandFactura.Parameters["@codConsumible"].Value = Convert.ToInt32(row.Cells[0].Value);
                    }
                        
                        commandFactura.Connection = baseDeDatos;
                        commandFactura.Transaction = transaction;
                        commandFactura.Parameters.Add("@nroFactura", SqlDbType.Int);
                        commandFactura.Parameters.Add("@cantidad", SqlDbType.Int);
                        commandFactura.Parameters.Add("@precio", SqlDbType.Decimal);
                        commandFactura.Parameters["@nroFactura"].Value = numeroFactura;
                        commandFactura.Parameters["@cantidad"].Value = Convert.ToInt32(row.Cells[3].Value);
                        commandFactura.Parameters["@precio"].Value = Convert.ToDecimal(row.Cells[2].Value);
                                  
                        commandFactura.ExecuteNonQuery();
                        lastItem++;
                    

                }
                transaction.Commit();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                Console.WriteLine(exc.Message + " " + exc.StackTrace);
                transaction.Rollback();
            }
            finally
            {
                baseDeDatos.Close();
            }
            DialogResult dialogResult = MessageBox.Show("Factura numero "+ numeroFactura + " realizada. Se procede a efectuar el pago de la misma", "Atencion", MessageBoxButtons.OK);
            if (dialogResult == DialogResult.OK)
            {
                new Facturacion(numeroFactura).ShowDialog();
            }
            this.Hide();
            this.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                this.dataGridView1.Rows.RemoveAt(row.Index);
            }
        }

        private decimal calcularTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                total += Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[3].Value);
            }

            return total;
        }

        private void actualizarAllInclusive()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in this.dataGridView1.Rows)
            {
                if (row.Index != 0 && row.Index != 1)
                {
                    total += Convert.ToDecimal(row.Cells[2].Value) * Convert.ToDecimal(row.Cells[3].Value);
            
                }
            }
            this.dataGridView1.Rows[1].Cells[2].Value = total * -1;
        }

        private void obtenerRegimenes()
        {
            this.baseDeDatos.Open();
            SqlCommand query = new SqlCommand("SELECT b.DESCRIPCION, (SELECT DATEDIFF(day, FECHA_INGRESO, FECHA_EGRESO)+1 FROM LOS_MAGIOS.ESTADIAS WHERE CODIGO_RESERVA =@codReserva)*"+
"PRECIO_DOLARES B, (SELECT COUNT(*) FROM LOS_MAGIOS.CLIENTES_POR_RESERVA WHERE CODIGO_RESERVA=@codReserva), b.CODIGO_REGIMEN FROM LOS_MAGIOS.REGIMENES b, LOS_MAGIOS.RESERVAS c WHERE c.CODIGO_RESERVA=@codReserva AND b.CODIGO_REGIMEN = c.CODIGO_REGIMEN", baseDeDatos);
            query.Parameters.Add("@codReserva", SqlDbType.Int);
            query.Parameters["@codReserva"].Value = numeroDeReserva;
            SqlDataReader reader = query.ExecuteReader();
            reader.Read();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[0].Cells[0].Value = numeroDeReserva;
            this.dataGridView1.Rows[0].Cells[1].Value = reader[0].ToString();
            this.dataGridView1.Rows[0].Cells[2].Value = reader[1].ToString();
            this.dataGridView1.Rows[0].Cells[3].Value = reader[2].ToString();
            if (Convert.ToInt32(reader[3])== 4)
            {
                isAllInclusive = true;
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[1].Cells[0].Value = 1;
                this.dataGridView1.Rows[1].Cells[1].Value = "BENEFICIOS ALL INCLUSIVE";
                this.dataGridView1.Rows[1].Cells[2].Value = 0;
                this.dataGridView1.Rows[1].Cells[3].Value = 1;

            }
            reader.Close();
            this.baseDeDatos.Close();

        }
    }
}
