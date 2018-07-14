namespace FrbaHotel.RegistrarEstadia
{
    partial class ListadoClientesEstadia
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.cODIGOCLIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_IDENTIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NACIONALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_NACIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUPLICADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.HABILITADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cLIENTESBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.cLIENTESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.CLIENTESTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumeroDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tIPOSIDENTIFICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOS_IDENTIFICACIONTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter();
            this.buttonHabilitar = new System.Windows.Forms.Button();
            this.cLIENTESBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKCLIENTESCODIG4F87BD05BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLIENTES_POR_RESERVATableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.CLIENTES_POR_RESERVATableAdapter();
            this.seleccionClienteBtn = new System.Windows.Forms.Button();
            this.selecClienteBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCLIENTESCODIG4F87BD05BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.AutoGenerateColumns = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODIGOCLIENTEDataGridViewTextBoxColumn,
            this.NOMBRE,
            this.APELLIDO,
            this.IDENTIFICACION,
            this.TIPO_IDENTIFICACION,
            this.MAIL,
            this.TELEFONO,
            this.DIRECCION,
            this.LOCALIDAD,
            this.PAIS,
            this.NACIONALIDAD,
            this.FECHA_NACIMIENTO,
            this.DUPLICADO,
            this.HABILITADO});
            this.dataGridViewClientes.DataSource = this.cLIENTESBindingSource3;
            this.dataGridViewClientes.Location = new System.Drawing.Point(20, 220);
            this.dataGridViewClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(1193, 289);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // cODIGOCLIENTEDataGridViewTextBoxColumn
            // 
            this.cODIGOCLIENTEDataGridViewTextBoxColumn.DataPropertyName = "CODIGO_CLIENTE";
            this.cODIGOCLIENTEDataGridViewTextBoxColumn.HeaderText = "CODIGO_CLIENTE";
            this.cODIGOCLIENTEDataGridViewTextBoxColumn.Name = "cODIGOCLIENTEDataGridViewTextBoxColumn";
            this.cODIGOCLIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.ReadOnly = true;
            // 
            // APELLIDO
            // 
            this.APELLIDO.DataPropertyName = "APELLIDO";
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.ReadOnly = true;
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.DataPropertyName = "IDENTIFICACION";
            this.IDENTIFICACION.HeaderText = "IDENTIFICACION";
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.ReadOnly = true;
            // 
            // TIPO_IDENTIFICACION
            // 
            this.TIPO_IDENTIFICACION.DataPropertyName = "TIPO_IDENTIFICACION";
            this.TIPO_IDENTIFICACION.HeaderText = "TIPO_IDENTIFICACION";
            this.TIPO_IDENTIFICACION.Name = "TIPO_IDENTIFICACION";
            this.TIPO_IDENTIFICACION.ReadOnly = true;
            // 
            // MAIL
            // 
            this.MAIL.DataPropertyName = "MAIL";
            this.MAIL.HeaderText = "MAIL";
            this.MAIL.Name = "MAIL";
            this.MAIL.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TELEFONO";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "DIRECCION";
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            // 
            // LOCALIDAD
            // 
            this.LOCALIDAD.DataPropertyName = "LOCALIDAD";
            this.LOCALIDAD.HeaderText = "LOCALIDAD";
            this.LOCALIDAD.Name = "LOCALIDAD";
            this.LOCALIDAD.ReadOnly = true;
            // 
            // PAIS
            // 
            this.PAIS.DataPropertyName = "PAIS";
            this.PAIS.HeaderText = "PAIS";
            this.PAIS.Name = "PAIS";
            this.PAIS.ReadOnly = true;
            // 
            // NACIONALIDAD
            // 
            this.NACIONALIDAD.DataPropertyName = "NACIONALIDAD";
            this.NACIONALIDAD.HeaderText = "NACIONALIDAD";
            this.NACIONALIDAD.Name = "NACIONALIDAD";
            this.NACIONALIDAD.ReadOnly = true;
            // 
            // FECHA_NACIMIENTO
            // 
            this.FECHA_NACIMIENTO.DataPropertyName = "FECHA_NACIMIENTO";
            this.FECHA_NACIMIENTO.HeaderText = "FECHA_NACIMIENTO";
            this.FECHA_NACIMIENTO.Name = "FECHA_NACIMIENTO";
            this.FECHA_NACIMIENTO.ReadOnly = true;
            // 
            // DUPLICADO
            // 
            this.DUPLICADO.DataPropertyName = "DUPLICADO";
            this.DUPLICADO.HeaderText = "DUPLICADO";
            this.DUPLICADO.Name = "DUPLICADO";
            this.DUPLICADO.ReadOnly = true;
            // 
            // HABILITADO
            // 
            this.HABILITADO.DataPropertyName = "HABILITADO";
            this.HABILITADO.HeaderText = "HABILITADO";
            this.HABILITADO.Name = "HABILITADO";
            this.HABILITADO.ReadOnly = true;
            // 
            // cLIENTESBindingSource3
            // 
            this.cLIENTESBindingSource3.DataMember = "CLIENTES";
            this.cLIENTESBindingSource3.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESBindingSource1
            // 
            this.cLIENTESBindingSource1.DataMember = "CLIENTES";
            this.cLIENTESBindingSource1.DataSource = this.gD1C2018DataSet;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(27, 107);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(132, 22);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(215, 107);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(132, 22);
            this.textBoxApellido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellido";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(743, 107);
            this.textBoxMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(132, 22);
            this.textBoxMail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(743, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mail";
            // 
            // textBoxNumeroDoc
            // 
            this.textBoxNumeroDoc.Location = new System.Drawing.Point(556, 107);
            this.textBoxNumeroDoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNumeroDoc.Name = "textBoxNumeroDoc";
            this.textBoxNumeroDoc.Size = new System.Drawing.Size(132, 22);
            this.textBoxNumeroDoc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(556, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nro Documento";
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(124, 517);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(100, 28);
            this.buttonEditar.TabIndex = 9;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(1109, 105);
            this.buttonBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBorrar.Size = new System.Drawing.Size(100, 28);
            this.buttonBorrar.TabIndex = 10;
            this.buttonBorrar.Text = "Deshabilitar";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(952, 105);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(100, 28);
            this.buttonBuscar.TabIndex = 11;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(1109, 517);
            this.buttonSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(100, 28);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(1109, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonNuevoHotel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tipo Doc";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tIPOSIDENTIFICACIONBindingSource;
            this.comboBox1.DisplayMember = "DESCRIPCION";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(384, 107);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(137, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "TIPO_IDENTIFICACION";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tIPOSIDENTIFICACIONBindingSource
            // 
            this.tIPOSIDENTIFICACIONBindingSource.DataMember = "TIPOS_IDENTIFICACION";
            this.tIPOSIDENTIFICACIONBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // tIPOS_IDENTIFICACIONTableAdapter
            // 
            this.tIPOS_IDENTIFICACIONTableAdapter.ClearBeforeFill = true;
            // 
            // buttonHabilitar
            // 
            this.buttonHabilitar.Location = new System.Drawing.Point(1109, 155);
            this.buttonHabilitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonHabilitar.Name = "buttonHabilitar";
            this.buttonHabilitar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHabilitar.Size = new System.Drawing.Size(100, 28);
            this.buttonHabilitar.TabIndex = 16;
            this.buttonHabilitar.Text = "Habilitar";
            this.buttonHabilitar.UseVisualStyleBackColor = true;
            this.buttonHabilitar.Click += new System.EventHandler(this.buttonHabilitar_Click);
            // 
            // cLIENTESBindingSource2
            // 
            this.cLIENTESBindingSource2.DataMember = "CLIENTES";
            this.cLIENTESBindingSource2.DataSource = this.gD1C2018DataSet;
            // 
            // fKCLIENTESCODIG4F87BD05BindingSource
            // 
            this.fKCLIENTESCODIG4F87BD05BindingSource.DataMember = "FK__CLIENTES___CODIG__4F87BD05";
            this.fKCLIENTESCODIG4F87BD05BindingSource.DataSource = this.cLIENTESBindingSource2;
            // 
            // cLIENTES_POR_RESERVATableAdapter
            // 
            this.cLIENTES_POR_RESERVATableAdapter.ClearBeforeFill = true;
            // 
            // seleccionClienteBtn
            // 
            this.seleccionClienteBtn.Location = new System.Drawing.Point(12, 380);
            this.seleccionClienteBtn.Name = "seleccionClienteBtn";
            this.seleccionClienteBtn.Size = new System.Drawing.Size(75, 23);
            this.seleccionClienteBtn.TabIndex = 16;
            this.seleccionClienteBtn.Text = "Seleccionar";
            this.seleccionClienteBtn.UseVisualStyleBackColor = true;
            this.seleccionClienteBtn.Click += new System.EventHandler(this.seleccionClienteBtn_Click);
            // 
            // selecClienteBTN
            // 
            this.selecClienteBTN.Location = new System.Drawing.Point(16, 517);
            this.selecClienteBTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selecClienteBTN.Name = "selecClienteBTN";
            this.selecClienteBTN.Size = new System.Drawing.Size(100, 28);
            this.selecClienteBTN.TabIndex = 17;
            this.selecClienteBTN.Text = "Seleccionar";
            this.selecClienteBTN.UseVisualStyleBackColor = true;
            this.selecClienteBTN.Click += new System.EventHandler(this.selecClienteBTN_Click);
            // 
            // ListadoClientesEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 560);
            this.Controls.Add(this.selecClienteBTN);
            this.Controls.Add(this.buttonHabilitar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNumeroDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ListadoClientesEstadia";
            this.Text = "ListadoClientes";
            this.Load += new System.EventHandler(this.ListadoClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKCLIENTESCODIG4F87BD05BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private GD1C2018DataSetTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumeroDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tIPOSIDENTIFICACIONBindingSource;
        private GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter tIPOS_IDENTIFICACIONTableAdapter;
        private System.Windows.Forms.Button buttonHabilitar;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource1;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource2;
        private System.Windows.Forms.BindingSource fKCLIENTESCODIG4F87BD05BindingSource;
        private GD1C2018DataSetTableAdapters.CLIENTES_POR_RESERVATableAdapter cLIENTES_POR_RESERVATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGOCLIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_IDENTIFICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NACIONALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_NACIMIENTO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DUPLICADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HABILITADO;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource3;
        private System.Windows.Forms.Button seleccionClienteBtn;
        private System.Windows.Forms.Button selecClienteBTN;
    }
}
