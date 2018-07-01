namespace FrbaHotel.AbmCliente
{
    partial class FormCliente
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.botonCrear = new System.Windows.Forms.Button();
            this.textoNombre = new System.Windows.Forms.Label();
            this.textoApellido = new System.Windows.Forms.Label();
            this.textoTipoDoc = new System.Windows.Forms.Label();
            this.textoMail = new System.Windows.Forms.Label();
            this.textoTelefono = new System.Windows.Forms.Label();
            this.textoDireccion = new System.Windows.Forms.Label();
            this.textoNacionalidad = new System.Windows.Forms.Label();
            this.textoFechaDeNacimiento = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxNroDoc = new System.Windows.Forms.TextBox();
            this.textBoxNacionalidad = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.comboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.tIPOSIDENTIFICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.textoNroDoc = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.tIPOS_IDENTIFICACIONTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter();
            this.buttonSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(94, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 0;
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(140, 407);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(124, 23);
            this.botonCrear.TabIndex = 1;
            this.botonCrear.Text = "Guardar";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoNombre
            // 
            this.textoNombre.AutoSize = true;
            this.textoNombre.Location = new System.Drawing.Point(35, 41);
            this.textoNombre.Name = "textoNombre";
            this.textoNombre.Size = new System.Drawing.Size(44, 13);
            this.textoNombre.TabIndex = 2;
            this.textoNombre.Text = "Nombre";
            // 
            // textoApellido
            // 
            this.textoApellido.AutoSize = true;
            this.textoApellido.Location = new System.Drawing.Point(228, 41);
            this.textoApellido.Name = "textoApellido";
            this.textoApellido.Size = new System.Drawing.Size(44, 13);
            this.textoApellido.TabIndex = 5;
            this.textoApellido.Text = "Apellido";
            // 
            // textoTipoDoc
            // 
            this.textoTipoDoc.AutoSize = true;
            this.textoTipoDoc.Location = new System.Drawing.Point(35, 83);
            this.textoTipoDoc.Name = "textoTipoDoc";
            this.textoTipoDoc.Size = new System.Drawing.Size(54, 13);
            this.textoTipoDoc.TabIndex = 6;
            this.textoTipoDoc.Text = "Tipo Doc.";
            // 
            // textoMail
            // 
            this.textoMail.AutoSize = true;
            this.textoMail.Location = new System.Drawing.Point(35, 128);
            this.textoMail.Name = "textoMail";
            this.textoMail.Size = new System.Drawing.Size(26, 13);
            this.textoMail.TabIndex = 7;
            this.textoMail.Text = "Mail";
            // 
            // textoTelefono
            // 
            this.textoTelefono.AutoSize = true;
            this.textoTelefono.Location = new System.Drawing.Point(35, 184);
            this.textoTelefono.Name = "textoTelefono";
            this.textoTelefono.Size = new System.Drawing.Size(49, 13);
            this.textoTelefono.TabIndex = 8;
            this.textoTelefono.Text = "Telefono";
            // 
            // textoDireccion
            // 
            this.textoDireccion.AutoSize = true;
            this.textoDireccion.Location = new System.Drawing.Point(35, 275);
            this.textoDireccion.Name = "textoDireccion";
            this.textoDireccion.Size = new System.Drawing.Size(52, 13);
            this.textoDireccion.TabIndex = 9;
            this.textoDireccion.Text = "Direccion";
            // 
            // textoNacionalidad
            // 
            this.textoNacionalidad.AutoSize = true;
            this.textoNacionalidad.Location = new System.Drawing.Point(229, 180);
            this.textoNacionalidad.Name = "textoNacionalidad";
            this.textoNacionalidad.Size = new System.Drawing.Size(69, 13);
            this.textoNacionalidad.TabIndex = 10;
            this.textoNacionalidad.Text = "Nacionalidad";
            // 
            // textoFechaDeNacimiento
            // 
            this.textoFechaDeNacimiento.AutoSize = true;
            this.textoFechaDeNacimiento.Location = new System.Drawing.Point(35, 318);
            this.textoFechaDeNacimiento.Name = "textoFechaDeNacimiento";
            this.textoFechaDeNacimiento.Size = new System.Drawing.Size(60, 26);
            this.textoFechaDeNacimiento.TabIndex = 11;
            this.textoFechaDeNacimiento.Text = "Fecha de\r\nNacimiento";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(306, 38);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 14;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(94, 128);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(312, 20);
            this.textBoxMail.TabIndex = 16;
            // 
            // textBoxNroDoc
            // 
            this.textBoxNroDoc.Location = new System.Drawing.Point(306, 80);
            this.textBoxNroDoc.Name = "textBoxNroDoc";
            this.textBoxNroDoc.Size = new System.Drawing.Size(100, 20);
            this.textBoxNroDoc.TabIndex = 15;
            // 
            // textBoxNacionalidad
            // 
            this.textBoxNacionalidad.Location = new System.Drawing.Point(306, 177);
            this.textBoxNacionalidad.Name = "textBoxNacionalidad";
            this.textBoxNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxNacionalidad.TabIndex = 19;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(93, 272);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(313, 20);
            this.textBoxDireccion.TabIndex = 18;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(94, 177);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 17;
            // 
            // comboBoxTipoDoc
            // 
            this.comboBoxTipoDoc.DataSource = this.tIPOSIDENTIFICACIONBindingSource;
            this.comboBoxTipoDoc.DisplayMember = "DESCRIPCION";
            this.comboBoxTipoDoc.FormattingEnabled = true;
            this.comboBoxTipoDoc.Location = new System.Drawing.Point(94, 80);
            this.comboBoxTipoDoc.Name = "comboBoxTipoDoc";
            this.comboBoxTipoDoc.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTipoDoc.TabIndex = 25;
            this.comboBoxTipoDoc.ValueMember = "TIPO_IDENTIFICACION";
            this.comboBoxTipoDoc.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoDoc_SelectedIndexChanged);
            // 
            // tIPOSIDENTIFICACIONBindingSource
            // 
            this.tIPOSIDENTIFICACIONBindingSource.DataMember = "TIPOS_IDENTIFICACION";
            this.tIPOSIDENTIFICACIONBindingSource.DataSource = this.gD1C2018DataSetBindingSource;
            // 
            // gD1C2018DataSetBindingSource
            // 
            this.gD1C2018DataSetBindingSource.DataSource = this.gD1C2018DataSet;
            this.gD1C2018DataSetBindingSource.Position = 0;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textoNroDoc
            // 
            this.textoNroDoc.AutoSize = true;
            this.textoNroDoc.Location = new System.Drawing.Point(228, 83);
            this.textoNroDoc.Name = "textoNroDoc";
            this.textoNroDoc.Size = new System.Drawing.Size(70, 13);
            this.textoNroDoc.TabIndex = 26;
            this.textoNroDoc.Text = "Numero Doc.";
            this.textoNroDoc.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(94, 224);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pais";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(306, 221);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxLocalidad.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Localidad";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(97, 324);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNacimiento.TabIndex = 31;
            // 
            // tIPOS_IDENTIFICACIONTableAdapter
            // 
            this.tIPOS_IDENTIFICACIONTableAdapter.ClearBeforeFill = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(282, 407);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(124, 23);
            this.buttonSalir.TabIndex = 32;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 521);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.dateTimePickerNacimiento);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoNroDoc);
            this.Controls.Add(this.comboBoxTipoDoc);
            this.Controls.Add(this.textBoxNacionalidad);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxNroDoc);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textoFechaDeNacimiento);
            this.Controls.Add(this.textoNacionalidad);
            this.Controls.Add(this.textoDireccion);
            this.Controls.Add(this.textoTelefono);
            this.Controls.Add(this.textoMail);
            this.Controls.Add(this.textoTipoDoc);
            this.Controls.Add(this.textoApellido);
            this.Controls.Add(this.textoNombre);
            this.Controls.Add(this.botonCrear);
            this.Controls.Add(this.textBoxNombre);
            this.Name = "FormCliente";
            this.Text = "Administrar clientes";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Label textoNombre;
        private System.Windows.Forms.Label textoApellido;
        private System.Windows.Forms.Label textoTipoDoc;
        private System.Windows.Forms.Label textoMail;
        private System.Windows.Forms.Label textoTelefono;
        private System.Windows.Forms.Label textoDireccion;
        private System.Windows.Forms.Label textoNacionalidad;
        private System.Windows.Forms.Label textoFechaDeNacimiento;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxNroDoc;
        private System.Windows.Forms.TextBox textBoxNacionalidad;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.ComboBox comboBoxTipoDoc;
        private System.Windows.Forms.Label textoNroDoc;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.BindingSource gD1C2018DataSetBindingSource;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource tIPOSIDENTIFICACIONBindingSource;
        private GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter tIPOS_IDENTIFICACIONTableAdapter;
        private System.Windows.Forms.Button buttonSalir;
    }
}