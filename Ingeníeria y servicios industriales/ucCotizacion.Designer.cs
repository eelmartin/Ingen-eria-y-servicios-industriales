namespace Ingeníeria_y_servicios_industriales
{
    partial class ucCotizacion
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.dgv_materialservicio = new System.Windows.Forms.DataGridView();
            this.btn_generarcotizacion = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lbl_concepto = new System.Windows.Forms.Label();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_colonia = new System.Windows.Forms.TextBox();
            this.txt_correo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_rfc = new System.Windows.Forms.TextBox();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.lbl_calle = new System.Windows.Forms.Label();
            this.lbl_colonia = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_correo = new System.Windows.Forms.Label();
            this.lbl_telefono = new System.Windows.Forms.Label();
            this.lbl_rfc = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_cotizacion = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_tituloTotal = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materialservicio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.lbl_cotizacion);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 670);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(35, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(977, 616);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_total);
            this.tabPage2.Controls.Add(this.lbl_tituloTotal);
            this.tabPage2.Controls.Add(this.txt_descripcion);
            this.tabPage2.Controls.Add(this.lbl_descripcion);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_cancelar);
            this.tabPage2.Controls.Add(this.dgv_materialservicio);
            this.tabPage2.Controls.Add(this.btn_generarcotizacion);
            this.tabPage2.Controls.Add(this.btn_agregar);
            this.tabPage2.Controls.Add(this.lbl_concepto);
            this.tabPage2.Controls.Add(this.lbl_cantidad);
            this.tabPage2.Controls.Add(this.lbl_precio);
            this.tabPage2.Controls.Add(this.txt_precio);
            this.tabPage2.Controls.Add(this.txt_concepto);
            this.tabPage2.Controls.Add(this.txt_cantidad);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(969, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Generar Cotización";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Agregar Material y/o Servicio";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = global::Ingeníeria_y_servicios_industriales.Properties.Resources.cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.Location = new System.Drawing.Point(259, 546);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(108, 31);
            this.btn_cancelar.TabIndex = 24;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // dgv_materialservicio
            // 
            this.dgv_materialservicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_materialservicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgv_materialservicio.Location = new System.Drawing.Point(44, 361);
            this.dgv_materialservicio.Name = "dgv_materialservicio";
            this.dgv_materialservicio.Size = new System.Drawing.Size(738, 175);
            this.dgv_materialservicio.TabIndex = 22;
            // 
            // btn_generarcotizacion
            // 
            this.btn_generarcotizacion.Location = new System.Drawing.Point(44, 546);
            this.btn_generarcotizacion.Name = "btn_generarcotizacion";
            this.btn_generarcotizacion.Size = new System.Drawing.Size(181, 31);
            this.btn_generarcotizacion.TabIndex = 20;
            this.btn_generarcotizacion.Text = "Generar Cotización";
            this.btn_generarcotizacion.UseVisualStyleBackColor = true;
            this.btn_generarcotizacion.Click += new System.EventHandler(this.btn_generarcotizacion_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(677, 317);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(105, 35);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lbl_concepto
            // 
            this.lbl_concepto.AutoSize = true;
            this.lbl_concepto.Location = new System.Drawing.Point(75, 326);
            this.lbl_concepto.Name = "lbl_concepto";
            this.lbl_concepto.Size = new System.Drawing.Size(86, 18);
            this.lbl_concepto.TabIndex = 16;
            this.lbl_concepto.Text = "Concepto:";
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Location = new System.Drawing.Point(319, 326);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(79, 18);
            this.lbl_cantidad.TabIndex = 17;
            this.lbl_cantidad.Text = "Cantidad:";
            // 
            // lbl_precio
            // 
            this.lbl_precio.AutoSize = true;
            this.lbl_precio.Location = new System.Drawing.Point(505, 326);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(62, 18);
            this.lbl_precio.TabIndex = 18;
            this.lbl_precio.Text = "Precio:";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(567, 323);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(100, 24);
            this.txt_precio.TabIndex = 17;
            // 
            // txt_concepto
            // 
            this.txt_concepto.Location = new System.Drawing.Point(166, 323);
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.Size = new System.Drawing.Size(147, 24);
            this.txt_concepto.TabIndex = 15;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(405, 323);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 24);
            this.txt_cantidad.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_cliente);
            this.groupBox1.Controls.Add(this.txt_numero);
            this.groupBox1.Controls.Add(this.txt_calle);
            this.groupBox1.Controls.Add(this.txt_colonia);
            this.groupBox1.Controls.Add(this.txt_correo);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.txt_rfc);
            this.groupBox1.Controls.Add(this.lbl_numero);
            this.groupBox1.Controls.Add(this.lbl_calle);
            this.groupBox1.Controls.Add(this.lbl_colonia);
            this.groupBox1.Controls.Add(this.lbl_direccion);
            this.groupBox1.Controls.Add(this.lbl_correo);
            this.groupBox1.Controls.Add(this.lbl_telefono);
            this.groupBox1.Controls.Add(this.lbl_rfc);
            this.groupBox1.Controls.Add(this.lbl_cliente);
            this.groupBox1.Location = new System.Drawing.Point(44, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(738, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(482, 152);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.ReadOnly = true;
            this.txt_numero.Size = new System.Drawing.Size(130, 24);
            this.txt_numero.TabIndex = 14;
            // 
            // txt_calle
            // 
            this.txt_calle.Location = new System.Drawing.Point(482, 113);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.ReadOnly = true;
            this.txt_calle.Size = new System.Drawing.Size(230, 24);
            this.txt_calle.TabIndex = 13;
            // 
            // txt_colonia
            // 
            this.txt_colonia.Location = new System.Drawing.Point(482, 78);
            this.txt_colonia.Name = "txt_colonia";
            this.txt_colonia.ReadOnly = true;
            this.txt_colonia.Size = new System.Drawing.Size(230, 24);
            this.txt_colonia.TabIndex = 12;
            // 
            // txt_correo
            // 
            this.txt_correo.Location = new System.Drawing.Point(125, 152);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.ReadOnly = true;
            this.txt_correo.Size = new System.Drawing.Size(230, 24);
            this.txt_correo.TabIndex = 11;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(125, 113);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.ReadOnly = true;
            this.txt_telefono.Size = new System.Drawing.Size(230, 24);
            this.txt_telefono.TabIndex = 10;
            // 
            // txt_rfc
            // 
            this.txt_rfc.Location = new System.Drawing.Point(125, 78);
            this.txt_rfc.Name = "txt_rfc";
            this.txt_rfc.ReadOnly = true;
            this.txt_rfc.Size = new System.Drawing.Size(230, 24);
            this.txt_rfc.TabIndex = 9;
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(411, 155);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(68, 18);
            this.lbl_numero.TabIndex = 7;
            this.lbl_numero.Text = "Número";
            // 
            // lbl_calle
            // 
            this.lbl_calle.AutoSize = true;
            this.lbl_calle.Location = new System.Drawing.Point(411, 116);
            this.lbl_calle.Name = "lbl_calle";
            this.lbl_calle.Size = new System.Drawing.Size(46, 18);
            this.lbl_calle.TabIndex = 6;
            this.lbl_calle.Text = "Calle";
            // 
            // lbl_colonia
            // 
            this.lbl_colonia.AutoSize = true;
            this.lbl_colonia.Location = new System.Drawing.Point(411, 81);
            this.lbl_colonia.Name = "lbl_colonia";
            this.lbl_colonia.Size = new System.Drawing.Size(66, 18);
            this.lbl_colonia.TabIndex = 5;
            this.lbl_colonia.Text = "Colonia";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(411, 47);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(80, 18);
            this.lbl_direccion.TabIndex = 4;
            this.lbl_direccion.Text = "Dirección";
            // 
            // lbl_correo
            // 
            this.lbl_correo.AutoSize = true;
            this.lbl_correo.Location = new System.Drawing.Point(38, 155);
            this.lbl_correo.Name = "lbl_correo";
            this.lbl_correo.Size = new System.Drawing.Size(66, 18);
            this.lbl_correo.TabIndex = 3;
            this.lbl_correo.Text = "Correo:";
            // 
            // lbl_telefono
            // 
            this.lbl_telefono.AutoSize = true;
            this.lbl_telefono.Location = new System.Drawing.Point(38, 116);
            this.lbl_telefono.Name = "lbl_telefono";
            this.lbl_telefono.Size = new System.Drawing.Size(79, 18);
            this.lbl_telefono.TabIndex = 2;
            this.lbl_telefono.Text = "Telefono:";
            // 
            // lbl_rfc
            // 
            this.lbl_rfc.AutoSize = true;
            this.lbl_rfc.Location = new System.Drawing.Point(38, 81);
            this.lbl_rfc.Name = "lbl_rfc";
            this.lbl_rfc.Size = new System.Drawing.Size(47, 18);
            this.lbl_rfc.TabIndex = 1;
            this.lbl_rfc.Text = "RFC:";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(38, 47);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(65, 18);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // lbl_cotizacion
            // 
            this.lbl_cotizacion.AutoSize = true;
            this.lbl_cotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cotizacion.Location = new System.Drawing.Point(38, 13);
            this.lbl_cotizacion.Name = "lbl_cotizacion";
            this.lbl_cotizacion.Size = new System.Drawing.Size(135, 29);
            this.lbl_cotizacion.TabIndex = 0;
            this.lbl_cotizacion.Text = "Cotización";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(125, 44);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(230, 26);
            this.cmb_cliente.TabIndex = 15;
            this.cmb_cliente.SelectedIndexChanged += new System.EventHandler(this.cmb_cliente_SelectedIndexChanged);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(62, 244);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(103, 18);
            this.lbl_descripcion.TabIndex = 26;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(171, 229);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(611, 48);
            this.txt_descripcion.TabIndex = 27;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Concepto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 275;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // lbl_tituloTotal
            // 
            this.lbl_tituloTotal.AutoSize = true;
            this.lbl_tituloTotal.Location = new System.Drawing.Point(668, 546);
            this.lbl_tituloTotal.Name = "lbl_tituloTotal";
            this.lbl_tituloTotal.Size = new System.Drawing.Size(51, 18);
            this.lbl_tituloTotal.TabIndex = 28;
            this.lbl_tituloTotal.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(725, 546);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(35, 18);
            this.lbl_total.TabIndex = 29;
            this.lbl_total.Text = "$$$";
            // 
            // ucCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ucCotizacion";
            this.Size = new System.Drawing.Size(1044, 678);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_materialservicio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cotizacion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_materialservicio;
        private System.Windows.Forms.Button btn_generarcotizacion;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label lbl_concepto;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_concepto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_colonia;
        private System.Windows.Forms.TextBox txt_correo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_rfc;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label lbl_calle;
        private System.Windows.Forms.Label lbl_colonia;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_correo;
        private System.Windows.Forms.Label lbl_telefono;
        private System.Windows.Forms.Label lbl_rfc;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_tituloTotal;
    }
}
