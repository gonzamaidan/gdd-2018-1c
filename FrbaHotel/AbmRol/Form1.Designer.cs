namespace FrbaHotel.AbmRol
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
            this.textoID = new System.Windows.Forms.Label();
            this.textoNombreApellido = new System.Windows.Forms.Label();
            this.textoRol = new System.Windows.Forms.Label();
            this.botonCrearUsuario = new System.Windows.Forms.Button();
            this.botonModificarUsuario = new System.Windows.Forms.Button();
            this.botonEliminarUsuario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textoID
            // 
            this.textoID.AutoSize = true;
            this.textoID.Location = new System.Drawing.Point(22, 39);
            this.textoID.Name = "textoID";
            this.textoID.Size = new System.Drawing.Size(18, 13);
            this.textoID.TabIndex = 0;
            this.textoID.Text = "ID";
            this.textoID.Click += new System.EventHandler(this.label1_Click);
            // 
            // textoNombreApellido
            // 
            this.textoNombreApellido.AutoSize = true;
            this.textoNombreApellido.Location = new System.Drawing.Point(22, 80);
            this.textoNombreApellido.Name = "textoNombreApellido";
            this.textoNombreApellido.Size = new System.Drawing.Size(92, 13);
            this.textoNombreApellido.TabIndex = 1;
            this.textoNombreApellido.Text = "Nombre y Apellido";
            // 
            // textoRol
            // 
            this.textoRol.AutoSize = true;
            this.textoRol.Location = new System.Drawing.Point(22, 118);
            this.textoRol.Name = "textoRol";
            this.textoRol.Size = new System.Drawing.Size(23, 13);
            this.textoRol.TabIndex = 2;
            this.textoRol.Text = "Rol";
            // 
            // botonCrearUsuario
            // 
            this.botonCrearUsuario.Location = new System.Drawing.Point(363, 37);
            this.botonCrearUsuario.Name = "botonCrearUsuario";
            this.botonCrearUsuario.Size = new System.Drawing.Size(107, 23);
            this.botonCrearUsuario.TabIndex = 3;
            this.botonCrearUsuario.Text = "Crear Usuario";
            this.botonCrearUsuario.UseVisualStyleBackColor = true;
            this.botonCrearUsuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // botonModificarUsuario
            // 
            this.botonModificarUsuario.Location = new System.Drawing.Point(363, 77);
            this.botonModificarUsuario.Name = "botonModificarUsuario";
            this.botonModificarUsuario.Size = new System.Drawing.Size(107, 23);
            this.botonModificarUsuario.TabIndex = 4;
            this.botonModificarUsuario.Text = "Modificar Usuario";
            this.botonModificarUsuario.UseVisualStyleBackColor = true;
            // 
            // botonEliminarUsuario
            // 
            this.botonEliminarUsuario.Location = new System.Drawing.Point(363, 115);
            this.botonEliminarUsuario.Name = "botonEliminarUsuario";
            this.botonEliminarUsuario.Size = new System.Drawing.Size(107, 23);
            this.botonEliminarUsuario.TabIndex = 5;
            this.botonEliminarUsuario.Text = "Eliminar Usuario";
            this.botonEliminarUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 115);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(220, 20);
            this.textBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 196);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.botonEliminarUsuario);
            this.Controls.Add(this.botonModificarUsuario);
            this.Controls.Add(this.botonCrearUsuario);
            this.Controls.Add(this.textoRol);
            this.Controls.Add(this.textoNombreApellido);
            this.Controls.Add(this.textoID);
            this.Name = "Form1";
            this.Text = "Menu ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoID;
        private System.Windows.Forms.Label textoNombreApellido;
        private System.Windows.Forms.Label textoRol;
        private System.Windows.Forms.Button botonCrearUsuario;
        private System.Windows.Forms.Button botonModificarUsuario;
        private System.Windows.Forms.Button botonEliminarUsuario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}