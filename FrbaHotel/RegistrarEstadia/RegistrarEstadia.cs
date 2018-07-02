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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class RegistrarEstadia : Form
    {
        SqlConnection baseDeDatos;

        public RegistrarEstadia()
        {
            baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDeDatos.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM LOS_MAGIOS.RESERVAS WHERE CODIGO_RESERVA = @codReserva AND FECHA_DESDE = '2017-01-01'", baseDeDatos);
                query.Parameters.Add("@codReserva", SqlDbType.Int);
                query.Parameters["@codReserva"].Value = this.textBox1.Text;
                int reserva = (int)query.ExecuteScalar();
                MessageBox.Show(reserva.ToString());

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

        private void botonConsumibles_Click(object sender, EventArgs e)
        {
            try
            {
                this.baseDeDatos.Open();
                SqlCommand query = new SqlCommand("SELECT * FROM LOS_MAGIOS.RESERVAS WHERE CODIGO_RESERVA = @codReserva AND FECHA_DESDE = '2017-01-01'", baseDeDatos);
                query.Parameters.Add("@codReserva", SqlDbType.Int);
                query.Parameters["@codReserva"].Value = this.textBox1.Text;
                int reserva = (int)query.ExecuteScalar();
                new RegistrarConsumible.RegistrarConsumible(this.textBox1.Text).ShowDialog();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.StackTrace);
                MessageBox.Show("No Existe el numero de reserva ingresado");
            }
            finally
            {
                this.baseDeDatos.Close();
            }
            
            
        }



    }
}