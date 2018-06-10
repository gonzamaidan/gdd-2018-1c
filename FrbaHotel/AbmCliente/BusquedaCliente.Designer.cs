namespace FrbaHotel.AbmCliente
{
    partial class BusquedaCliente
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
            this.tipoIdentificacionComboBox = new System.Windows.Forms.ComboBox();
            this.tIPOSIDENTIFICACIONBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.tIPOSIDENTIFICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOS_IDENTIFICACIONTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.identificacionTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.buscarClienteBtn = new System.Windows.Forms.Button();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.modificarClienteBtn = new System.Windows.Forms.Button();
            this.tipoIdentificacionCheckBox = new System.Windows.Forms.CheckBox();
            this.seleccionarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tipoIdentificacionComboBox
            // 
            this.tipoIdentificacionComboBox.CausesValidation = false;
            this.tipoIdentificacionComboBox.DataSource = this.tIPOSIDENTIFICACIONBindingSource1;
            this.tipoIdentificacionComboBox.DisplayMember = "DESCRIPCION";
            this.tipoIdentificacionComboBox.FormattingEnabled = true;
            this.tipoIdentificacionComboBox.Location = new System.Drawing.Point(194, 32);
            this.tipoIdentificacionComboBox.Name = "tipoIdentificacionComboBox";
            this.tipoIdentificacionComboBox.Size = new System.Drawing.Size(121, 21);
            this.tipoIdentificacionComboBox.TabIndex = 0;
            this.tipoIdentificacionComboBox.ValueMember = "TIPO_IDENTIFICACION";
            this.tipoIdentificacionComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoIdentificacionComboBox_SelectedIndexChanged);
            // 
            // tIPOSIDENTIFICACIONBindingSource1
            // 
            this.tIPOSIDENTIFICACIONBindingSource1.DataMember = "TIPOS_IDENTIFICACION";
            this.tIPOSIDENTIFICACIONBindingSource1.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero de identificacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // identificacionTextBox
            // 
            this.identificacionTextBox.Location = new System.Drawing.Point(194, 77);
            this.identificacionTextBox.Name = "identificacionTextBox";
            this.identificacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.identificacionTextBox.TabIndex = 4;
            this.identificacionTextBox.TextChanged += new System.EventHandler(this.identificacionTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(194, 110);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // buscarClienteBtn
            // 
            this.buscarClienteBtn.Location = new System.Drawing.Point(411, 32);
            this.buscarClienteBtn.Name = "buscarClienteBtn";
            this.buscarClienteBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarClienteBtn.TabIndex = 6;
            this.buscarClienteBtn.Text = "Buscar";
            this.buscarClienteBtn.UseVisualStyleBackColor = true;
            this.buscarClienteBtn.Click += new System.EventHandler(this.buscarClienteBtn_Click);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AllowUserToAddRows = false;
            this.clientesDataGridView.AllowUserToDeleteRows = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Location = new System.Drawing.Point(48, 153);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(438, 150);
            this.clientesDataGridView.TabIndex = 7;
            this.clientesDataGridView.DoubleClick += new System.EventHandler(this.clientesDataGridView_DoubleClick);
            // 
            // modificarClienteBtn
            // 
            this.modificarClienteBtn.Location = new System.Drawing.Point(411, 74);
            this.modificarClienteBtn.Name = "modificarClienteBtn";
            this.modificarClienteBtn.Size = new System.Drawing.Size(75, 23);
            this.modificarClienteBtn.TabIndex = 8;
            this.modificarClienteBtn.Text = "Modificar";
            this.modificarClienteBtn.UseVisualStyleBackColor = true;
            // 
            // tipoIdentificacionCheckBox
            // 
            this.tipoIdentificacionCheckBox.AutoSize = true;
            this.tipoIdentificacionCheckBox.Location = new System.Drawing.Point(48, 32);
            this.tipoIdentificacionCheckBox.Name = "tipoIdentificacionCheckBox";
            this.tipoIdentificacionCheckBox.Size = new System.Drawing.Size(127, 17);
            this.tipoIdentificacionCheckBox.TabIndex = 9;
            this.tipoIdentificacionCheckBox.Text = "Tipo de identificacion";
            this.tipoIdentificacionCheckBox.UseVisualStyleBackColor = true;
            this.tipoIdentificacionCheckBox.CheckedChanged += new System.EventHandler(this.tipoIdentificacionCheckBox_CheckedChanged);
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.Location = new System.Drawing.Point(411, 107);
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.Size = new System.Drawing.Size(75, 23);
            this.seleccionarButton.TabIndex = 10;
            this.seleccionarButton.Text = "Seleccionar";
            this.seleccionarButton.UseVisualStyleBackColor = true;
            this.seleccionarButton.Click += new System.EventHandler(this.seleccionarButton_Click);
            // 
            // BusquedaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 315);
            this.Controls.Add(this.seleccionarButton);
            this.Controls.Add(this.tipoIdentificacionCheckBox);
            this.Controls.Add(this.modificarClienteBtn);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.buscarClienteBtn);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.identificacionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoIdentificacionComboBox);
            this.Name = "BusquedaCliente";
            this.Text = "Busqueda cliente";
            this.Load += new System.EventHandler(this.BusquedaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource tIPOSIDENTIFICACIONBindingSource;
        private GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter tIPOS_IDENTIFICACIONTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox identificacionTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button buscarClienteBtn;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.Button modificarClienteBtn;
        private System.Windows.Forms.BindingSource tIPOSIDENTIFICACIONBindingSource1;
        private System.Windows.Forms.ComboBox tipoIdentificacionComboBox;
        private System.Windows.Forms.CheckBox tipoIdentificacionCheckBox;
        private System.Windows.Forms.Button seleccionarButton;
    }
}