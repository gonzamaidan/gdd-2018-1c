namespace FrbaHotel.AbmRegimen
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
            this.botonCrear = new System.Windows.Forms.Button();
            this.textoCodigo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textoDescripcion = new System.Windows.Forms.Label();
            this.textoPrecioEnDolar = new System.Windows.Forms.Label();
            this.textoEstado = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonDarDeBaja = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radioBotonActivo = new System.Windows.Forms.RadioButton();
            this.radioBotonNoActivo = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(25, 276);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(75, 23);
            this.botonCrear.TabIndex = 0;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            // 
            // textoCodigo
            // 
            this.textoCodigo.AutoSize = true;
            this.textoCodigo.Location = new System.Drawing.Point(34, 34);
            this.textoCodigo.Name = "textoCodigo";
            this.textoCodigo.Size = new System.Drawing.Size(40, 13);
            this.textoCodigo.TabIndex = 1;
            this.textoCodigo.Text = "Codigo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 123);
            this.textBox1.TabIndex = 2;
            // 
            // textoDescripcion
            // 
            this.textoDescripcion.AutoSize = true;
            this.textoDescripcion.Location = new System.Drawing.Point(34, 75);
            this.textoDescripcion.Name = "textoDescripcion";
            this.textoDescripcion.Size = new System.Drawing.Size(46, 13);
            this.textoDescripcion.TabIndex = 4;
            this.textoDescripcion.Text = "Descrip.";
            // 
            // textoPrecioEnDolar
            // 
            this.textoPrecioEnDolar.AutoSize = true;
            this.textoPrecioEnDolar.Location = new System.Drawing.Point(34, 207);
            this.textoPrecioEnDolar.Name = "textoPrecioEnDolar";
            this.textoPrecioEnDolar.Size = new System.Drawing.Size(64, 13);
            this.textoPrecioEnDolar.TabIndex = 5;
            this.textoPrecioEnDolar.Text = "Precio(US$)";
            // 
            // textoEstado
            // 
            this.textoEstado.AutoSize = true;
            this.textoEstado.Location = new System.Drawing.Point(34, 237);
            this.textoEstado.Name = "textoEstado";
            this.textoEstado.Size = new System.Drawing.Size(40, 13);
            this.textoEstado.TabIndex = 6;
            this.textoEstado.Text = "Estado";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(140, 276);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(75, 23);
            this.botonModificar.TabIndex = 8;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonDarDeBaja
            // 
            this.botonDarDeBaja.Location = new System.Drawing.Point(251, 276);
            this.botonDarDeBaja.Name = "botonDarDeBaja";
            this.botonDarDeBaja.Size = new System.Drawing.Size(75, 23);
            this.botonDarDeBaja.TabIndex = 9;
            this.botonDarDeBaja.Text = "Dar de baja";
            this.botonDarDeBaja.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // radioBotonActivo
            // 
            this.radioBotonActivo.AutoSize = true;
            this.radioBotonActivo.Location = new System.Drawing.Point(95, 235);
            this.radioBotonActivo.Name = "radioBotonActivo";
            this.radioBotonActivo.Size = new System.Drawing.Size(55, 17);
            this.radioBotonActivo.TabIndex = 12;
            this.radioBotonActivo.TabStop = true;
            this.radioBotonActivo.Text = "Activo";
            this.radioBotonActivo.UseVisualStyleBackColor = true;
            // 
            // radioBotonNoActivo
            // 
            this.radioBotonNoActivo.AutoSize = true;
            this.radioBotonNoActivo.Location = new System.Drawing.Point(254, 235);
            this.radioBotonNoActivo.Name = "radioBotonNoActivo";
            this.radioBotonNoActivo.Size = new System.Drawing.Size(72, 17);
            this.radioBotonNoActivo.TabIndex = 13;
            this.radioBotonNoActivo.TabStop = true;
            this.radioBotonNoActivo.Text = "No Activo";
            this.radioBotonNoActivo.UseVisualStyleBackColor = true;
            this.radioBotonNoActivo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 327);
            this.Controls.Add(this.radioBotonNoActivo);
            this.Controls.Add(this.radioBotonActivo);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.botonDarDeBaja);
            this.Controls.Add(this.botonModificar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textoEstado);
            this.Controls.Add(this.textoPrecioEnDolar);
            this.Controls.Add(this.textoDescripcion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textoCodigo);
            this.Controls.Add(this.botonCrear);
            this.Name = "Form1";
            this.Text = "Regimen de estadia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Label textoCodigo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label textoDescripcion;
        private System.Windows.Forms.Label textoPrecioEnDolar;
        private System.Windows.Forms.Label textoEstado;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button botonModificar;
        private System.Windows.Forms.Button botonDarDeBaja;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radioBotonActivo;
        private System.Windows.Forms.RadioButton radioBotonNoActivo;
    }
}