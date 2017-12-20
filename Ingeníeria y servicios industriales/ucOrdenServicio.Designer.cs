namespace Ingeníeria_y_servicios_industriales
{
    partial class ucOrdenServicio
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tc_ordenServicio = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cmb_nproyecto = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_total2 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_generarorden = new System.Windows.Forms.Button();
            this.dgv_servicios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_datosprovedor = new System.Windows.Forms.GroupBox();
            this.cmb_proveedor = new System.Windows.Forms.ComboBox();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_num = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_colonia = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.txt_numproyecto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_ordenservicio = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tc_ordenServicio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).BeginInit();
            this.gb_datosprovedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tc_ordenServicio);
            this.panel1.Controls.Add(this.lbl_ordenservicio);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 675);
            this.panel1.TabIndex = 0;
            // 
            // tc_ordenServicio
            // 
            this.tc_ordenServicio.Controls.Add(this.tabPage1);
            this.tc_ordenServicio.Controls.Add(this.tabPage2);
            this.tc_ordenServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_ordenServicio.Location = new System.Drawing.Point(34, 51);
            this.tc_ordenServicio.Name = "tc_ordenServicio";
            this.tc_ordenServicio.SelectedIndex = 0;
            this.tc_ordenServicio.Size = new System.Drawing.Size(977, 618);
            this.tc_ordenServicio.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cmb_nproyecto);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.lbl_unidad);
            this.tabPage1.Controls.Add(this.lbl_total);
            this.tabPage1.Controls.Add(this.lbl_total2);
            this.tabPage1.Controls.Add(this.btn_cancelar);
            this.tabPage1.Controls.Add(this.btn_generarorden);
            this.tabPage1.Controls.Add(this.dgv_servicios);
            this.tabPage1.Controls.Add(this.txt_precio);
            this.tabPage1.Controls.Add(this.txt_concepto);
            this.tabPage1.Controls.Add(this.lbl_precio);
            this.tabPage1.Controls.Add(this.lbl_concepto);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.gb_datosprovedor);
            this.tabPage1.Controls.Add(this.txt_numproyecto);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_agregar);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(969, 587);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generar Orden de Servicio";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cmb_nproyecto
            // 
            this.cmb_nproyecto.FormattingEnabled = true;
            this.cmb_nproyecto.Location = new System.Drawing.Point(316, 17);
            this.cmb_nproyecto.Name = "cmb_nproyecto";
            this.cmb_nproyecto.Size = new System.Drawing.Size(207, 26);
            this.cmb_nproyecto.TabIndex = 30;
            this.cmb_nproyecto.SelectedIndexChanged += new System.EventHandler(this.cmb_nproyecto_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "HR",
            "DIA",
            "SEMANA"});
            this.comboBox1.Location = new System.Drawing.Point(478, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 26);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_unidad.Location = new System.Drawing.Point(397, 269);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(60, 18);
            this.lbl_unidad.TabIndex = 18;
            this.lbl_unidad.Text = "Unidad";
            this.lbl_unidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(687, 543);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(73, 18);
            this.lbl_total.TabIndex = 17;
            this.lbl_total.Text = "total $$$";
            // 
            // lbl_total2
            // 
            this.lbl_total2.AutoSize = true;
            this.lbl_total2.Location = new System.Drawing.Point(597, 542);
            this.lbl_total2.Name = "lbl_total2";
            this.lbl_total2.Size = new System.Drawing.Size(65, 18);
            this.lbl_total2.TabIndex = 16;
            this.lbl_total2.Text = "TOTAL:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Image = global::Ingeníeria_y_servicios_industriales.Properties.Resources.cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(244, 546);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 31);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_generarorden
            // 
            this.btn_generarorden.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generarorden.Location = new System.Drawing.Point(41, 546);
            this.btn_generarorden.Name = "btn_generarorden";
            this.btn_generarorden.Size = new System.Drawing.Size(181, 31);
            this.btn_generarorden.TabIndex = 13;
            this.btn_generarorden.Text = "Generar Orden";
            this.btn_generarorden.UseVisualStyleBackColor = true;
            this.btn_generarorden.Click += new System.EventHandler(this.btn_generarorden_Click);
            // 
            // dgv_servicios
            // 
            this.dgv_servicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_servicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.unidad,
            this.Column4});
            this.dgv_servicios.Location = new System.Drawing.Point(41, 311);
            this.dgv_servicios.Name = "dgv_servicios";
            this.dgv_servicios.Size = new System.Drawing.Size(814, 215);
            this.dgv_servicios.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Concepto";
            this.Column1.Name = "Column1";
            this.Column1.Width = 245;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.Width = 155;
            // 
            // unidad
            // 
            this.unidad.HeaderText = "Unidad";
            this.unidad.Name = "unidad";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.Width = 145;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(670, 266);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(74, 24);
            this.txt_precio.TabIndex = 10;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(144, 266);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(235, 24);
            this.txt_concepto.TabIndex = 9;
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precio.Location = new System.Drawing.Point(607, 269);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(57, 18);
            this.lbl_precio.TabIndex = 8;
            this.lbl_precio.Text = "Precio";
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_concepto.Location = new System.Drawing.Point(52, 269);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(81, 18);
            this.lbl_concepto.TabIndex = 6;
            this.lbl_concepto.Text = "Concepto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar Material";
            // 
            // gb_datosprovedor
            // 
            this.gb_datosprovedor.Controls.Add(this.cmb_proveedor);
            this.gb_datosprovedor.Controls.Add(this.lbl_proveedor);
            this.gb_datosprovedor.Controls.Add(this.txt_numero);
            this.gb_datosprovedor.Controls.Add(this.txt_calle);
            this.gb_datosprovedor.Controls.Add(this.txt_colonia);
            this.gb_datosprovedor.Controls.Add(this.txt_correo);
            this.gb_datosprovedor.Controls.Add(this.txt_telefono);
            this.gb_datosprovedor.Controls.Add(this.txt_rfc);
            this.gb_datosprovedor.Controls.Add(this.lbl_correo);
            this.gb_datosprovedor.Controls.Add(this.lbl_num);
            this.gb_datosprovedor.Controls.Add(this.lbl_calle);
            this.gb_datosprovedor.Controls.Add(this.lbl_colonia);
            this.gb_datosprovedor.Controls.Add(this.lbl_direccion);
            this.gb_datosprovedor.Controls.Add(this.lbl_telefono);
            this.gb_datosprovedor.Controls.Add(this.lbl_rfc);
            this.gb_datosprovedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_datosprovedor.Location = new System.Drawing.Point(41, 53);
            this.gb_datosprovedor.Name = "gb_datosprovedor";
            this.gb_datosprovedor.Size = new System.Drawing.Size(814, 177);
            this.gb_datosprovedor.TabIndex = 4;
            this.gb_datosprovedor.TabStop = false;
            this.gb_datosprovedor.Text = "Datos Proveedor";
            // 
            // cmb_proveedor
            // 
            this.cmb_proveedor.FormattingEnabled = true;
            this.cmb_proveedor.Location = new System.Drawing.Point(108, 34);
            this.cmb_proveedor.Name = "cmb_proveedor";
            this.cmb_proveedor.Size = new System.Drawing.Size(230, 26);
            this.cmb_proveedor.TabIndex = 17;
            this.cmb_proveedor.SelectedIndexChanged += new System.EventHandler(this.cmb_proveedor_SelectedIndexChanged);
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Location = new System.Drawing.Point(14, 34);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(91, 18);
            this.lbl_proveedor.TabIndex = 16;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(469, 139);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(139, 24);
            this.txt_numero.TabIndex = 15;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(469, 105);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.ReadOnly = true;
            this.txt_calle.Size = new System.Drawing.Size(245, 24);
            this.txt_calle.TabIndex = 14;
            // 
            // txt_colonia
            // 
            this.txt_colonia.Location = new System.Drawing.Point(469, 67);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.ReadOnly = true;
            this.txt_colonia.Size = new System.Drawing.Size(245, 24);
            this.txt_colonia.TabIndex = 13;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(108, 142);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.ReadOnly = true;
            this.txt_correo.Size = new System.Drawing.Size(230, 24);
            this.txt_correo.TabIndex = 11;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(108, 105);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(230, 24);
            this.txt_telefono.TabIndex = 10;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(108, 67);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.ReadOnly = true;
            this.txt_rfc.Size = new System.Drawing.Size(230, 24);
            this.txt_rfc.TabIndex = 9;
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(14, 142);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(66, 18);
            this.lbl_correo.TabIndex = 7;
            this.lbl_correo.Text = "Correo:";
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(390, 142);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(73, 18);
            this.lbl_num.TabIndex = 6;
            this.lbl_num.Text = "Número:";
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Location = new System.Drawing.Point(390, 108);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(51, 18);
            this.lbl_calle.TabIndex = 5;
            this.lbl_calle.Text = "Calle:";
            // 
            // lbl_colonia
            // 
            this.lbl_colonia.AutoSize = true;
            this.lbl_colonia.Location = new System.Drawing.Point(390, 70);
            this.lbl_colonia.Name = "lbl_colonia";
            this.lbl_colonia.Size = new System.Drawing.Size(71, 18);
            this.lbl_colonia.TabIndex = 4;
            this.lbl_colonia.Text = "Colonia:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(383, 31);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(85, 18);
            this.lbl_direccion.TabIndex = 3;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(14, 108);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(79, 18);
            this.lbl_telefono.TabIndex = 2;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(14, 70);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(47, 18);
            this.lbl_rfc.TabIndex = 1;
            this.lbl_rfc.Text = "RFC:";
            // 
            // txt_numproyecto
            // 
            this.txt_numproyecto.Location = new System.Drawing.Point(223, 19);
            this.txt_numproyecto.Name = "txt_numproyecto";
            this.txt_numproyecto.ReadOnly = true;
            this.txt_numproyecto.Size = new System.Drawing.Size(73, 24);
            this.txt_numproyecto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de Proyecto:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Location = new System.Drawing.Point(750, 264);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(105, 35);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 587);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Imprimir";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_ordenservicio
            // 
            this.lbl_ordenservicio.AutoSize = true;
            this.lbl_ordenservicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ordenservicio.Location = new System.Drawing.Point(33, 9);
            this.lbl_ordenservicio.Name = "lbl_ordenservicio";
            this.lbl_ordenservicio.Size = new System.Drawing.Size(225, 29);
            this.lbl_ordenservicio.TabIndex = 0;
            this.lbl_ordenservicio.Text = "Orden de Servicio";
            // 
            // ucOrdenServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucOrdenServicio";
            this.Size = new System.Drawing.Size(1044, 678);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tc_ordenServicio.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicios)).EndInit();
            this.gb_datosprovedor.ResumeLayout(false);
            this.gb_datosprovedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_ordenservicio;
        private System.Windows.Forms.TabControl tc_ordenServicio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_numproyecto;
        private System.Windows.Forms.GroupBox gb_datosprovedor;
        private System.Windows.Forms.Label lbl_num;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_colonia;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_servicios;
        private System.Windows.Forms.Button btn_generarorden;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_total2;
        private System.Windows.Forms.ComboBox cmb_proveedor;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cmb_nproyecto;
    }
}
