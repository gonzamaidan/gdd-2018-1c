namespace FrbaHotel.GenerarModificacionReserva
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textoFechaReserva = new System.Windows.Forms.Label();
            this.textoHasta = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textoReservar_Desde = new System.Windows.Forms.Label();
            this.textoCantidadHuespedes = new System.Windows.Forms.Label();
            this.textoTipoRegimen = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textoCostoDia = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonGenerarReserva = new System.Windows.Forms.Button();
            this.botonModificarReserva = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(212, 74);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(546, 74);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 1;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(212, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 261);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // textoFechaReserva
            // 
            this.textoFechaReserva.AutoSize = true;
            this.textoFechaReserva.Location = new System.Drawing.Point(23, 45);
            this.textoFechaReserva.Name = "textoFechaReserva";
            this.textoFechaReserva.Size = new System.Drawing.Size(183, 13);
            this.textoFechaReserva.TabIndex = 4;
            this.textoFechaReserva.Text = "Fecha en la que se realizo la reserva:";
            // 
            // textoHasta
            // 
            this.textoHasta.AutoSize = true;
            this.textoHasta.Location = new System.Drawing.Point(486, 79);
            this.textoHasta.Name = "textoHasta";
            this.textoHasta.Size = new System.Drawing.Size(35, 13);
            this.textoHasta.TabIndex = 5;
            this.textoHasta.Text = "Hasta";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(648, 319);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textoReservar_Desde
            // 
            this.textoReservar_Desde.AutoSize = true;
            this.textoReservar_Desde.Location = new System.Drawing.Point(23, 79);
            this.textoReservar_Desde.Name = "textoReservar_Desde";
            this.textoReservar_Desde.Size = new System.Drawing.Size(84, 13);
            this.textoReservar_Desde.TabIndex = 7;
            this.textoReservar_Desde.Text = "Reservar Desde";
            this.textoReservar_Desde.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoCantidadHuespedes
            // 
            this.textoCantidadHuespedes.AutoSize = true;
            this.textoCantidadHuespedes.Location = new System.Drawing.Point(23, 264);
            this.textoCantidadHuespedes.Name = "textoCantidadHuespedes";
            this.textoCantidadHuespedes.Size = new System.Drawing.Size(119, 13);
            this.textoCantidadHuespedes.TabIndex = 8;
            this.textoCantidadHuespedes.Text = "Cantidad de huespedes";
            // 
            // textoTipoRegimen
            // 
            this.textoTipoRegimen.AutoSize = true;
            this.textoTipoRegimen.Location = new System.Drawing.Point(23, 322);
            this.textoTipoRegimen.Name = "textoTipoRegimen";
            this.textoTipoRegimen.Size = new System.Drawing.Size(83, 13);
            this.textoTipoRegimen.TabIndex = 9;
            this.textoTipoRegimen.Text = "Tipo de regimen";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(212, 319);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(248, 21);
            this.comboBox2.TabIndex = 10;
            // 
            // textoCostoDia
            // 
            this.textoCostoDia.AutoSize = true;
            this.textoCostoDia.Location = new System.Drawing.Point(543, 322);
            this.textoCostoDia.Name = "textoCostoDia";
            this.textoCostoDia.Size = new System.Drawing.Size(69, 13);
            this.textoCostoDia.TabIndex = 11;
            this.textoCostoDia.Text = "Costo por dia";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // botonGenerarReserva
            // 
            this.botonGenerarReserva.Location = new System.Drawing.Point(810, 35);
            this.botonGenerarReserva.Name = "botonGenerarReserva";
            this.botonGenerarReserva.Size = new System.Drawing.Size(101, 23);
            this.botonGenerarReserva.TabIndex = 13;
            this.botonGenerarReserva.Text = "Generar Reserva";
            this.botonGenerarReserva.UseVisualStyleBackColor = true;
            // 
            // botonModificarReserva
            // 
            this.botonModificarReserva.Location = new System.Drawing.Point(810, 74);
            this.botonModificarReserva.Name = "botonModificarReserva";
            this.botonModificarReserva.Size = new System.Drawing.Size(101, 23);
            this.botonModificarReserva.TabIndex = 14;
            this.botonModificarReserva.Text = "Modificar Reserva";
            this.botonModificarReserva.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(810, 112);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(101, 23);
            this.botonSalir.TabIndex = 15;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 538);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonModificarReserva);
            this.Controls.Add(this.botonGenerarReserva);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textoCostoDia);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textoTipoRegimen);
            this.Controls.Add(this.textoCantidadHuespedes);
            this.Controls.Add(this.textoReservar_Desde);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textoHasta);
            this.Controls.Add(this.textoFechaReserva);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.Text = "Menu de reservas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label textoFechaReserva;
        private System.Windows.Forms.Label textoHasta;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label textoReservar_Desde;
        private System.Windows.Forms.Label textoCantidadHuespedes;
        private System.Windows.Forms.Label textoTipoRegimen;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label textoCostoDia;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonGenerarReserva;
        private System.Windows.Forms.Button botonModificarReserva;
        private System.Windows.Forms.Button botonSalir;
    }
}