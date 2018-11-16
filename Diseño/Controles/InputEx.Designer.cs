namespace Presentacion.Controles
{
    partial class InputEx
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
            this.txValue = new Presentacion.Controles.TextBoxExValide();
            this.bnAcept = new DevComponents.DotNetBar.ButtonX();
            this.bnCanclel = new DevComponents.DotNetBar.ButtonX();
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bnMore = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txValue
            // 
            this.txValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txValue.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.txValue.Border.Class = "TextBoxBorder";
            this.txValue.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txValue.CampoObligatorio = true;
            this.txValue.DisabledBackColor = System.Drawing.Color.White;
            this.txValue.ForeColor = System.Drawing.Color.White;
            this.txValue.Location = new System.Drawing.Point(12, 10);
            this.txValue.MaxMinCompare = false;
            this.txValue.MaxValue = 0D;
            this.txValue.MinimLengtth = ((uint)(0u));
            this.txValue.MinValue = 0D;
            this.txValue.Name = "txValue";
            this.txValue.PermEspacios = true;
            this.txValue.PreventEnterBeep = true;
            this.txValue.Size = new System.Drawing.Size(283, 25);
            this.txValue.TabIndex = 0;
            this.txValue.TextBoxCompare = null;
            this.txValue.TextCompare = "";
            this.txValue.Validacion = ValidatingType.Ninguna;
            this.txValue.WatermarkText = "Value";
            this.txValue.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.bnAcept_Click);
            // 
            // bnAcept
            // 
            this.bnAcept.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnAcept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnAcept.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnAcept.Location = new System.Drawing.Point(206, 48);
            this.bnAcept.Name = "bnAcept";
            this.bnAcept.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.bnAcept.Size = new System.Drawing.Size(89, 30);
            this.bnAcept.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnAcept.Symbol = "58826";
            this.bnAcept.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnAcept.TabIndex = 2;
            this.bnAcept.Text = "Aceptar";
            this.bnAcept.Click += new System.EventHandler(this.bnAcept_Click);
            // 
            // bnCanclel
            // 
            this.bnCanclel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnCanclel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnCanclel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnCanclel.Location = new System.Drawing.Point(12, 48);
            this.bnCanclel.Name = "bnCanclel";
            this.bnCanclel.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.bnCanclel.Size = new System.Drawing.Size(89, 30);
            this.bnCanclel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnCanclel.Symbol = "57676";
            this.bnCanclel.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnCanclel.TabIndex = 3;
            this.bnCanclel.Text = "Cancelar";
            this.bnCanclel.Click += new System.EventHandler(this.bnCanclel_Click);
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.bnMore);
            this.panelEx1.Controls.Add(this.bnAcept);
            this.panelEx1.Controls.Add(this.txValue);
            this.panelEx1.Controls.Add(this.bnCanclel);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(307, 90);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
            // 
            // bnMore
            // 
            this.bnMore.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnMore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnMore.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnMore.Location = new System.Drawing.Point(136, 48);
            this.bnMore.Name = "bnMore";
            this.bnMore.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(6);
            this.bnMore.Size = new System.Drawing.Size(34, 30);
            this.bnMore.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnMore.Symbol = "58831";
            this.bnMore.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnMore.TabIndex = 6;
            // 
            // InputEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(307, 90);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputEx";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Value";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxExValide txValue;
        private DevComponents.DotNetBar.ButtonX bnAcept;
        private DevComponents.DotNetBar.ButtonX bnCanclel;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX bnMore;
    }
}