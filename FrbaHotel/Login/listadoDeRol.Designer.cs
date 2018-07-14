namespace FrbaHotel.Login
{
    partial class listadoDeRol
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.dgvRolesDeUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesDeUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegi un rol";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(178, 323);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(156, 32);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvRolesDeUsuario
            // 
            this.dgvRolesDeUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRolesDeUsuario.Location = new System.Drawing.Point(15, 38);
            this.dgvRolesDeUsuario.Name = "dgvRolesDeUsuario";
            this.dgvRolesDeUsuario.Size = new System.Drawing.Size(499, 263);
            this.dgvRolesDeUsuario.TabIndex = 3;
            this.dgvRolesDeUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRolesDeUsuario_CellContentClick);
            // 
            // listadoDeRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 378);
            this.Controls.Add(this.dgvRolesDeUsuario);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Name = "listadoDeRol";
            this.Text = "listadoDeRol";
            this.Load += new System.EventHandler(this.listadoDeRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRolesDeUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvRolesDeUsuario;
    }
}