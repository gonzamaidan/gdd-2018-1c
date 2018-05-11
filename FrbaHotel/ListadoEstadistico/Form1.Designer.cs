namespace FrbaHotel.ListadoEstadistico
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
            this.textoAño = new System.Windows.Forms.Label();
            this.textoTrimestre = new System.Windows.Forms.Label();
            this.botonTipoListado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textoAño
            // 
            this.textoAño.AutoSize = true;
            this.textoAño.Location = new System.Drawing.Point(51, 55);
            this.textoAño.Name = "textoAño";
            this.textoAño.Size = new System.Drawing.Size(26, 13);
            this.textoAño.TabIndex = 0;
            this.textoAño.Text = "Año";
            // 
            // textoTrimestre
            // 
            this.textoTrimestre.AutoSize = true;
            this.textoTrimestre.Location = new System.Drawing.Point(51, 100);
            this.textoTrimestre.Name = "textoTrimestre";
            this.textoTrimestre.Size = new System.Drawing.Size(50, 13);
            this.textoTrimestre.TabIndex = 1;
            this.textoTrimestre.Text = "Trimestre";
            // 
            // botonTipoListado
            // 
            this.botonTipoListado.AutoSize = true;
            this.botonTipoListado.Location = new System.Drawing.Point(51, 146);
            this.botonTipoListado.Name = "botonTipoListado";
            this.botonTipoListado.Size = new System.Drawing.Size(76, 13);
            this.botonTipoListado.TabIndex = 2;
            this.botonTipoListado.Text = "Tipo de listado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(160, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(160, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(189, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(361, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 368);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonTipoListado);
            this.Controls.Add(this.textoTrimestre);
            this.Controls.Add(this.textoAño);
            this.Name = "Form1";
            this.Text = "Listado estadistico";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoAño;
        private System.Windows.Forms.Label textoTrimestre;
        private System.Windows.Forms.Label botonTipoListado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}