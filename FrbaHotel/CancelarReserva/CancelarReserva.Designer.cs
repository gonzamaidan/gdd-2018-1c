namespace FrbaHotel.CancelarReserva
{
    partial class CancelarReserva
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
            this.codigoReservaTB = new System.Windows.Forms.TextBox();
            this.textoNumeroReserva = new System.Windows.Forms.Label();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.textoMotivo = new System.Windows.Forms.Label();
            this.fechaCancelacion = new System.Windows.Forms.Label();
            this.textoUsuarioQueCancelo = new System.Windows.Forms.Label();
            this.motivoReservaTB = new System.Windows.Forms.TextBox();
            this.usuarioCanceladorTB = new System.Windows.Forms.TextBox();
            this.botonSalir = new System.Windows.Forms.Button();
            this.fechaCancelacionPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // codigoReservaTB
            // 
            this.codigoReservaTB.Location = new System.Drawing.Point(183, 29);
            this.codigoReservaTB.Name = "codigoReservaTB";
            this.codigoReservaTB.Size = new System.Drawing.Size(100, 20);
            this.codigoReservaTB.TabIndex = 0;
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
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
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
            // motivoReservaTB
            // 
            this.motivoReservaTB.Location = new System.Drawing.Point(183, 61);
            this.motivoReservaTB.Multiline = true;
            this.motivoReservaTB.Name = "motivoReservaTB";
            this.motivoReservaTB.Size = new System.Drawing.Size(305, 86);
            this.motivoReservaTB.TabIndex = 6;
            // 
            // usuarioCanceladorTB
            // 
            this.usuarioCanceladorTB.Location = new System.Drawing.Point(183, 188);
            this.usuarioCanceladorTB.Name = "usuarioCanceladorTB";
            this.usuarioCanceladorTB.Size = new System.Drawing.Size(227, 20);
            this.usuarioCanceladorTB.TabIndex = 8;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(335, 224);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 21);
            this.botonSalir.TabIndex = 9;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // fechaCancelacionPicker
            // 
            this.fechaCancelacionPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaCancelacionPicker.Location = new System.Drawing.Point(183, 156);
            this.fechaCancelacionPicker.Name = "fechaCancelacionPicker";
            this.fechaCancelacionPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaCancelacionPicker.TabIndex = 10;
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 275);
            this.Controls.Add(this.fechaCancelacionPicker);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.usuarioCanceladorTB);
            this.Controls.Add(this.motivoReservaTB);
            this.Controls.Add(this.textoUsuarioQueCancelo);
            this.Controls.Add(this.fechaCancelacion);
            this.Controls.Add(this.textoMotivo);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.textoNumeroReserva);
            this.Controls.Add(this.codigoReservaTB);
            this.Name = "CancelarReserva";
            this.Text = "Cancelar reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codigoReservaTB;
        private System.Windows.Forms.Label textoNumeroReserva;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.Label textoMotivo;
        private System.Windows.Forms.Label fechaCancelacion;
        private System.Windows.Forms.Label textoUsuarioQueCancelo;
        private System.Windows.Forms.TextBox motivoReservaTB;
        private System.Windows.Forms.TextBox usuarioCanceladorTB;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.DateTimePicker fechaCancelacionPicker;
    }
}