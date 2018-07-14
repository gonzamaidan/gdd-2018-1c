namespace FrbaHotel.AbmHoteles
{
    partial class FormNewHotel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDownEstrellas = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rEGIMENESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.rEGIMENESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.REGIMENESTableAdapter();
            this.tableAdapterManager = new FrbaHotel.GD1C2018DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstrellas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(90, 27);
            this.textBoxNombre.MaxLength = 500;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 1;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(90, 70);
            this.textBoxMail.MaxLength = 50;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mail";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(90, 115);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefono.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefono";
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(90, 244);
            this.textBoxCiudad.MaxLength = 50;
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCiudad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ciudad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estrellas";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(90, 156);
            this.textBoxDireccion.MaxLength = 100;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(100, 20);
            this.textBoxDireccion.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(233, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Regimen";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(312, 27);
            this.textBoxPais.MaxLength = 50;
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(100, 20);
            this.textBoxPais.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Pais";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDownEstrellas
            // 
            this.numericUpDownEstrellas.Location = new System.Drawing.Point(90, 200);
            this.numericUpDownEstrellas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownEstrellas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEstrellas.Name = "numericUpDownEstrellas";
            this.numericUpDownEstrellas.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEstrellas.TabIndex = 18;
            this.numericUpDownEstrellas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedIndex", this.rEGIMENESBindingSource, "DESCRIPCION", true));
            this.checkedListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.rEGIMENESBindingSource, "DESCRIPCION", true));
            this.checkedListBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.rEGIMENESBindingSource, "DESCRIPCION", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "aaa"));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(312, 70);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(196, 79);
            this.checkedListBox1.TabIndex = 19;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // rEGIMENESBindingSource
            // 
            this.rEGIMENESBindingSource.DataMember = "REGIMENES";
            this.rEGIMENESBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEGIMENESTableAdapter
            // 
            this.rEGIMENESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BAJA_HOTELESTableAdapter = null;
            this.tableAdapterManager.CLIENTES_POR_RESERVATableAdapter = null;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CONSUMIBLESTableAdapter = null;
            this.tableAdapterManager.ESTADIASTableAdapter = null;
            this.tableAdapterManager.ESTADOS_RESERVATableAdapter = null;
            this.tableAdapterManager.FACTURATableAdapter = null;
            this.tableAdapterManager.FUNCIONALIDADES_POR_ROLTableAdapter = null;
            this.tableAdapterManager.FUNCIONALIDADESTableAdapter = null;
            this.tableAdapterManager.HABITACIONES_POR_RESERVATableAdapter = null;
            this.tableAdapterManager.HABITACIONESTableAdapter = null;
            this.tableAdapterManager.HOTELES_POR_USUARIOTableAdapter = null;
            this.tableAdapterManager.HOTELESTableAdapter = null;
            this.tableAdapterManager.ITEM_FACTURATableAdapter = null;
            this.tableAdapterManager.REGIMENES_POR_HOTELTableAdapter = null;
            this.tableAdapterManager.REGIMENESTableAdapter = null;
            this.tableAdapterManager.REGISTRO_RESERVASTableAdapter = null;
            this.tableAdapterManager.RESERVASTableAdapter = null;
            this.tableAdapterManager.ROLES_POR_USUARIOTableAdapter = null;
            this.tableAdapterManager.ROLESTableAdapter = null;
            this.tableAdapterManager.TIPOS_HABITACIONTableAdapter = null;
            this.tableAdapterManager.TIPOS_IDENTIFICACIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FrbaHotel.GD1C2018DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOSTableAdapter = null;
            // 
            // FormNewHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 352);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.numericUpDownEstrellas);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Name = "FormNewHotel";
            this.Text = "FormNewHotel";
            this.Load += new System.EventHandler(this.FormNewHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEstrellas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGIMENESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDownEstrellas;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource rEGIMENESBindingSource;
        private GD1C2018DataSetTableAdapters.REGIMENESTableAdapter rEGIMENESTableAdapter;
        private GD1C2018DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}