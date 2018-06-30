namespace FrbaHotel.GenerarModificacionReserva
{
    partial class GenerarReservas
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
            this.components = new System.ComponentModel.Container();
            this.calendarDesde = new System.Windows.Forms.MonthCalendar();
            this.calendarHasta = new System.Windows.Forms.MonthCalendar();
            this.textoHasta = new System.Windows.Forms.Label();
            this.textoReservar_Desde = new System.Windows.Forms.Label();
            this.textoCantidadHuespedes = new System.Windows.Forms.Label();
            this.regimenesComboBox = new System.Windows.Forms.ComboBox();
            this.rEGIMENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.botonBuscarDisponibilidad = new System.Windows.Forms.Button();
            this.rEGIMENESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.REGIMENESTableAdapter();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.generarReservaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // calendarDesde
            // 
            this.calendarDesde.Location = new System.Drawing.Point(173, 35);
            this.calendarDesde.MaxSelectionCount = 1;
            this.calendarDesde.Name = "calendarDesde";
            this.calendarDesde.TabIndex = 0;
            this.calendarDesde.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.calendarDesde.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // calendarHasta
            // 
            this.calendarHasta.Location = new System.Drawing.Point(546, 35);
            this.calendarHasta.MaxSelectionCount = 1;
            this.calendarHasta.Name = "calendarHasta";
            this.calendarHasta.TabIndex = 1;
            this.calendarHasta.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // textoHasta
            // 
            this.textoHasta.AutoSize = true;
            this.textoHasta.Location = new System.Drawing.Point(486, 40);
            this.textoHasta.Name = "textoHasta";
            this.textoHasta.Size = new System.Drawing.Size(35, 13);
            this.textoHasta.TabIndex = 5;
            this.textoHasta.Text = "Hasta";
            // 
            // textoReservar_Desde
            // 
            this.textoReservar_Desde.AutoSize = true;
            this.textoReservar_Desde.Location = new System.Drawing.Point(23, 40);
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
            // regimenesComboBox
            // 
            this.regimenesComboBox.CausesValidation = false;
            this.regimenesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.rEGIMENESBindingSource, "CODIGO_REGIMEN", true));
            this.regimenesComboBox.DataSource = this.rEGIMENESBindingSource;
            this.regimenesComboBox.DisplayMember = "DESCRIPCION";
            this.regimenesComboBox.FormattingEnabled = true;
            this.regimenesComboBox.Location = new System.Drawing.Point(173, 304);
            this.regimenesComboBox.Name = "regimenesComboBox";
            this.regimenesComboBox.Size = new System.Drawing.Size(193, 21);
            this.regimenesComboBox.TabIndex = 10;
            this.regimenesComboBox.ValueMember = "CODIGO_REGIMEN";
            this.regimenesComboBox.SelectedIndexChanged += new System.EventHandler(this.regimenesComboBox_SelectedIndexChanged);
            // 
            // rEGIMENESBindingSource
            // 
            this.rEGIMENESBindingSource.DataMember = "REGIMENES";
            this.rEGIMENESBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 373);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(870, 150);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // botonBuscarDisponibilidad
            // 
            this.botonBuscarDisponibilidad.Location = new System.Drawing.Point(810, 35);
            this.botonBuscarDisponibilidad.Name = "botonBuscarDisponibilidad";
            this.botonBuscarDisponibilidad.Size = new System.Drawing.Size(101, 23);
            this.botonBuscarDisponibilidad.TabIndex = 13;
            this.botonBuscarDisponibilidad.Text = "Buscar";
            this.botonBuscarDisponibilidad.UseVisualStyleBackColor = true;
            this.botonBuscarDisponibilidad.Click += new System.EventHandler(this.botonBuscarDisponibilidad_Click);
            // 
            // rEGIMENESTableAdapter
            // 
            this.rEGIMENESTableAdapter.ClearBeforeFill = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(173, 262);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 16;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(26, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Indicar regimen";
            this.checkBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(546, 259);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Tipo de habitacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Precio por regimen";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(546, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 21;
            // 
            // generarReservaButton
            // 
            this.generarReservaButton.Location = new System.Drawing.Point(26, 530);
            this.generarReservaButton.Name = "generarReservaButton";
            this.generarReservaButton.Size = new System.Drawing.Size(75, 23);
            this.generarReservaButton.TabIndex = 22;
            this.generarReservaButton.Text = "Generar reserva";
            this.generarReservaButton.UseVisualStyleBackColor = true;
            this.generarReservaButton.Click += new System.EventHandler(this.generarReservaButton_Click);
            // 
            // GenerarReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 565);
            this.Controls.Add(this.generarReservaButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.botonBuscarDisponibilidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.regimenesComboBox);
            this.Controls.Add(this.textoCantidadHuespedes);
            this.Controls.Add(this.textoReservar_Desde);
            this.Controls.Add(this.textoHasta);
            this.Controls.Add(this.calendarHasta);
            this.Controls.Add(this.calendarDesde);
            this.Name = "GenerarReservas";
            this.RightToLeftLayout = true;
            this.Text = "Menu de reservas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar calendarDesde;
        private System.Windows.Forms.MonthCalendar calendarHasta;
        private System.Windows.Forms.Label textoHasta;
        private System.Windows.Forms.Label textoReservar_Desde;
        private System.Windows.Forms.Label textoCantidadHuespedes;
        private System.Windows.Forms.ComboBox regimenesComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button botonBuscarDisponibilidad;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource rEGIMENESBindingSource;
        private GD1C2018DataSetTableAdapters.REGIMENESTableAdapter rEGIMENESTableAdapter;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button generarReservaButton;
    }
}