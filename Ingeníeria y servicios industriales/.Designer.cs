namespace Ingeníeria_y_servicios_industriales
{
    partial class Pantalla
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pantalla));
            this.pn_menu = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_cotizacion = new System.Windows.Forms.Button();
            this.btn_OrdenS = new System.Windows.Forms.Button();
            this.btn_OrdenC = new System.Windows.Forms.Button();
            this.btn_CDP = new System.Windows.Forms.Button();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.pn_principal = new System.Windows.Forms.Panel();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.pn_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_menu
            // 
            this.pn_menu.AutoSize = true;
            this.pn_menu.BackColor = System.Drawing.Color.Brown;
            this.pn_menu.Controls.Add(this.btn_salir);
            this.pn_menu.Controls.Add(this.btn_inicio);
            this.pn_menu.Controls.Add(this.btn_cotizacion);
            this.pn_menu.Controls.Add(this.btn_OrdenS);
            this.pn_menu.Controls.Add(this.btn_OrdenC);
            this.pn_menu.Controls.Add(this.btn_CDP);
            this.pn_menu.Controls.Add(this.btn_proveedores);
            this.pn_menu.Controls.Add(this.btn_cliente);
            this.pn_menu.Location = new System.Drawing.Point(0, 0);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(201, 733);
            this.pn_menu.TabIndex = 0;
            this.pn_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_menu_Paint);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_salir.Image")));
            this.btn_salir.Location = new System.Drawing.Point(3, 685);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(41, 45);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackColor = System.Drawing.Color.Gold;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicio.Location = new System.Drawing.Point(0, 0);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(198, 39);
            this.btn_inicio.TabIndex = 0;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = false;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // btn_cotizacion
            // 
            this.btn_cotizacion.BackColor = System.Drawing.Color.Transparent;
            this.btn_cotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cotizacion.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cotizacion.Location = new System.Drawing.Point(0, 228);
            this.btn_cotizacion.Name = "btn_cotizacion";
            this.btn_cotizacion.Size = new System.Drawing.Size(198, 39);
            this.btn_cotizacion.TabIndex = 1;
            this.btn_cotizacion.Text = "Cotización";
            this.btn_cotizacion.UseVisualStyleBackColor = false;
            this.btn_cotizacion.Click += new System.EventHandler(this.btn_cotizacion_Click);
            this.btn_cotizacion.MouseLeave += new System.EventHandler(this.btn_cotizacion_MouseLeave);
            this.btn_cotizacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_cotizacion_MouseMove);
            // 
            // btn_OrdenS
            // 
            this.btn_OrdenS.BackColor = System.Drawing.Color.Transparent;
            this.btn_OrdenS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrdenS.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrdenS.Location = new System.Drawing.Point(0, 190);
            this.btn_OrdenS.Name = "btn_OrdenS";
            this.btn_OrdenS.Size = new System.Drawing.Size(198, 39);
            this.btn_OrdenS.TabIndex = 1;
            this.btn_OrdenS.Text = "Orden de Servicio";
            this.btn_OrdenS.UseVisualStyleBackColor = false;
            this.btn_OrdenS.Click += new System.EventHandler(this.btn_OrdenS_Click);
            this.btn_OrdenS.MouseLeave += new System.EventHandler(this.btn_OrdenS_MouseLeave);
            this.btn_OrdenS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_OrdenS_MouseMove);
            // 
            // btn_OrdenC
            // 
            this.btn_OrdenC.BackColor = System.Drawing.Color.Transparent;
            this.btn_OrdenC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OrdenC.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrdenC.Location = new System.Drawing.Point(0, 152);
            this.btn_OrdenC.Name = "btn_OrdenC";
            this.btn_OrdenC.Size = new System.Drawing.Size(198, 39);
            this.btn_OrdenC.TabIndex = 3;
            this.btn_OrdenC.Text = "Orden de Compra";
            this.btn_OrdenC.UseVisualStyleBackColor = false;
            this.btn_OrdenC.Click += new System.EventHandler(this.btn_OrdenC_Click);
            this.btn_OrdenC.MouseLeave += new System.EventHandler(this.btn_OrdenC_MouseLeave);
            this.btn_OrdenC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_OrdenC_MouseMove);
            // 
            // btn_CDP
            // 
            this.btn_CDP.BackColor = System.Drawing.Color.Transparent;
            this.btn_CDP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CDP.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CDP.Location = new System.Drawing.Point(0, 38);
            this.btn_CDP.Name = "btn_CDP";
            this.btn_CDP.Size = new System.Drawing.Size(198, 39);
            this.btn_CDP.TabIndex = 0;
            this.btn_CDP.Text = "Cartera de Proyectos";
            this.btn_CDP.UseVisualStyleBackColor = false;
            this.btn_CDP.Click += new System.EventHandler(this.btn_CDP_Click);
            this.btn_CDP.MouseLeave += new System.EventHandler(this.btn_CDP_MouseLeave);
            this.btn_CDP.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_CDP_MouseMove);
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.BackColor = System.Drawing.Color.Transparent;
            this.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedores.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proveedores.Location = new System.Drawing.Point(0, 114);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(198, 39);
            this.btn_proveedores.TabIndex = 2;
            this.btn_proveedores.Text = "Proveedores";
            this.btn_proveedores.UseVisualStyleBackColor = false;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            this.btn_proveedores.MouseLeave += new System.EventHandler(this.btn_proveedores_MouseLeave);
            this.btn_proveedores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_proveedores_MouseMove);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.Transparent;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.Location = new System.Drawing.Point(0, 76);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(198, 39);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Clientes";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            this.btn_cliente.MouseLeave += new System.EventHandler(this.btn_cliente_MouseLeave);
            this.btn_cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_cliente_MouseMove);
            // 
            // pn_principal
            // 
            this.pn_principal.Location = new System.Drawing.Point(200, 1);
            this.pn_principal.Name = "pn_principal";
            this.pn_principal.Size = new System.Drawing.Size(1064, 698);
            this.pn_principal.TabIndex = 1;
            // 
            // btn_regresar
            // 
            this.btn_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(1284, 666);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(49, 35);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Visible = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // Pantalla
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.pn_principal);
            this.Controls.Add(this.pn_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Pantalla";
            this.ShowIcon = false;
            this.Text = "Ingenieria y Servicios Industriales.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Pantalla_Load);
            this.pn_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Button btn_CDP;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_proveedores;
        private System.Windows.Forms.Button btn_OrdenC;
        private System.Windows.Forms.Button btn_cotizacion;
        private System.Windows.Forms.Button btn_OrdenS;
        private System.Windows.Forms.Panel pn_principal;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_regresar;
    }
}

