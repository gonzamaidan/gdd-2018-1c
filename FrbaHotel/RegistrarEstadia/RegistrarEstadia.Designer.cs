namespace FrbaHotel.RegistrarEstadia
{
    partial class RegistrarEstadia
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
            this.textoNroReserva = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.botonConsumibles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNroReserva
            // 
            this.textoNroReserva.AutoSize = true;
            this.textoNroReserva.Location = new System.Drawing.Point(35, 65);
            this.textoNroReserva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textoNroReserva.Name = "textoNroReserva";
            this.textoNroReserva.Size = new System.Drawing.Size(88, 17);
            this.textoNroReserva.TabIndex = 1;
            this.textoNroReserva.Text = "Nro Reserva";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 65);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(339, 44);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Check In";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botonConsumibles
            // 
            this.botonConsumibles.Location = new System.Drawing.Point(339, 94);
            this.botonConsumibles.Margin = new System.Windows.Forms.Padding(4);
            this.botonConsumibles.Name = "botonConsumibles";
            this.botonConsumibles.Size = new System.Drawing.Size(165, 28);
            this.botonConsumibles.TabIndex = 6;
            this.botonConsumibles.Text = "Check Out";
            this.botonConsumibles.UseVisualStyleBackColor = true;
            this.botonConsumibles.Click += new System.EventHandler(this.botonConsumibles_Click);
            // 
            // RegistrarEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 319);
            this.Controls.Add(this.botonConsumibles);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textoNroReserva);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegistrarEstadia";
            this.Text = "Check in / Check out";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textoNroReserva;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botonConsumibles;

    }
}