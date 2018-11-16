namespace Presentacion.Formularios
{
    partial class frmDineroFinal
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
            this.bnCancelar = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDiferencia = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bnCalc = new DevComponents.DotNetBar.ButtonX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEsperado = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.lbMensaje = new DevComponents.DotNetBar.LabelX();
            this.calculator1 = new DevComponents.Editors.Calculator();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txDinero = new Presentacion.Controles.TextBoxExValide();
            this.panelEx1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnCancelar
            // 
            this.bnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bnCancelar.Location = new System.Drawing.Point(329, 8);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(115, 35);
            this.bnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnCancelar.Symbol = "57676";
            this.bnCancelar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnCancelar.TabIndex = 4;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.buttonX1);
            this.panelEx1.Controls.Add(this.bnCancelar);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx1.Location = new System.Drawing.Point(0, 241);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(450, 50);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 5;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.buttonX1.Location = new System.Drawing.Point(8, 8);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(123, 35);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.Symbol = "59536";
            this.buttonX1.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.buttonX1.TabIndex = 5;
            this.buttonX1.Text = "Cerrar Turno";
            this.buttonX1.Click += new System.EventHandler(this.bnCerrarTurno_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.panel3);
            this.panelEx2.Controls.Add(this.panel2);
            this.panelEx2.Controls.Add(this.panel1);
            this.panelEx2.Controls.Add(this.lbMensaje);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(0, 89);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(450, 152);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbDiferencia);
            this.panel3.Controls.Add(this.labelX6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 40);
            this.panel3.TabIndex = 4;
            // 
            // lbDiferencia
            // 
            this.lbDiferencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbDiferencia.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbDiferencia.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbDiferencia.Location = new System.Drawing.Point(182, 9);
            this.lbDiferencia.Name = "lbDiferencia";
            this.lbDiferencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbDiferencia.Size = new System.Drawing.Size(258, 23);
            this.lbDiferencia.TabIndex = 3;
            this.lbDiferencia.Text = "$0,00";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(115, 9);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(60, 23);
            this.labelX6.TabIndex = 2;
            this.labelX6.Text = "Diferencia:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bnCalc);
            this.panel2.Controls.Add(this.labelX9);
            this.panel2.Controls.Add(this.labelX5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 40);
            this.panel2.TabIndex = 3;
            // 
            // bnCalc
            // 
            this.bnCalc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCalc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnCalc.Location = new System.Drawing.Point(414, 4);
            this.bnCalc.Name = "bnCalc";
            this.bnCalc.Size = new System.Drawing.Size(33, 33);
            this.bnCalc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnCalc.Symbol = "58831";
            this.bnCalc.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnCalc.TabIndex = 6;
            this.bnCalc.Click += new System.EventHandler(this.bnCalc_Click);
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.labelX9.Location = new System.Drawing.Point(195, 8);
            this.labelX9.Name = "labelX9";
            this.labelX9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX9.Size = new System.Drawing.Size(27, 23);
            this.labelX9.TabIndex = 3;
            this.labelX9.Text = "$";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(25, 9);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(151, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "¿Cuánto efectivo hay en caja?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbEsperado);
            this.panel1.Controls.Add(this.labelX4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 40);
            this.panel1.TabIndex = 2;
            // 
            // lbEsperado
            // 
            this.lbEsperado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.lbEsperado.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbEsperado.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEsperado.Location = new System.Drawing.Point(182, 9);
            this.lbEsperado.Name = "lbEsperado";
            this.lbEsperado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbEsperado.Size = new System.Drawing.Size(258, 23);
            this.lbEsperado.TabIndex = 1;
            this.lbEsperado.Text = "$0,00";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(41, 9);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(135, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Efectivo esperado en caja:";
            // 
            // lbMensaje
            // 
            // 
            // 
            // 
            this.lbMensaje.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensaje.Location = new System.Drawing.Point(0, 120);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(450, 32);
            this.lbMensaje.Symbol = "58826";
            this.lbMensaje.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.lbMensaje.TabIndex = 1;
            this.lbMensaje.Text = "¡Excelente! todo en orden";
            // 
            // calculator1
            // 
            this.calculator1.AutoSize = true;
            this.calculator1.Location = new System.Drawing.Point(225, 133);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(190, 211);
            this.calculator1.Text = "calculator1";
            this.calculator1.Visible = false;
            this.calculator1.ValueChanged += new System.EventHandler<DevComponents.Editors.ValueChangedEventArgs>(this.calculator1_ValueChanged);
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx3.Controls.Add(this.labelX2);
            this.panelEx3.Controls.Add(this.labelX1);
            this.panelEx3.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx3.Location = new System.Drawing.Point(0, 0);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(450, 89);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 14;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX2.Location = new System.Drawing.Point(0, 42);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(450, 47);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = " Cuenta el dinero en caja e ingresalo para proceder con el cierre de turno.";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(450, 42);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Cierre de turno";
            // 
            // txDinero
            // 
            this.txDinero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDinero.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txDinero.Border.Class = "TextBoxBorder";
            this.txDinero.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txDinero.CampoObligatorio = false;
            this.txDinero.DisabledBackColor = System.Drawing.Color.Black;
            this.txDinero.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txDinero.ForeColor = System.Drawing.Color.White;
            this.txDinero.Location = new System.Drawing.Point(225, 133);
            this.txDinero.MaxMinCompare = false;
            this.txDinero.MaxValue = 0D;
            this.txDinero.MinimLengtth = ((uint)(1u));
            this.txDinero.MinValue = 0D;
            this.txDinero.Name = "txDinero";
            this.txDinero.PermEspacios = false;
            this.txDinero.PreventEnterBeep = true;
            this.txDinero.Size = new System.Drawing.Size(190, 32);
            this.txDinero.TabIndex = 19;
            this.txDinero.Text = "0,00";
            this.txDinero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txDinero.TextBoxCompare = null;
            this.txDinero.TextCompare = "";
            this.txDinero.Validacion = Presentacion.ValidatingType.Double;
            this.txDinero.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.bnCerrarTurno_Click);
            this.txDinero.Click += new System.EventHandler(this.txDinero_Click);
            this.txDinero.TextChanged += new System.EventHandler(this.txDinero_TextChanged);
            // 
            // frmDineroFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(450, 291);
            this.Controls.Add(this.txDinero);
            this.Controls.Add(this.calculator1);
            this.Controls.Add(this.panelEx2);
            this.Controls.Add(this.panelEx1);
            this.Controls.Add(this.panelEx3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDineroFinal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cerrar turno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDineroInicial_FormClosing);
            this.panelEx1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX bnCancelar;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.LabelX labelX5;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lbMensaje;
        private DevComponents.DotNetBar.LabelX lbDiferencia;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX lbEsperado;
        private DevComponents.DotNetBar.ButtonX bnCalc;
        private DevComponents.Editors.Calculator calculator1;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Controles.TextBoxExValide txDinero;
    }
}