namespace FrbaHotel.CancelarReserva
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textoNumeroReserva = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.textoMotivo = new System.Windows.Forms.Label();
            this.fechaCancelacion = new System.Windows.Forms.Label();
            this.textoUsuarioQueCancelo = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textoNumeroReserva
            // 
            this.textoNumeroReserva.AutoSize = true;
            this.textoNumeroReserva.Location = new System.Drawing.Point(55, 29);
            this.textoNumeroReserva.Name = "textoNumeroReserva";
            this.textoNumeroReserva.Size = new System.Drawing.Size(67, 13);
            this.textoNumeroReserva.TabIndex = 1;
            this.textoNumeroReserva.Text = "Nro Reserva";
            this.textoNumeroReserva.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(238, 224);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 2;
            this.botonAceptar.Text = "Aceptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            // 
            // textoMotivo
            // 
            this.textoMotivo.AutoSize = true;
            this.textoMotivo.Location = new System.Drawing.Point(55, 64);
            this.textoMotivo.Name = "textoMotivo";
            this.textoMotivo.Size = new System.Drawing.Size(39, 13);
            this.textoMotivo.TabIndex = 3;
            this.textoMotivo.Text = "Motivo";
            // 
            // fechaCancelacion
            // 
            this.fechaCancelacion.AutoSize = true;
            this.fechaCancelacion.Location = new System.Drawing.Point(55, 156);
            this.fechaCancelacion.Name = "fechaCancelacion";
            this.fechaCancelacion.Size = new System.Drawing.Size(98, 13);
            this.fechaCancelacion.TabIndex = 4;
            this.fechaCancelacion.Text = "Fecha cancelacion";
            this.fechaCancelacion.Click += new System.EventHandler(this.fechaCancelacion_Click);
            // 
            // textoUsuarioQueCancelo
            // 
            this.textoUsuarioQueCancelo.AutoSize = true;
            this.textoUsuarioQueCancelo.Location = new System.Drawing.Point(55, 191);
            this.textoUsuarioQueCancelo.Name = "textoUsuarioQueCancelo";
            this.textoUsuarioQueCancelo.Size = new System.Drawing.Size(108, 13);
            this.textoUsuarioQueCancelo.TabIndex = 5;
            this.textoUsuarioQueCancelo.Text = "Usuario que cancelo:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(183, 61);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 86);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(183, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 188);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 20);
            this.textBox4.TabIndex = 8;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(335, 224);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 21);
            this.botonSalir.TabIndex = 9;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 275);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textoUsuarioQueCancelo);
            this.Controls.Add(this.fechaCancelacion);
            this.Controls.Add(this.textoMotivo);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.textoNumeroReserva);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Cancelar reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textoNumeroReserva;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label textoMotivo;
        private System.Windows.Forms.Label fechaCancelacion;
        private System.Windows.Forms.Label textoUsuarioQueCancelo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button botonSalir;
    }
}