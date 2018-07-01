namespace FrbaHotel.AbmHabitacion
{
    partial class ListadoHabitaciones
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
            this.buttonNuevoHotel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridViewHabitaciones = new System.Windows.Forms.DataGridView();
            this.ID_HOTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hABITACIONESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.hABITACIONESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.HABITACIONESTableAdapter();
            this.fKHABITACIONESPOR3E52440BBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hABITACIONES_POR_RESERVATableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.HABITACIONES_POR_RESERVATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hABITACIONESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKHABITACIONESPOR3E52440BBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNuevoHotel
            // 
            this.buttonNuevoHotel.Location = new System.Drawing.Point(702, 19);
            this.buttonNuevoHotel.Name = "buttonNuevoHotel";
            this.buttonNuevoHotel.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevoHotel.TabIndex = 35;
            this.buttonNuevoHotel.Text = "Nuevo Habtacion";
            this.buttonNuevoHotel.UseVisualStyleBackColor = true;
            this.buttonNuevoHotel.Click += new System.EventHandler(this.buttonNuevoHotel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(702, 435);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Dar de Baja Hotel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(702, 48);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 23;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridViewHabitaciones
            // 
            this.dataGridViewHabitaciones.AllowUserToAddRows = false;
            this.dataGridViewHabitaciones.AllowUserToDeleteRows = false;
            this.dataGridViewHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_HOTEL});
            this.dataGridViewHabitaciones.Location = new System.Drawing.Point(12, 156);
            this.dataGridViewHabitaciones.Name = "dataGridViewHabitaciones";
            this.dataGridViewHabitaciones.ReadOnly = true;
            this.dataGridViewHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHabitaciones.Size = new System.Drawing.Size(765, 261);
            this.dataGridViewHabitaciones.TabIndex = 22;
            // 
            // ID_HOTEL
            // 
            this.ID_HOTEL.DataPropertyName = "ID_HOTEL";
            this.ID_HOTEL.HeaderText = "ID_HOTEL";
            this.ID_HOTEL.Name = "ID_HOTEL";
            this.ID_HOTEL.ReadOnly = true;
            // 
            // hABITACIONESBindingSource
            // 
            this.hABITACIONESBindingSource.DataMember = "HABITACIONES";
            this.hABITACIONESBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hABITACIONESTableAdapter
            // 
            this.hABITACIONESTableAdapter.ClearBeforeFill = true;
            // 
            // fKHABITACIONESPOR3E52440BBindingSource
            // 
            this.fKHABITACIONESPOR3E52440BBindingSource.DataMember = "FK__HABITACIONES_POR__3E52440B";
            this.fKHABITACIONESPOR3E52440BBindingSource.DataSource = this.hABITACIONESBindingSource;
            // 
            // hABITACIONES_POR_RESERVATableAdapter
            // 
            this.hABITACIONES_POR_RESERVATableAdapter.ClearBeforeFill = true;
            // 
            // ListadoHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 477);
            this.Controls.Add(this.buttonNuevoHotel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.dataGridViewHabitaciones);
            this.Name = "ListadoHabitaciones";
            this.Text = "ListadoHabitaciones";
            this.Load += new System.EventHandler(this.ListadoHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hABITACIONESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNuevoHotel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridViewHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_HOTEL;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource hABITACIONESBindingSource;
        private GD1C2018DataSetTableAdapters.HABITACIONESTableAdapter hABITACIONESTableAdapter;
        private System.Windows.Forms.BindingSource fKHABITACIONESPOR3E52440BBindingSource;
        private GD1C2018DataSetTableAdapters.HABITACIONES_POR_RESERVATableAdapter hABITACIONES_POR_RESERVATableAdapter;

    }
}