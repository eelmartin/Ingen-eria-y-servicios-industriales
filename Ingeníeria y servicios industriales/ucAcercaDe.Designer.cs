namespace Ingeníeria_y_servicios_industriales
{
    partial class ucAcercaDe
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
            this.lb_inicio = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_colaboracion = new System.Windows.Forms.Label();
            this.lbl_jesus = new System.Windows.Forms.Label();
            this.lbl_abraham = new System.Windows.Forms.Label();
            this.lbl_martin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_inicio
            // 
            this.lb_inicio.AutoSize = true;
            this.lb_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inicio.Location = new System.Drawing.Point(332, 268);
            this.lb_inicio.Name = "lb_inicio";
            this.lb_inicio.Size = new System.Drawing.Size(454, 31);
            this.lb_inicio.TabIndex = 3;
            this.lb_inicio.Text = "Ingeniería y Servicios Industriales";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ingeníeria_y_servicios_industriales.Properties.Resources.logoEmpresa;
            this.pictureBox1.Location = new System.Drawing.Point(415, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_colaboracion
            // 
            this.lbl_colaboracion.AutoSize = true;
            this.lbl_colaboracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_colaboracion.Location = new System.Drawing.Point(397, 318);
            this.lbl_colaboracion.Name = "lbl_colaboracion";
            this.lbl_colaboracion.Size = new System.Drawing.Size(323, 20);
            this.lbl_colaboracion.TabIndex = 4;
            this.lbl_colaboracion.Text = "Sistema realizado en colaboración con:";
            // 
            // lbl_jesus
            // 
            this.lbl_jesus.AutoSize = true;
            this.lbl_jesus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_jesus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_jesus.ForeColor = System.Drawing.Color.Blue;
            this.lbl_jesus.Location = new System.Drawing.Point(505, 350);
            this.lbl_jesus.Name = "lbl_jesus";
            this.lbl_jesus.Size = new System.Drawing.Size(112, 20);
            this.lbl_jesus.TabIndex = 5;
            this.lbl_jesus.Text = "Jesús Miranda";
            this.lbl_jesus.Click += new System.EventHandler(this.lbl_jesus_Click);
            // 
            // lbl_abraham
            // 
            this.lbl_abraham.AutoSize = true;
            this.lbl_abraham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_abraham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_abraham.ForeColor = System.Drawing.Color.Blue;
            this.lbl_abraham.Location = new System.Drawing.Point(493, 390);
            this.lbl_abraham.Name = "lbl_abraham";
            this.lbl_abraham.Size = new System.Drawing.Size(135, 20);
            this.lbl_abraham.TabIndex = 6;
            this.lbl_abraham.Text = "Abraham Miranda";
            this.lbl_abraham.Click += new System.EventHandler(this.lbl_abraham_Click);
            // 
            // lbl_martin
            // 
            this.lbl_martin.AutoSize = true;
            this.lbl_martin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_martin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_martin.ForeColor = System.Drawing.Color.Blue;
            this.lbl_martin.Location = new System.Drawing.Point(514, 429);
            this.lbl_martin.Name = "lbl_martin";
            this.lbl_martin.Size = new System.Drawing.Size(91, 20);
            this.lbl_martin.TabIndex = 7;
            this.lbl_martin.Text = "Martín Soto";
            this.lbl_martin.Click += new System.EventHandler(this.lbl_martin_Click);
            // 
            // ucAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_martin);
            this.Controls.Add(this.lbl_abraham);
            this.Controls.Add(this.lbl_jesus);
            this.Controls.Add(this.lbl_colaboracion);
            this.Controls.Add(this.lb_inicio);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucAcercaDe";
            this.Size = new System.Drawing.Size(1045, 680);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_abraham;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Label lbl_martin;
        private System.Windows.Forms.Label lbl_jesus;
        private System.Windows.Forms.Label lbl_colaboracion;
        private System.Windows.Forms.Label lb_inicio;
    }
}
