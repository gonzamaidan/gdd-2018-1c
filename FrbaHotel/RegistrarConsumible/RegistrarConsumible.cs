﻿using System;
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
    public partial class RegistrarConsumible : Form
    {
        SqlConnection baseDeDatos;
        private string numeroDeReserva;

        public RegistrarConsumible(string numeroReserva)
        {
            InitializeComponent();
            baseDeDatos = ConexionBD.conectar();
            this.dataGridView1.AllowUserToAddRows = false;
            numeroDeReserva = numeroReserva;
        }

        public void agregarConsumible(string codigo, string producto, string precio)
        {
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[0].Value = codigo;
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[1].Value = producto;
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count-1].Cells[2].Value = precio;
            this.dataGridView1.Rows[this.dataGridView1.Rows.Count - 1].Cells[3].Value = 0;         
                    
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
                
            }catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw new Exception();
            }

            SqlTransaction transaction = baseDeDatos.BeginTransaction();
            try
            {
                SqlCommand commandFactura = new SqlCommand("INSERT INTO LOS_MAGIOS.FACTURA(NUMERO_FACTURA, CODIGO_RESERVA, FECHA_FACTURA,"
                +" TOTAL_FACTURA, INCONSISTENTE) VALUES(@nroFactura, @codReserva, @fecha, @total, 1)", baseDeDatos);
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
                    commandFactura = new SqlCommand("INSERT INTO LOS_MAGIOS.ITEM_FACTURA(NUMERO_FACTURA, CANTIDAD, PRECIO_UNIDAD,"
                + " CODIGO_CONSUMIBLE) VALUES(@nroFactura, @cantidad, @precio, @codConsumible)", baseDeDatos);
                    commandFactura.Connection = baseDeDatos;
                    commandFactura.Transaction = transaction;
                    //commandFactura.Parameters.Add("@idItem", SqlDbType.Int);
                    commandFactura.Parameters.Add("@nroFactura", SqlDbType.Int);
                    commandFactura.Parameters.Add("@cantidad", SqlDbType.Int);
                    commandFactura.Parameters.Add("@precio", SqlDbType.Decimal);
                    commandFactura.Parameters.Add("@codConsumible", SqlDbType.Int);
                    //commandFactura.Parameters["@idItem"].Value = lastItem;
                    commandFactura.Parameters["@nroFactura"].Value = numeroFactura;
                    commandFactura.Parameters["@cantidad"].Value = Convert.ToInt32(row.Cells[3].Value);
                    commandFactura.Parameters["@precio"].Value = Convert.ToDecimal(row.Cells[2].Value);
                    commandFactura.Parameters["@codConsumible"].Value =Convert.ToInt32(row.Cells[0].Value);
                    commandFactura.ExecuteNonQuery();
                    lastItem++;
                }



                transaction.Commit();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                transaction.Rollback();
            }


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
    }
}