namespace Presentacion.Formularios
{
    partial class frmBuscarProducto
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
            this.crtlBuscarProducto1 = new Presentacion.Usuario.crtlBuscarProducto();
            this.SuspendLayout();
            // 
            // crtlBuscarProducto1
            // 
            this.crtlBuscarProducto1.Accion = true;
            this.crtlBuscarProducto1.AutoSize = true;
            this.crtlBuscarProducto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.crtlBuscarProducto1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtlBuscarProducto1.ForeColor = System.Drawing.Color.White;
            this.crtlBuscarProducto1.Location = new System.Drawing.Point(0, 0);
            this.crtlBuscarProducto1.MinimumSize = new System.Drawing.Size(753, 483);
            this.crtlBuscarProducto1.MultiSelect = false;
            this.crtlBuscarProducto1.Name = "crtlBuscarProducto1";
            this.crtlBuscarProducto1.Size = new System.Drawing.Size(754, 491);
            this.crtlBuscarProducto1.TabIndex = 0;
            this.crtlBuscarProducto1.Vender = false;
            this.crtlBuscarProducto1.AccionSeleccionar += new Presentacion.Usuario.crtlBuscarProducto.AccionDelegate(this.crtlBuscarProducto1_AccionSeleccionar);
            this.crtlBuscarProducto1.AccionSeleccionarMultiple += new Presentacion.Usuario.crtlBuscarProducto.AccionMultipleDelegate(this.crtlBuscarProducto1_AccionSeleccionarMultiple);
            // 
            // frmBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 491);
            this.Controls.Add(this.crtlBuscarProducto1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(770, 530);
            this.Name = "frmBuscarProducto";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecconar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Usuario.crtlBuscarProducto crtlBuscarProducto1;
    }
}