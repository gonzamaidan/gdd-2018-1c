namespace FrbaHotel.AbmHoteles
{
    partial class BusquedaHotel
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
            this.dataGridViewHoteles = new System.Windows.Forms.DataGridView();
            this.ID_HOTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTRELLASDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIUDADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pAISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hOTELESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.hOTELESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.HOTELESTableAdapter();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.numericEstrellas = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonNuevoHotel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstrellas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewHoteles
            // 
            this.dataGridViewHoteles.AllowUserToDeleteRows = false;
            this.dataGridViewHoteles.AutoGenerateColumns = false;
            this.dataGridViewHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HOTEL,
            this.nOMBREDataGridViewTextBoxColumn,
            this.eSTRELLASDataGridViewTextBoxColumn,
            this.cIUDADDataGridViewTextBoxColumn,
            this.pAISDataGridViewTextBoxColumn,
            this.fECHACREACIONDataGridViewTextBoxColumn});
            this.dataGridViewHoteles.DataSource = this.hOTELESBindingSource;
            this.dataGridViewHoteles.Location = new System.Drawing.Point(12, 149);
            this.dataGridViewHoteles.Name = "dataGridViewHoteles";
            this.dataGridViewHoteles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHoteles.Size = new System.Drawing.Size(765, 261);
            this.dataGridViewHoteles.TabIndex = 0;
            this.dataGridViewHoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_HOTEL
            // 
            this.ID_HOTEL.DataPropertyName = "ID_HOTEL";
            this.ID_HOTEL.HeaderText = "ID_HOTEL";
            this.ID_HOTEL.Name = "ID_HOTEL";
            this.ID_HOTEL.ReadOnly = true;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            // 
            // eSTRELLASDataGridViewTextBoxColumn
            // 
            this.eSTRELLASDataGridViewTextBoxColumn.DataPropertyName = "ESTRELLAS";
            this.eSTRELLASDataGridViewTextBoxColumn.FillWeight = 80F;
            this.eSTRELLASDataGridViewTextBoxColumn.HeaderText = "ESTRELLAS";
            this.eSTRELLASDataGridViewTextBoxColumn.Name = "eSTRELLASDataGridViewTextBoxColumn";
            this.eSTRELLASDataGridViewTextBoxColumn.Width = 80;
            // 
            // cIUDADDataGridViewTextBoxColumn
            // 
            this.cIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.HeaderText = "CIUDAD";
            this.cIUDADDataGridViewTextBoxColumn.Name = "cIUDADDataGridViewTextBoxColumn";
            // 
            // pAISDataGridViewTextBoxColumn
            // 
            this.pAISDataGridViewTextBoxColumn.DataPropertyName = "PAIS";
            this.pAISDataGridViewTextBoxColumn.HeaderText = "PAIS";
            this.pAISDataGridViewTextBoxColumn.Name = "pAISDataGridViewTextBoxColumn";
            // 
            // fECHACREACIONDataGridViewTextBoxColumn
            // 
            this.fECHACREACIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.HeaderText = "FECHA_CREACION";
            this.fECHACREACIONDataGridViewTextBoxColumn.Name = "fECHACREACIONDataGridViewTextBoxColumn";
            // 
            // hOTELESBindingSource
            // 
            this.hOTELESBindingSource.DataMember = "HOTELES";
            this.hOTELESBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOTELESTableAdapter
            // 
            this.hOTELESTableAdapter.ClearBeforeFill = true;
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(702, 41);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 1;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(702, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Dar de Baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(21, 102);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Estrellas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ciudad";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(296, 102);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pais";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(438, 102);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 10;
            // 
            // numericEstrellas
            // 
            this.numericEstrellas.Location = new System.Drawing.Point(155, 103);
            this.numericEstrellas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericEstrellas.Name = "numericEstrellas";
            this.numericEstrellas.Size = new System.Drawing.Size(106, 20);
            this.numericEstrellas.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNuevoHotel
            // 
            this.buttonNuevoHotel.Location = new System.Drawing.Point(702, 12);
            this.buttonNuevoHotel.Name = "buttonNuevoHotel";
            this.buttonNuevoHotel.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoHotel.TabIndex = 21;
            this.buttonNuevoHotel.Text = "Nuevo Hotel";
            this.buttonNuevoHotel.UseVisualStyleBackColor = true;
            this.buttonNuevoHotel.Click += new System.EventHandler(this.buttonNuevoHotel_Click);
            // 
            // BusquedaHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 463);
            this.Controls.Add(this.buttonNuevoHotel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericEstrellas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewHoteles);
            this.Name = "BusquedaHotel";
            this.Text = "BusquedaHotel";
            this.Load += new System.EventHandler(this.BusquedaHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEstrellas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewHoteles;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource hOTELESBindingSource;
        private GD1C2018DataSetTableAdapters.HOTELESTableAdapter hOTELESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDHOTELDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTRELLASDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIUDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pAISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.NumericUpDown numericEstrellas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonNuevoHotel;
    }
}