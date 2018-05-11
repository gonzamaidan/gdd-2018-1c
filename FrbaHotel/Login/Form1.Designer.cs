namespace FrbaHotel.Login
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
            this.textoIniciarSesion = new System.Windows.Forms.Label();
            this.textoUsuario = new System.Windows.Forms.Label();
            this.textoContraseña = new System.Windows.Forms.Label();
            this.textoIntentos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textoIniciarSesion
            // 
            this.textoIniciarSesion.AutoSize = true;
            this.textoIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoIniciarSesion.Location = new System.Drawing.Point(59, 19);
            this.textoIniciarSesion.Name = "textoIniciarSesion";
            this.textoIniciarSesion.Size = new System.Drawing.Size(168, 29);
            this.textoIniciarSesion.TabIndex = 0;
            this.textoIniciarSesion.Text = "Iniciar sesion";
            // 
            // textoUsuario
            // 
            this.textoUsuario.AutoSize = true;
            this.textoUsuario.Location = new System.Drawing.Point(23, 88);
            this.textoUsuario.Name = "textoUsuario";
            this.textoUsuario.Size = new System.Drawing.Size(43, 13);
            this.textoUsuario.TabIndex = 1;
            this.textoUsuario.Text = "Usuario";
            // 
            // textoContraseña
            // 
            this.textoContraseña.AutoSize = true;
            this.textoContraseña.Location = new System.Drawing.Point(23, 135);
            this.textoContraseña.Name = "textoContraseña";
            this.textoContraseña.Size = new System.Drawing.Size(61, 13);
            this.textoContraseña.TabIndex = 2;
            this.textoContraseña.Text = "Contraseña";
            // 
            // textoIntentos
            // 
            this.textoIntentos.AutoSize = true;
            this.textoIntentos.Location = new System.Drawing.Point(23, 179);
            this.textoIntentos.Name = "textoIntentos";
            this.textoIntentos.Size = new System.Drawing.Size(45, 13);
            this.textoIntentos.TabIndex = 3;
            this.textoIntentos.Text = "Intentos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 176);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 20);
            this.textBox3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textoIntentos);
            this.Controls.Add(this.textoContraseña);
            this.Controls.Add(this.textoUsuario);
            this.Controls.Add(this.textoIniciarSesion);
            this.Name = "Form1";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoIniciarSesion;
        private System.Windows.Forms.Label textoUsuario;
        private System.Windows.Forms.Label textoContraseña;
        private System.Windows.Forms.Label textoIntentos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}