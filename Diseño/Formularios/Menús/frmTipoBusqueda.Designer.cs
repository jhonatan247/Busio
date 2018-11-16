namespace Presentacion.Formularios
{
    partial class frmTipoBusqueda
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
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.bnAceptar = new DevComponents.DotNetBar.ButtonX();
            this.chFinal = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chInicio = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.chTodo = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.bnAceptar);
            this.panelEx1.Controls.Add(this.chFinal);
            this.panelEx1.Controls.Add(this.chInicio);
            this.panelEx1.Controls.Add(this.labelX1);
            this.panelEx1.Controls.Add(this.chTodo);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(422, 465);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // bnAceptar
            // 
            this.bnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnAceptar.Location = new System.Drawing.Point(309, 422);
            this.bnAceptar.Name = "bnAceptar";
            this.bnAceptar.Size = new System.Drawing.Size(101, 31);
            this.bnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnAceptar.Symbol = "59511";
            this.bnAceptar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnAceptar.TabIndex = 4;
            this.bnAceptar.Text = "Aceptar";
            this.bnAceptar.Click += new System.EventHandler(this.bnAceptar_Click);
            // 
            // chFinal
            // 
            this.chFinal.AutoCheck = false;
            // 
            // 
            // 
            this.chFinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chFinal.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chFinal.ForeColor = System.Drawing.Color.Black;
            this.chFinal.Location = new System.Drawing.Point(12, 287);
            this.chFinal.Name = "chFinal";
            this.chFinal.Size = new System.Drawing.Size(410, 23);
            this.chFinal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chFinal.TabIndex = 3;
            this.chFinal.Text = "Buscar coincidencias al final del texto";
            this.chFinal.Click += new System.EventHandler(this.checkBoxX1_Click);
            // 
            // chInicio
            // 
            this.chInicio.AutoCheck = false;
            // 
            // 
            // 
            this.chInicio.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chInicio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chInicio.ForeColor = System.Drawing.Color.Black;
            this.chInicio.Location = new System.Drawing.Point(12, 162);
            this.chInicio.Name = "chInicio";
            this.chInicio.Size = new System.Drawing.Size(410, 23);
            this.chInicio.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chInicio.TabIndex = 2;
            this.chInicio.Text = "Buscar coincidencias al inicio del texto";
            this.chInicio.Click += new System.EventHandler(this.checkBoxX1_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(422, 40);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "¿Cómo deseas que se realice la búsqueda?";
            // 
            // chTodo
            // 
            this.chTodo.AutoCheck = false;
            // 
            // 
            // 
            this.chTodo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chTodo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.chTodo.ForeColor = System.Drawing.Color.Black;
            this.chTodo.Location = new System.Drawing.Point(12, 54);
            this.chTodo.Name = "chTodo";
            this.chTodo.Size = new System.Drawing.Size(410, 23);
            this.chTodo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chTodo.TabIndex = 0;
            this.chTodo.Text = "Buscar coincidencias en todo el texto";
            this.chTodo.Click += new System.EventHandler(this.checkBoxX1_Click);
            // 
            // frmTipoBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(422, 465);
            this.Controls.Add(this.panelEx1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipoBusqueda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar búsqueda";
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chFinal;
        private DevComponents.DotNetBar.Controls.CheckBoxX chInicio;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chTodo;
        private DevComponents.DotNetBar.ButtonX bnAceptar;
    }
}