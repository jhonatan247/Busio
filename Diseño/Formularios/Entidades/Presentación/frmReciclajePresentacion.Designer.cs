namespace Presentacion.Formularios
{
    partial class frmReciclajePresentacion
    {

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.crtlBuscarMarca1 = new Presentacion.Usuario.crtlBuscarPresentacion();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.crtlBuscarMarca1);
            this.panelEx1.Controls.Add(this.labelX3);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(317, 452);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // crtlBuscarMarca1
            // 
            this.crtlBuscarMarca1.Accion = false;
            this.crtlBuscarMarca1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtlBuscarMarca1.Location = new System.Drawing.Point(0, 35);
            this.crtlBuscarMarca1.Name = "crtlBuscarMarca1";
            this.crtlBuscarMarca1.Size = new System.Drawing.Size(317, 417);
            this.crtlBuscarMarca1.TabIndex = 11;
            this.crtlBuscarMarca1.AccionSeleccionar += new Presentacion.Usuario.crtlBuscarPresentacion.AccionDelegate(this.crtlBuscarMarca1_AccionSeleccionar);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelX3.Location = new System.Drawing.Point(0, 0);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(317, 35);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Reciclaje - Presentaciones";
            // 
            // frmReciclajePresentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(317, 452);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(333, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(333, 200);
            this.Name = "frmReciclajePresentacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelera de reciclaje";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Usuario.crtlBuscarPresentacion crtlBuscarMarca1;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}