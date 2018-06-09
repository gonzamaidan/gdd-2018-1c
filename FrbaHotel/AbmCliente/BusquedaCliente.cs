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

namespace FrbaHotel.AbmCliente
{
    
    public partial class BusquedaCliente : Form
    {
        SqlConnection baseDeDatos;
        Int32 tipoIdentificacion = -1;
        Int32 identificacion = -1;
        String email;
        public BusquedaCliente(bool editable)
        {
            this.baseDeDatos = ConexionBD.conectar();
            InitializeComponent();
            this.modificarClienteBtn.Visible = editable;
            this.modificarClienteBtn.Enabled = editable;
        }

        private void BusquedaCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gD1C2018DataSet.TIPOS_IDENTIFICACION' table. You can move, or remove it, as needed.
            this.tIPOS_IDENTIFICACIONTableAdapter.Fill(this.gD1C2018DataSet.TIPOS_IDENTIFICACION);
        }

        private void tipoIdentificacionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.tipoIdentificacionComboBox.SelectedValue != null) this.tipoIdentificacion = (int) this.tipoIdentificacionComboBox.SelectedValue;
        }

        private void buscarClienteBtn_Click(object sender, EventArgs e)
        {

        }


    }
}
