namespace Presentacion.Formularios
{
    partial class frmDineroInicial
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
            this.components = new System.ComponentModel.Container();
            this.calculator1 = new DevComponents.Editors.Calculator();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.bnCalc = new DevComponents.DotNetBar.ButtonX();
            this.bnFinalizar = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txDinero = new Presentacion.Controles.TextBoxExValide();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculator1
            // 
            this.calculator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.calculator1.AutoSize = true;
            this.calculator1.Location = new System.Drawing.Point(36, 85);
            this.calculator1.Name = "calculator1";
            this.calculator1.Size = new System.Drawing.Size(190, 211);
            this.calculator1.Text = "calculator1";
            this.calculator1.Visible = false;
            this.calculator1.ValueChanged += new System.EventHandler<DevComponents.Editors.ValueChangedEventArgs>(this.calculator1_ValueChanged);
            this.calculator1.CalculatorDisplayChanged += new System.EventHandler(this.calculator1_CalculatorDisplayChanged);
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.White;
            this.labelX1.Location = new System.Drawing.Point(25, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(212, 62);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Por favor,  ingresa la cantidad \r\nde dinero que hay en la caja. ";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labelX2.ForeColor = System.Drawing.Color.White;
            this.labelX2.Location = new System.Drawing.Point(15, 82);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(18, 35);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "$";
            // 
            // bnCalc
            // 
            this.bnCalc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnCalc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnCalc.Location = new System.Drawing.Point(224, 85);
            this.bnCalc.Name = "bnCalc";
            this.bnCalc.Size = new System.Drawing.Size(29, 31);
            this.bnCalc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnCalc.Symbol = "58831";
            this.bnCalc.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnCalc.TabIndex = 5;
            this.bnCalc.Click += new System.EventHandler(this.bnCalc_Click);
            // 
            // bnFinalizar
            // 
            this.bnFinalizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bnFinalizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnFinalizar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bnFinalizar.Location = new System.Drawing.Point(19, 138);
            this.bnFinalizar.Name = "bnFinalizar";
            this.bnFinalizar.Size = new System.Drawing.Size(225, 36);
            this.bnFinalizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnFinalizar.Symbol = "58826";
            this.bnFinalizar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnFinalizar.TabIndex = 7;
            this.bnFinalizar.Text = "Registrar dinero inicial en caja";
            this.bnFinalizar.Click += new System.EventHandler(this.bnFinalizar_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txDinero);
            this.panelEx1.Controls.Add(this.bnFinalizar);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.bnCalc);
            this.panelEx1.Controls.Add(this.labelX2);
            this.panelEx1.Controls.Add(this.calculator1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(263, 186);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 9;
            // 
            // txDinero
            // 
            this.txDinero.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.txDinero.Location = new System.Drawing.Point(36, 85);
            this.txDinero.MaxMinCompare = false;
            this.txDinero.MaxValue = 0D;
            this.txDinero.MinimLengtth = ((uint)(1u));
            this.txDinero.MinValue = 0D;
            this.txDinero.Name = "txDinero";
            this.txDinero.PermEspacios = false;
            this.txDinero.PreventEnterBeep = true;
            this.txDinero.Size = new System.Drawing.Size(190, 32);
            this.txDinero.TabIndex = 9;
            this.txDinero.Text = "0,00";
            this.txDinero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txDinero.TextBoxCompare = null;
            this.txDinero.TextCompare = "";
            this.txDinero.Validacion = ValidatingType.uDecimal;
            this.txDinero.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.bnFinalizar_Click);
            this.txDinero.Click += new System.EventHandler(this.txDinero_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.VisualStudio2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48))))), System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))));
            // 
            // frmDineroInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(263, 186);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDineroInicial";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dinero en caja";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDineroInicial_FormClosing);
            this.panelEx1.ResumeLayout(false);
            this.panelEx1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.Editors.Calculator calculator1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonX bnCalc;
        private DevComponents.DotNetBar.ButtonX bnFinalizar;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private Controles.TextBoxExValide txDinero;
    }
}