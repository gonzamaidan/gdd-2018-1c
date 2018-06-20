namespace FrbaHotel.ListadoEstadistico
{
    partial class listadoEstadistico
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
            this.textoAño = new System.Windows.Forms.Label();
            this.textoTrimestre = new System.Windows.Forms.Label();
            this.botonTipoListado = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.cmbTrimestre = new System.Windows.Forms.ComboBox();
            this.cmbListado = new System.Windows.Forms.ComboBox();
            this.dgvListas = new System.Windows.Forms.DataGridView();
            this.btnGenerar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).BeginInit();
            this.SuspendLayout();
            // 
            // textoAño
            // 
            this.textoAño.AutoSize = true;
            this.textoAño.Location = new System.Drawing.Point(27, 28);
            this.textoAño.Name = "textoAño";
            this.textoAño.Size = new System.Drawing.Size(26, 13);
            this.textoAño.TabIndex = 0;
            this.textoAño.Text = "Año";
            // 
            // textoTrimestre
            // 
            this.textoTrimestre.AutoSize = true;
            this.textoTrimestre.Location = new System.Drawing.Point(27, 73);
            this.textoTrimestre.Name = "textoTrimestre";
            this.textoTrimestre.Size = new System.Drawing.Size(50, 13);
            this.textoTrimestre.TabIndex = 1;
            this.textoTrimestre.Text = "Trimestre";
            // 
            // botonTipoListado
            // 
            this.botonTipoListado.AutoSize = true;
            this.botonTipoListado.Location = new System.Drawing.Point(27, 114);
            this.botonTipoListado.Name = "botonTipoListado";
            this.botonTipoListado.Size = new System.Drawing.Size(76, 13);
            this.botonTipoListado.TabIndex = 2;
            this.botonTipoListado.Text = "Tipo de listado";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(103, 25);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(370, 20);
            this.txtAnio.TabIndex = 3;
            // 
            // cmbTrimestre
            // 
            this.cmbTrimestre.FormattingEnabled = true;
            this.cmbTrimestre.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbTrimestre.Location = new System.Drawing.Point(103, 70);
            this.cmbTrimestre.Name = "cmbTrimestre";
            this.cmbTrimestre.Size = new System.Drawing.Size(370, 21);
            this.cmbTrimestre.TabIndex = 4;
            // 
            // cmbListado
            // 
            this.cmbListado.FormattingEnabled = true;
            this.cmbListado.Items.AddRange(new object[] {
            "Hoteles con mayor cantidad de reservas canceladas",
            "Hoteles con mayor cantidad de consumibles facturados",
            "Hoteles con mayor cantidad de días fuera de servicio",
            "Habitaciones con mayor cantidad de días y veces que fueron ocupadas",
            "Cliente con mayor cantidad de punto"});
            this.cmbListado.Location = new System.Drawing.Point(103, 111);
            this.cmbListado.Name = "cmbListado";
            this.cmbListado.Size = new System.Drawing.Size(370, 21);
            this.cmbListado.TabIndex = 5;
            this.cmbListado.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dgvListas
            // 
            this.dgvListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListas.Location = new System.Drawing.Point(30, 197);
            this.dgvListas.Name = "dgvListas";
            this.dgvListas.Size = new System.Drawing.Size(443, 150);
            this.dgvListas.TabIndex = 6;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(160, 158);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(189, 23);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // listadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 368);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.dgvListas);
            this.Controls.Add(this.cmbListado);
            this.Controls.Add(this.cmbTrimestre);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.botonTipoListado);
            this.Controls.Add(this.textoTrimestre);
            this.Controls.Add(this.textoAño);
            this.Name = "listadoEstadistico";
            this.Text = "Listado estadistico";
            this.Load += new System.EventHandler(this.listadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoAño;
        private System.Windows.Forms.Label textoTrimestre;
        private System.Windows.Forms.Label botonTipoListado;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.ComboBox cmbTrimestre;
        private System.Windows.Forms.ComboBox cmbListado;
        private System.Windows.Forms.DataGridView dgvListas;
        private System.Windows.Forms.Button btnGenerar;
    }
}