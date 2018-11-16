namespace Presentacion.Usuario
{
    partial class crtlEmpresaDistribuidora
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
            this.txNumDocumento = new Presentacion.Controles.TextBoxExValide();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bnPapelera = new DevComponents.DotNetBar.ButtonX();
            this.bnBorrar = new DevComponents.DotNetBar.ButtonX();
            this.bnNuevo = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbMarca = new DevComponents.DotNetBar.LabelX();
            this.bnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.crtlBuscar = new Presentacion.Usuario.crtlBuscarEmpresaDistribuidora();
            this.comboEXValide1 = new Presentacion.Controles.ComboEXValide();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.bnEditTipoDocumento = new DevComponents.DotNetBar.ButtonX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
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
            this.txNombre.Location = new System.Drawing.Point(352, 131);
            this.txNombre.MaxLength = 30;
            this.txNombre.MaxMinCompare = false;
            this.txNombre.MaxValue = 0D;
            this.txNombre.MinimLengtth = ((uint)(3u));
            this.txNombre.MinValue = 0D;
            this.txNombre.Name = "txNombre";
            this.txNombre.PermEspacios = true;
            this.txNombre.PreventEnterBeep = true;
            this.txNombre.Size = new System.Drawing.Size(435, 20);
            this.txNombre.TabIndex = 0;
            this.txNombre.TextBoxCompare = null;
            this.txNombre.TextCompare = "";
            this.txNombre.Validacion = ValidatingType.Ninguna;
            this.txNombre.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txNombre_UserGo);
            // 
            // txNumDocumento
            // 
            this.txNumDocumento.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txNumDocumento.Border.Class = "TextBoxBorder";
            this.txNumDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNumDocumento.CampoObligatorio = true;
            this.txNumDocumento.DisabledBackColor = System.Drawing.Color.White;
            this.txNumDocumento.ForeColor = System.Drawing.Color.Black;
            this.txNumDocumento.Location = new System.Drawing.Point(352, 239);
            this.txNumDocumento.MaxLength = 20;
            this.txNumDocumento.MaxMinCompare = false;
            this.txNumDocumento.MaxValue = 0D;
            this.txNumDocumento.MinimLengtth = ((uint)(5u));
            this.txNumDocumento.MinValue = 0D;
            this.txNumDocumento.Name = "txNumDocumento";
            this.txNumDocumento.PermEspacios = false;
            this.txNumDocumento.PreventEnterBeep = true;
            this.txNumDocumento.Size = new System.Drawing.Size(342, 20);
            this.txNumDocumento.TabIndex = 1;
            this.txNumDocumento.TextBoxCompare = null;
            this.txNumDocumento.TextCompare = "";
            this.txNumDocumento.Validacion = ValidatingType.Ninguna;
            this.txNumDocumento.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.bnGuardar_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(352, 107);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(121, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "Nombre:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(352, 215);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(144, 23);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "Num de documento:";
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
            this.panelEx1.Size = new System.Drawing.Size(490, 34);
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
            this.bnPapelera.Location = new System.Drawing.Point(380, 6);
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
            this.labelX3.Size = new System.Drawing.Size(807, 35);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "Empresas distribuidoras";
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
            this.lbMarca.Size = new System.Drawing.Size(252, 24);
            this.lbMarca.TabIndex = 10;
            this.lbMarca.Text = "NUEVA EMPRESA DISTRIBUIDORA";
            // 
            // bnGuardar
            // 
            this.bnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnGuardar.Location = new System.Drawing.Point(658, 296);
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
            this.crtlBuscar.MaximumSize = new System.Drawing.Size(317, 100000);
            this.crtlBuscar.MinimumSize = new System.Drawing.Size(317, 324);
            this.crtlBuscar.Name = "crtlBuscar";
            this.crtlBuscar.Size = new System.Drawing.Size(317, 324);
            this.crtlBuscar.TabIndex = 14;
            this.crtlBuscar.AccionSeleccionar += new Presentacion.Usuario.crtlBuscarEmpresaDistribuidora.AccionDelegate(this.crtlBuscarMarca1_AccionSeleccionar);
            // 
            // comboEXValide1
            // 
            this.comboEXValide1.DisplayMember = "Text";
            this.comboEXValide1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboEXValide1.ForeColor = System.Drawing.Color.Black;
            this.comboEXValide1.FormattingEnabled = true;
            this.comboEXValide1.ItemHeight = 14;
            this.comboEXValide1.Location = new System.Drawing.Point(352, 186);
            this.comboEXValide1.Name = "comboEXValide1";
            this.comboEXValide1.Size = new System.Drawing.Size(318, 20);
            this.comboEXValide1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.comboEXValide1.TabIndex = 15;
            this.comboEXValide1.UserGo += new Presentacion.Controles.ComboEXValide.UserGoDelegate(this.comboEXValide1_UserGo);
            // 
            // pbImagen
            // 
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Image = global::Presentacion.Properties.Resources.EmpresaD;
            this.pbImagen.Location = new System.Drawing.Point(714, 186);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(73, 73);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 16;
            this.pbImagen.TabStop = false;
            this.pbImagen.Click += new System.EventHandler(this.pbImagen_Click);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(352, 162);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(144, 23);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "Tipo de documento:";
            // 
            // bnEditTipoDocumento
            // 
            this.bnEditTipoDocumento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnEditTipoDocumento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnEditTipoDocumento.Location = new System.Drawing.Point(671, 186);
            this.bnEditTipoDocumento.Name = "bnEditTipoDocumento";
            this.bnEditTipoDocumento.Size = new System.Drawing.Size(23, 23);
            this.bnEditTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnEditTipoDocumento.Symbol = "57680";
            this.bnEditTipoDocumento.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnEditTipoDocumento.TabIndex = 87;
            this.bnEditTipoDocumento.TabStop = false;
            this.bnEditTipoDocumento.Click += new System.EventHandler(this.bnEditTipoDocumento_Click);
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(714, 162);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(73, 23);
            this.labelX5.TabIndex = 91;
            this.labelX5.Text = "Logo:";
            // 
            // crtlEmpresaDistribuidora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.bnEditTipoDocumento);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.comboEXValide1);
            this.Controls.Add(this.bnGuardar);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txNumDocumento);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.crtlBuscar);
            this.Controls.Add(this.labelX3);
            this.MinimumSize = new System.Drawing.Size(807, 359);
            this.Name = "crtlEmpresaDistribuidora";
            this.Size = new System.Drawing.Size(807, 359);
            this.panelEx1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controles.TextBoxExValide txNombre;
        private Controles.TextBoxExValide txNumDocumento;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbMarca;
        private DevComponents.DotNetBar.ButtonX bnBorrar;
        private DevComponents.DotNetBar.ButtonX bnNuevo;
        private DevComponents.DotNetBar.ButtonX bnGuardar;
        private DevComponents.DotNetBar.ButtonX bnPapelera;
        private crtlBuscarEmpresaDistribuidora crtlBuscar;
        private Controles.ComboEXValide comboEXValide1;
        private System.Windows.Forms.PictureBox pbImagen;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX bnEditTipoDocumento;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}
