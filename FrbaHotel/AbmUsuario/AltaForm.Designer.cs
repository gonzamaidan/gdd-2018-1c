namespace FrbaHotel.AbmUsuario
{
    partial class AltaForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.usuarioTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.apellidoTB = new System.Windows.Forms.TextBox();
            this.direccionTB = new System.Windows.Forms.TextBox();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.numeroIdTB = new System.Windows.Forms.TextBox();
            this.tipoIdCB = new System.Windows.Forms.ComboBox();
            this.rOLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.rOLESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.ROLESTableAdapter();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.nacimientoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.hotelesCLB = new System.Windows.Forms.CheckedListBox();
            this.hOTELESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.salirBtn = new System.Windows.Forms.Button();
            this.hOTELESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.HOTELESTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gD1C2018DataSet1 = new FrbaHotel.GD1C2018DataSet();
            this.tIPOSIDENTIFICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tIPOS_IDENTIFICACIONTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELESBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(293, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Numero ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(293, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Telefono";
            // 
            // usuarioTB
            // 
            this.usuarioTB.Location = new System.Drawing.Point(145, 23);
            this.usuarioTB.Name = "usuarioTB";
            this.usuarioTB.Size = new System.Drawing.Size(121, 20);
            this.usuarioTB.TabIndex = 10;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(405, 23);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(121, 20);
            this.passwordTB.TabIndex = 11;
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(145, 110);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(121, 20);
            this.nombreTB.TabIndex = 12;
            // 
            // apellidoTB
            // 
            this.apellidoTB.Location = new System.Drawing.Point(405, 110);
            this.apellidoTB.Name = "apellidoTB";
            this.apellidoTB.Size = new System.Drawing.Size(121, 20);
            this.apellidoTB.TabIndex = 13;
            // 
            // direccionTB
            // 
            this.direccionTB.Location = new System.Drawing.Point(145, 240);
            this.direccionTB.Name = "direccionTB";
            this.direccionTB.Size = new System.Drawing.Size(121, 20);
            this.direccionTB.TabIndex = 14;
            // 
            // telefonoTB
            // 
            this.telefonoTB.Location = new System.Drawing.Point(405, 196);
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.Size = new System.Drawing.Size(121, 20);
            this.telefonoTB.TabIndex = 15;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(145, 197);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(121, 20);
            this.mailTB.TabIndex = 16;
            // 
            // numeroIdTB
            // 
            this.numeroIdTB.Location = new System.Drawing.Point(405, 153);
            this.numeroIdTB.Name = "numeroIdTB";
            this.numeroIdTB.Size = new System.Drawing.Size(121, 20);
            this.numeroIdTB.TabIndex = 17;
            // 
            // tipoIdCB
            // 
            this.tipoIdCB.DataSource = this.tIPOSIDENTIFICACIONBindingSource;
            this.tipoIdCB.DisplayMember = "DESCRIPCION";
            this.tipoIdCB.FormattingEnabled = true;
            this.tipoIdCB.Location = new System.Drawing.Point(145, 153);
            this.tipoIdCB.Name = "tipoIdCB";
            this.tipoIdCB.Size = new System.Drawing.Size(121, 21);
            this.tipoIdCB.TabIndex = 18;
            this.tipoIdCB.ValueMember = "TIPO_IDENTIFICACION";
            // 
            // rOLESBindingSource
            // 
            this.rOLESBindingSource.DataMember = "ROLES";
            this.rOLESBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // gD1C2018DataSet
            // 
            this.gD1C2018DataSet.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rOLESTableAdapter
            // 
            this.rOLESTableAdapter.ClearBeforeFill = true;
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataSource = this.rOLESBindingSource;
            this.rolComboBox.DisplayMember = "NOMBRE";
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(145, 66);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(121, 21);
            this.rolComboBox.TabIndex = 19;
            this.rolComboBox.ValueMember = "ID_ROL";
            // 
            // nacimientoDatePicker
            // 
            this.nacimientoDatePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nacimientoDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimientoDatePicker.Location = new System.Drawing.Point(405, 240);
            this.nacimientoDatePicker.Name = "nacimientoDatePicker";
            this.nacimientoDatePicker.Size = new System.Drawing.Size(121, 20);
            this.nacimientoDatePicker.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 289);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Hotel";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // hotelesCLB
            // 
            this.hotelesCLB.DataSource = this.hOTELESBindingSource;
            this.hotelesCLB.DisplayMember = "NOMBRE";
            this.hotelesCLB.FormattingEnabled = true;
            this.hotelesCLB.Location = new System.Drawing.Point(145, 289);
            this.hotelesCLB.Name = "hotelesCLB";
            this.hotelesCLB.Size = new System.Drawing.Size(381, 94);
            this.hotelesCLB.TabIndex = 22;
            this.hotelesCLB.ValueMember = "ID_HOTEL";
            // 
            // hOTELESBindingSource
            // 
            this.hOTELESBindingSource.DataMember = "HOTELES";
            this.hOTELESBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Fecha de nacimiento";
            // 
            // guardarBtn
            // 
            this.guardarBtn.Location = new System.Drawing.Point(405, 405);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(75, 23);
            this.guardarBtn.TabIndex = 24;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = true;
            this.guardarBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // salirBtn
            // 
            this.salirBtn.Location = new System.Drawing.Point(145, 405);
            this.salirBtn.Name = "salirBtn";
            this.salirBtn.Size = new System.Drawing.Size(75, 23);
            this.salirBtn.TabIndex = 25;
            this.salirBtn.Text = "Salir";
            this.salirBtn.UseVisualStyleBackColor = true;
            // 
            // hOTELESTableAdapter
            // 
            this.hOTELESTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(605, 25);
            this.fillByToolStrip.TabIndex = 26;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(605, 25);
            this.fillByToolStrip1.TabIndex = 27;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            this.fillByToolStrip1.Visible = false;
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // gD1C2018DataSet1
            // 
            this.gD1C2018DataSet1.DataSetName = "GD1C2018DataSet";
            this.gD1C2018DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIPOSIDENTIFICACIONBindingSource
            // 
            this.tIPOSIDENTIFICACIONBindingSource.DataMember = "TIPOS_IDENTIFICACION";
            this.tIPOSIDENTIFICACIONBindingSource.DataSource = this.gD1C2018DataSet1;
            // 
            // tIPOS_IDENTIFICACIONTableAdapter
            // 
            this.tIPOS_IDENTIFICACIONTableAdapter.ClearBeforeFill = true;
            // 
            // AltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 448);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.salirBtn);
            this.Controls.Add(this.guardarBtn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.hotelesCLB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.nacimientoDatePicker);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.tipoIdCB);
            this.Controls.Add(this.numeroIdTB);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.telefonoTB);
            this.Controls.Add(this.direccionTB);
            this.Controls.Add(this.apellidoTB);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usuarioTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AltaForm";
            this.Text = "Alta usuario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTELESBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox usuarioTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.TextBox apellidoTB;
        private System.Windows.Forms.TextBox direccionTB;
        private System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.TextBox numeroIdTB;
        private System.Windows.Forms.ComboBox tipoIdCB;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource rOLESBindingSource;
        private GD1C2018DataSetTableAdapters.ROLESTableAdapter rOLESTableAdapter;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.DateTimePicker nacimientoDatePicker;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox hotelesCLB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.Button salirBtn;
        private System.Windows.Forms.BindingSource hOTELESBindingSource;
        private GD1C2018DataSetTableAdapters.HOTELESTableAdapter hOTELESTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private GD1C2018DataSet gD1C2018DataSet1;
        private System.Windows.Forms.BindingSource tIPOSIDENTIFICACIONBindingSource;
        private GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter tIPOS_IDENTIFICACIONTableAdapter;
    }
}