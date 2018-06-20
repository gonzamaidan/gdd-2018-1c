namespace FrbaHotel.AbmHabitacion
{
    partial class FormNewHabitacion
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
            this.botonGuardar = new System.Windows.Forms.Button();
            this.comboBoxTipoHab = new System.Windows.Forms.ComboBox();
            this.tIPOSHABITACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.botonSalir = new System.Windows.Forms.Button();
            this.textoPisoDentroDelHotel = new System.Windows.Forms.Label();
            this.textoUbicacionEnElHotel = new System.Windows.Forms.Label();
            this.textoTipoHabitacion = new System.Windows.Forms.Label();
            this.textNumeroHab = new System.Windows.Forms.TextBox();
            this.radioBotonInterior = new System.Windows.Forms.RadioButton();
            this.radioBotonExterior = new System.Windows.Forms.RadioButton();
            this.tIPOS_HABITACIONTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.TIPOS_HABITACIONTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.textoPisoHab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSHABITACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(357, 27);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(88, 23);
            this.botonGuardar.TabIndex = 3;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // comboBoxTipoHab
            // 
            this.comboBoxTipoHab.DataSource = this.tIPOSHABITACIONBindingSource;
            this.comboBoxTipoHab.DisplayMember = "CODIGO_TIPO_HABITACION";
            this.comboBoxTipoHab.FormattingEnabled = true;
            this.comboBoxTipoHab.Location = new System.Drawing.Point(74, 164);
            this.comboBoxTipoHab.Name = "comboBoxTipoHab";
            this.comboBoxTipoHab.Size = new System.Drawing.Size(172, 21);
            this.comboBoxTipoHab.TabIndex = 4;
            this.comboBoxTipoHab.ValueMember = "DESCRIPCION_TIPO_HABITACION";
            this.comboBoxTipoHab.SelectedIndexChanged += new System.EventHandler(this.tipoHabComboBox_SelectedIndexChanged);
            // 
            // tIPOSHABITACIONBindingSource
            // 
            this.tIPOSHABITACIONBindingSource.DataMember = "TIPOS_HABITACION";
            this.tIPOSHABITACIONBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(357, 65);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(88, 23);
            this.botonSalir.TabIndex = 7;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // textoPisoDentroDelHotel
            // 
            this.textoPisoDentroDelHotel.AutoSize = true;
            this.textoPisoDentroDelHotel.Location = new System.Drawing.Point(12, 76);
            this.textoPisoDentroDelHotel.Name = "textoPisoDentroDelHotel";
            this.textoPisoDentroDelHotel.Size = new System.Drawing.Size(60, 26);
            this.textoPisoDentroDelHotel.TabIndex = 8;
            this.textoPisoDentroDelHotel.Text = "Piso dentro\r\ndel hotel";
            // 
            // textoUbicacionEnElHotel
            // 
            this.textoUbicacionEnElHotel.AutoSize = true;
            this.textoUbicacionEnElHotel.Location = new System.Drawing.Point(12, 119);
            this.textoUbicacionEnElHotel.Name = "textoUbicacionEnElHotel";
            this.textoUbicacionEnElHotel.Size = new System.Drawing.Size(56, 26);
            this.textoUbicacionEnElHotel.TabIndex = 9;
            this.textoUbicacionEnElHotel.Text = "Ubicacion\r\nen el hotel";
            // 
            // textoTipoHabitacion
            // 
            this.textoTipoHabitacion.AutoSize = true;
            this.textoTipoHabitacion.Location = new System.Drawing.Point(12, 167);
            this.textoTipoHabitacion.Name = "textoTipoHabitacion";
            this.textoTipoHabitacion.Size = new System.Drawing.Size(58, 26);
            this.textoTipoHabitacion.TabIndex = 10;
            this.textoTipoHabitacion.Text = "Tipo de\r\nHabitacion";
            // 
            // textNumeroHab
            // 
            this.textNumeroHab.Location = new System.Drawing.Point(74, 30);
            this.textNumeroHab.Name = "textNumeroHab";
            this.textNumeroHab.Size = new System.Drawing.Size(100, 20);
            this.textNumeroHab.TabIndex = 12;
            // 
            // radioBotonInterior
            // 
            this.radioBotonInterior.AutoSize = true;
            this.radioBotonInterior.Location = new System.Drawing.Point(161, 117);
            this.radioBotonInterior.Name = "radioBotonInterior";
            this.radioBotonInterior.Size = new System.Drawing.Size(69, 17);
            this.radioBotonInterior.TabIndex = 15;
            this.radioBotonInterior.TabStop = true;
            this.radioBotonInterior.Text = "V/Interior";
            this.radioBotonInterior.UseVisualStyleBackColor = true;
            this.radioBotonInterior.CheckedChanged += new System.EventHandler(this.radioBotonInterior_CheckedChanged);
            this.radioBotonInterior.Click += new System.EventHandler(this.seleccionarUbicacionInterior);
            // 
            // radioBotonExterior
            // 
            this.radioBotonExterior.AutoSize = true;
            this.radioBotonExterior.Location = new System.Drawing.Point(74, 117);
            this.radioBotonExterior.Name = "radioBotonExterior";
            this.radioBotonExterior.Size = new System.Drawing.Size(72, 17);
            this.radioBotonExterior.TabIndex = 14;
            this.radioBotonExterior.TabStop = true;
            this.radioBotonExterior.Text = "V/Exterior";
            this.radioBotonExterior.UseVisualStyleBackColor = true;
            this.radioBotonExterior.Click += new System.EventHandler(this.seleccionarUbicacionExterior);
            // 
            // tIPOS_HABITACIONTableAdapter
            // 
            this.tIPOS_HABITACIONTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(464, 25);
            this.fillBy1ToolStrip.TabIndex = 19;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // textoPisoHab
            // 
            this.textoPisoHab.Location = new System.Drawing.Point(74, 82);
            this.textoPisoHab.Name = "textoPisoHab";
            this.textoPisoHab.Size = new System.Drawing.Size(100, 20);
            this.textoPisoHab.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero";
            // 
            // FormNewHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoPisoHab);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.radioBotonInterior);
            this.Controls.Add(this.radioBotonExterior);
            this.Controls.Add(this.textNumeroHab);
            this.Controls.Add(this.textoTipoHabitacion);
            this.Controls.Add(this.textoUbicacionEnElHotel);
            this.Controls.Add(this.textoPisoDentroDelHotel);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.comboBoxTipoHab);
            this.Controls.Add(this.botonGuardar);
            this.Name = "FormNewHabitacion";
            this.Text = "WS";
            this.Load += new System.EventHandler(this.FormNewHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSHABITACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.ComboBox comboBoxTipoHab;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label textoPisoDentroDelHotel;
        private System.Windows.Forms.Label textoUbicacionEnElHotel;
        private System.Windows.Forms.Label textoTipoHabitacion;
        private System.Windows.Forms.TextBox textNumeroHab;
        private System.Windows.Forms.RadioButton radioBotonInterior;
        private System.Windows.Forms.RadioButton radioBotonExterior;
        private System.Windows.Forms.TextBox textBoxPisoHab;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource tIPOSHABITACIONBindingSource;
        private GD1C2018DataSetTableAdapters.TIPOS_HABITACIONTableAdapter tIPOS_HABITACIONTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoPisoHab;
    }
}