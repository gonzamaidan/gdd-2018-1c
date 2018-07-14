namespace FrbaHotel.Login
{
    partial class ventanaPrincipal
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
            this.btnGenerarReserva = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cancelarReserva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarReserva
            // 
            this.btnGenerarReserva.Location = new System.Drawing.Point(53, 22);
            this.btnGenerarReserva.Name = "btnGenerarReserva";
            this.btnGenerarReserva.Size = new System.Drawing.Size(183, 41);
            this.btnGenerarReserva.TabIndex = 0;
            this.btnGenerarReserva.Text = "Generar Reserva";
            this.btnGenerarReserva.UseVisualStyleBackColor = true;
            this.btnGenerarReserva.Click += new System.EventHandler(this.btnGenerarReserva_Click);
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Location = new System.Drawing.Point(53, 69);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(183, 41);
            this.btnModificarReserva.TabIndex = 1;
            this.btnModificarReserva.Text = "Modificar Reserva";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            this.btnModificarReserva.Click += new System.EventHandler(this.btnModificarReserva_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(53, 163);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(87, 210);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 25);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // cancelarReserva
            // 
            this.cancelarReserva.Location = new System.Drawing.Point(53, 116);
            this.cancelarReserva.Name = "cancelarReserva";
            this.cancelarReserva.Size = new System.Drawing.Size(183, 41);
            this.cancelarReserva.TabIndex = 4;
            this.cancelarReserva.Text = "Cancelar Reserva";
            this.cancelarReserva.UseVisualStyleBackColor = true;
            this.cancelarReserva.Click += new System.EventHandler(this.cancelarReserva_Click);
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cancelarReserva);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnModificarReserva);
            this.Controls.Add(this.btnGenerarReserva);
            this.Name = "ventanaPrincipal";
            this.Text = "ventanaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarReserva;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button cancelarReserva;
    }
}