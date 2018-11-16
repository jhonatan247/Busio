namespace Presentacion.Vistas
{
    partial class viewCortaSucursal
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
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.lbSucursal = new DevComponents.DotNetBar.LabelX();
            this.lbDireccion = new DevComponents.DotNetBar.LabelX();
            this.lbTelefono = new DevComponents.DotNetBar.LabelX();
            this.lbRepresentante = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImagen
            // 
            this.pbImagen.Image = global::Presentacion.Properties.Resources.Shop_96px;
            this.pbImagen.Location = new System.Drawing.Point(17, 15);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(100, 100);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 0;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.viewCortaSucursal_Click);
            // 
            // lbSucursal
            // 
            this.lbSucursal.AutoSize = true;
            // 
            // 
            // 
            this.lbSucursal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbSucursal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lbSucursal.Location = new System.Drawing.Point(123, 15);
            this.lbSucursal.Name = "lbSucursal";
            this.lbSucursal.Size = new System.Drawing.Size(130, 24);
            this.lbSucursal.TabIndex = 1;
            this.lbSucursal.Text = "Sucursal Principal";
            this.lbSucursal.Click += new System.EventHandler(this.viewCortaSucursal_Click);
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            // 
            // 
            // 
            this.lbDireccion.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDireccion.Location = new System.Drawing.Point(123, 45);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(56, 17);
            this.lbDireccion.TabIndex = 2;
            this.lbDireccion.Text = "Dirección: ";
            this.lbDireccion.Click += new System.EventHandler(this.viewCortaSucursal_Click);
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            // 
            // 
            // 
            this.lbTelefono.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTelefono.Location = new System.Drawing.Point(123, 70);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(53, 17);
            this.lbTelefono.TabIndex = 3;
            this.lbTelefono.Text = "Teléfono: ";
            this.lbTelefono.Click += new System.EventHandler(this.viewCortaSucursal_Click);
            // 
            // lbRepresentante
            // 
            this.lbRepresentante.AutoSize = true;
            // 
            // 
            // 
            this.lbRepresentante.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbRepresentante.Location = new System.Drawing.Point(123, 92);
            this.lbRepresentante.Name = "lbRepresentante";
            this.lbRepresentante.Size = new System.Drawing.Size(80, 17);
            this.lbRepresentante.TabIndex = 4;
            this.lbRepresentante.Text = "Representante: ";
            this.lbRepresentante.Click += new System.EventHandler(this.viewCortaSucursal_Click);
            // 
            // viewCortaSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbRepresentante);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbSucursal);
            this.Controls.Add(this.pbImagen);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "viewCortaSucursal";
            this.Size = new System.Drawing.Size(281, 128);
            this.Click += new System.EventHandler(this.viewCortaSucursal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagen;
        private DevComponents.DotNetBar.LabelX lbSucursal;
        private DevComponents.DotNetBar.LabelX lbDireccion;
        private DevComponents.DotNetBar.LabelX lbTelefono;
        private DevComponents.DotNetBar.LabelX lbRepresentante;
    }
}
