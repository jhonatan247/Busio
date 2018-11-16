namespace Presentacion.Usuario
{
    partial class crtlUnidadMedida
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
            this.txNombre = new Presentacion.Controles.TextBoxExValide();
            this.txPrefijo = new Presentacion.Controles.TextBoxExValide();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bnPapelera = new DevComponents.DotNetBar.ButtonX();
            this.bnBorrar = new DevComponents.DotNetBar.ButtonX();
            this.bnNuevo = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbMarca = new DevComponents.DotNetBar.LabelX();
            this.bnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.crtlBuscar = new Presentacion.Usuario.crtlBuscarUnidadMedida();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txNombre
            // 
            this.txNombre.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txNombre.Border.Class = "TextBoxBorder";
            this.txNombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNombre.CampoObligatorio = true;
            this.txNombre.DisabledBackColor = System.Drawing.Color.White;
            this.txNombre.ForeColor = System.Drawing.Color.Black;
            this.txNombre.Location = new System.Drawing.Point(418, 120);
            this.txNombre.MaxLength = 30;
            this.txNombre.MaxMinCompare = false;
            this.txNombre.MaxValue = 0D;
            this.txNombre.MinimLengtth = ((uint)(3u));
            this.txNombre.MinValue = 0D;
            this.txNombre.Name = "txNombre";
            this.txNombre.PermEspacios = true;
            this.txNombre.PreventEnterBeep = true;
            this.txNombre.Size = new System.Drawing.Size(286, 20);
            this.txNombre.TabIndex = 0;
            this.txNombre.TextBoxCompare = null;
            this.txNombre.TextCompare = "";
            this.txNombre.Validacion = ValidatingType.Ninguna;
            this.txNombre.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txNombre_UserGo);
            // 
            // txPrefijo
            // 
            this.txPrefijo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txPrefijo.Border.Class = "TextBoxBorder";
            this.txPrefijo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txPrefijo.CampoObligatorio = true;
            this.txPrefijo.DisabledBackColor = System.Drawing.Color.White;
            this.txPrefijo.ForeColor = System.Drawing.Color.Black;
            this.txPrefijo.Location = new System.Drawing.Point(418, 161);
            this.txPrefijo.MaxLength = 5;
            this.txPrefijo.MaxMinCompare = false;
            this.txPrefijo.MaxValue = 0D;
            this.txPrefijo.MinimLengtth = ((uint)(1u));
            this.txPrefijo.MinValue = 0D;
            this.txPrefijo.Name = "txPrefijo";
            this.txPrefijo.PermEspacios = false;
            this.txPrefijo.PreventEnterBeep = true;
            this.txPrefijo.Size = new System.Drawing.Size(286, 20);
            this.txPrefijo.TabIndex = 1;
            this.txPrefijo.TextBoxCompare = null;
            this.txPrefijo.TextCompare = "";
            this.txPrefijo.Validacion = ValidatingType.Ninguna;
            this.txPrefijo.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.bnGuardar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(367, 117);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(50, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Nombre:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(374, 158);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(36, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Prefijo:";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.bnPapelera);
            this.panelEx1.Controls.Add(this.bnBorrar);
            this.panelEx1.Controls.Add(this.bnNuevo);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(317, 35);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(409, 34);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // bnPapelera
            // 
            this.bnPapelera.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnPapelera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnPapelera.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnPapelera.Location = new System.Drawing.Point(299, 6);
            this.bnPapelera.Name = "bnPapelera";
            this.bnPapelera.Size = new System.Drawing.Size(100, 23);
            this.bnPapelera.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnPapelera.Symbol = "59506";
            this.bnPapelera.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnPapelera.TabIndex = 3;
            this.bnPapelera.Text = "Papelera";
            this.bnPapelera.Click += new System.EventHandler(this.bnPapelera_Click);
            // 
            // bnBorrar
            // 
            this.bnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnBorrar.Enabled = false;
            this.bnBorrar.Location = new System.Drawing.Point(122, 6);
            this.bnBorrar.Name = "bnBorrar";
            this.bnBorrar.Size = new System.Drawing.Size(76, 23);
            this.bnBorrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnBorrar.Symbol = "57676";
            this.bnBorrar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnBorrar.TabIndex = 2;
            this.bnBorrar.Text = "Borrar";
            this.bnBorrar.Click += new System.EventHandler(this.bnBorrar_Click);
            // 
            // bnNuevo
            // 
            this.bnNuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnNuevo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnNuevo.Location = new System.Drawing.Point(6, 6);
            this.bnNuevo.Name = "bnNuevo";
            this.bnNuevo.Size = new System.Drawing.Size(110, 23);
            this.bnNuevo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnNuevo.Symbol = "57669";
            this.bnNuevo.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnNuevo.TabIndex = 1;
            this.bnNuevo.Text = "Nueva";
            this.bnNuevo.Click += new System.EventHandler(this.bnNuevo_Click);
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
            this.labelX3.Size = new System.Drawing.Size(726, 35);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Unidades de medida";
            // 
            // lbMarca
            // 
            this.lbMarca.AutoSize = true;
            // 
            // 
            // 
            this.lbMarca.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMarca.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMarca.Location = new System.Drawing.Point(339, 78);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(212, 24);
            this.lbMarca.TabIndex = 10;
            this.lbMarca.Text = "NUEVA UNIDAD DE MEDIDA";
            // 
            // bnGuardar
            // 
            this.bnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnGuardar.Location = new System.Drawing.Point(575, 206);
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.Size = new System.Drawing.Size(129, 31);
            this.bnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnGuardar.Symbol = "57697";
            this.bnGuardar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnGuardar.TabIndex = 2;
            this.bnGuardar.Text = "Guardar";
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);
            // 
            // crtlBuscar
            // 
            this.crtlBuscar.Accion = true;
            this.crtlBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crtlBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.crtlBuscar.Location = new System.Drawing.Point(0, 35);
            this.crtlBuscar.Name = "crtlBuscar";
            this.crtlBuscar.Size = new System.Drawing.Size(317, 324);
            this.crtlBuscar.TabIndex = 14;
            this.crtlBuscar.AccionSeleccionar += new Presentacion.Usuario.crtlBuscarUnidadMedida.AccionDelegate(this.crtlBuscarMarca1_AccionSeleccionar);
            // 
            // crtlUnidadMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.bnGuardar);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txPrefijo);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.crtlBuscar);
            this.Controls.Add(this.labelX3);
            this.MinimumSize = new System.Drawing.Size(726, 359);
            this.Name = "crtlUnidadMedida";
            this.Size = new System.Drawing.Size(726, 359);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxExValide txNombre;
        private Controles.TextBoxExValide txPrefijo;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbMarca;
        private DevComponents.DotNetBar.ButtonX bnBorrar;
        private DevComponents.DotNetBar.ButtonX bnNuevo;
        private DevComponents.DotNetBar.ButtonX bnGuardar;
        private DevComponents.DotNetBar.ButtonX bnPapelera;
        private crtlBuscarUnidadMedida crtlBuscar;
    }
}
