namespace FrbaHotel.AbmUsuario
{
    partial class BuscadorForm
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
            this.nacimientoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            this.rOLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD1C2018DataSet = new FrbaHotel.GD1C2018DataSet();
            this.tipoIdCB = new System.Windows.Forms.ComboBox();
            this.tIPOSIDENTIFICACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numeroIdTB = new System.Windows.Forms.TextBox();
            this.mailTB = new System.Windows.Forms.TextBox();
            this.telefonoTB = new System.Windows.Forms.TextBox();
            this.direccionTB = new System.Windows.Forms.TextBox();
            this.apellidoTB = new System.Windows.Forms.TextBox();
            this.nombreTB = new System.Windows.Forms.TextBox();
            this.usuarioTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaNacimientoCB = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.editarBtn = new System.Windows.Forms.Button();
            this.eliminarBtn = new System.Windows.Forms.Button();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.rolCB = new System.Windows.Forms.CheckBox();
            this.tipoIdCheckBox = new System.Windows.Forms.CheckBox();
            this.rOLESTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.ROLESTableAdapter();
            this.tIPOS_IDENTIFICACIONTableAdapter = new FrbaHotel.GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // nacimientoDatePicker
            // 
            this.nacimientoDatePicker.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.nacimientoDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nacimientoDatePicker.Location = new System.Drawing.Point(467, 190);
            this.nacimientoDatePicker.Name = "nacimientoDatePicker";
            this.nacimientoDatePicker.Size = new System.Drawing.Size(121, 20);
            this.nacimientoDatePicker.TabIndex = 44;
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataSource = this.rOLESBindingSource;
            this.rolComboBox.DisplayMember = "NOMBRE";
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Location = new System.Drawing.Point(467, 24);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(121, 21);
            this.rolComboBox.TabIndex = 43;
            this.rolComboBox.ValueMember = "ID_ROL";
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
            // tipoIdCB
            // 
            this.tipoIdCB.DataSource = this.tIPOSIDENTIFICACIONBindingSource;
            this.tipoIdCB.DisplayMember = "DESCRIPCION";
            this.tipoIdCB.FormattingEnabled = true;
            this.tipoIdCB.Location = new System.Drawing.Point(149, 100);
            this.tipoIdCB.Name = "tipoIdCB";
            this.tipoIdCB.Size = new System.Drawing.Size(121, 21);
            this.tipoIdCB.TabIndex = 42;
            this.tipoIdCB.ValueMember = "TIPO_IDENTIFICACION";
            // 
            // tIPOSIDENTIFICACIONBindingSource
            // 
            this.tIPOSIDENTIFICACIONBindingSource.DataMember = "TIPOS_IDENTIFICACION";
            this.tIPOSIDENTIFICACIONBindingSource.DataSource = this.gD1C2018DataSet;
            // 
            // numeroIdTB
            // 
            this.numeroIdTB.Location = new System.Drawing.Point(467, 103);
            this.numeroIdTB.Name = "numeroIdTB";
            this.numeroIdTB.Size = new System.Drawing.Size(121, 20);
            this.numeroIdTB.TabIndex = 41;
            // 
            // mailTB
            // 
            this.mailTB.Location = new System.Drawing.Point(149, 144);
            this.mailTB.Name = "mailTB";
            this.mailTB.Size = new System.Drawing.Size(121, 20);
            this.mailTB.TabIndex = 40;
            // 
            // telefonoTB
            // 
            this.telefonoTB.Location = new System.Drawing.Point(467, 146);
            this.telefonoTB.Name = "telefonoTB";
            this.telefonoTB.Size = new System.Drawing.Size(121, 20);
            this.telefonoTB.TabIndex = 39;
            // 
            // direccionTB
            // 
            this.direccionTB.Location = new System.Drawing.Point(149, 187);
            this.direccionTB.Name = "direccionTB";
            this.direccionTB.Size = new System.Drawing.Size(121, 20);
            this.direccionTB.TabIndex = 38;
            // 
            // apellidoTB
            // 
            this.apellidoTB.Location = new System.Drawing.Point(467, 60);
            this.apellidoTB.Name = "apellidoTB";
            this.apellidoTB.Size = new System.Drawing.Size(121, 20);
            this.apellidoTB.TabIndex = 37;
            // 
            // nombreTB
            // 
            this.nombreTB.Location = new System.Drawing.Point(149, 57);
            this.nombreTB.Name = "nombreTB";
            this.nombreTB.Size = new System.Drawing.Size(121, 20);
            this.nombreTB.TabIndex = 36;
            // 
            // usuarioTB
            // 
            this.usuarioTB.Location = new System.Drawing.Point(149, 21);
            this.usuarioTB.Name = "usuarioTB";
            this.usuarioTB.Size = new System.Drawing.Size(121, 20);
            this.usuarioTB.TabIndex = 34;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(297, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Numero ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Usuario";
            // 
            // fechaNacimientoCB
            // 
            this.fechaNacimientoCB.AutoSize = true;
            this.fechaNacimientoCB.Location = new System.Drawing.Point(300, 190);
            this.fechaNacimientoCB.Name = "fechaNacimientoCB";
            this.fechaNacimientoCB.Size = new System.Drawing.Size(125, 17);
            this.fechaNacimientoCB.TabIndex = 48;
            this.fechaNacimientoCB.Text = "Fecha de nacimineto";
            this.fechaNacimientoCB.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 268);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 150);
            this.dataGridView1.TabIndex = 49;
            // 
            // editarBtn
            // 
            this.editarBtn.Location = new System.Drawing.Point(41, 424);
            this.editarBtn.Name = "editarBtn";
            this.editarBtn.Size = new System.Drawing.Size(75, 23);
            this.editarBtn.TabIndex = 50;
            this.editarBtn.Text = "Editar";
            this.editarBtn.UseVisualStyleBackColor = true;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(513, 424);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(75, 23);
            this.eliminarBtn.TabIndex = 51;
            this.eliminarBtn.Text = "Eliminar";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            // 
            // buscarBtn
            // 
            this.buscarBtn.Location = new System.Drawing.Point(41, 239);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(75, 23);
            this.buscarBtn.TabIndex = 52;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = true;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // rolCB
            // 
            this.rolCB.AutoSize = true;
            this.rolCB.Location = new System.Drawing.Point(300, 26);
            this.rolCB.Name = "rolCB";
            this.rolCB.Size = new System.Drawing.Size(42, 17);
            this.rolCB.TabIndex = 53;
            this.rolCB.Text = "Rol";
            this.rolCB.UseVisualStyleBackColor = true;
            this.rolCB.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tipoIdCheckBox
            // 
            this.tipoIdCheckBox.AutoSize = true;
            this.tipoIdCheckBox.Location = new System.Drawing.Point(41, 102);
            this.tipoIdCheckBox.Name = "tipoIdCheckBox";
            this.tipoIdCheckBox.Size = new System.Drawing.Size(61, 17);
            this.tipoIdCheckBox.TabIndex = 54;
            this.tipoIdCheckBox.Text = "Tipo ID";
            this.tipoIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // rOLESTableAdapter
            // 
            this.rOLESTableAdapter.ClearBeforeFill = true;
            // 
            // tIPOS_IDENTIFICACIONTableAdapter
            // 
            this.tIPOS_IDENTIFICACIONTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(639, 25);
            this.fillBy1ToolStrip.TabIndex = 55;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Visible = false;
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // BuscadorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 467);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.tipoIdCheckBox);
            this.Controls.Add(this.rolCB);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.editarBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fechaNacimientoCB);
            this.Controls.Add(this.nacimientoDatePicker);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(this.tipoIdCB);
            this.Controls.Add(this.numeroIdTB);
            this.Controls.Add(this.mailTB);
            this.Controls.Add(this.telefonoTB);
            this.Controls.Add(this.direccionTB);
            this.Controls.Add(this.apellidoTB);
            this.Controls.Add(this.nombreTB);
            this.Controls.Add(this.usuarioTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "BuscadorForm";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.BuscadorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rOLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD1C2018DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIPOSIDENTIFICACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker nacimientoDatePicker;
        private System.Windows.Forms.ComboBox rolComboBox;
        private System.Windows.Forms.ComboBox tipoIdCB;
        private System.Windows.Forms.TextBox numeroIdTB;
        private System.Windows.Forms.TextBox mailTB;
        private System.Windows.Forms.TextBox telefonoTB;
        private System.Windows.Forms.TextBox direccionTB;
        private System.Windows.Forms.TextBox apellidoTB;
        private System.Windows.Forms.TextBox nombreTB;
        private System.Windows.Forms.TextBox usuarioTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox fechaNacimientoCB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button editarBtn;
        private System.Windows.Forms.Button eliminarBtn;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.CheckBox rolCB;
        private System.Windows.Forms.CheckBox tipoIdCheckBox;
        private GD1C2018DataSet gD1C2018DataSet;
        private System.Windows.Forms.BindingSource rOLESBindingSource;
        private GD1C2018DataSetTableAdapters.ROLESTableAdapter rOLESTableAdapter;
        private System.Windows.Forms.BindingSource tIPOSIDENTIFICACIONBindingSource;
        private GD1C2018DataSetTableAdapters.TIPOS_IDENTIFICACIONTableAdapter tIPOS_IDENTIFICACIONTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}