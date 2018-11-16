namespace Presentacion.Controles
{
    partial class TextBoxValide
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
            this.superTooltip1 = new DevComponents.DotNetBar.SuperTooltip();
            this.pnlUnderline1 = new System.Windows.Forms.Panel();
            this.pnlUnderline2 = new System.Windows.Forms.Panel();
            this.pnlUnderline3 = new System.Windows.Forms.Panel();
            this.lbOver = new Presentacion.Controles.LabelPro();
            this.SuspendLayout();
            // 
            // superTooltip1
            // 
            this.superTooltip1.DefaultTooltipSettings = new DevComponents.DotNetBar.SuperTooltipInfo("", "", "", null, null, DevComponents.DotNetBar.eTooltipColor.Gray);
            // 
            // pnlUnderline1
            // 
            this.pnlUnderline1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnderline1.Location = new System.Drawing.Point(0, 0);
            this.pnlUnderline1.Name = "pnlUnderline1";
            this.pnlUnderline1.Size = new System.Drawing.Size(370, 5);
            this.pnlUnderline1.TabIndex = 2;
            this.pnlUnderline1.Click += new System.EventHandler(this.nClick);
            this.pnlUnderline1.MouseLeave += new System.EventHandler(this.pnlUnderline3_MouseLeave);
            this.pnlUnderline1.MouseHover += new System.EventHandler(this.pnlUnderline3_MouseHover);
            this.pnlUnderline1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbOver_MouseMove);
            // 
            // pnlUnderline2
            // 
            this.pnlUnderline2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlUnderline2.Location = new System.Drawing.Point(0, 0);
            this.pnlUnderline2.Name = "pnlUnderline2";
            this.pnlUnderline2.Size = new System.Drawing.Size(5, 40);
            this.pnlUnderline2.TabIndex = 3;
            this.pnlUnderline2.Click += new System.EventHandler(this.nClick);
            this.pnlUnderline2.MouseLeave += new System.EventHandler(this.pnlUnderline3_MouseLeave);
            this.pnlUnderline2.MouseHover += new System.EventHandler(this.pnlUnderline3_MouseHover);
            this.pnlUnderline2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbOver_MouseMove);
            // 
            // pnlUnderline3
            // 
            this.pnlUnderline3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUnderline3.Location = new System.Drawing.Point(365, 0);
            this.pnlUnderline3.Name = "pnlUnderline3";
            this.pnlUnderline3.Size = new System.Drawing.Size(5, 40);
            this.pnlUnderline3.TabIndex = 4;
            this.pnlUnderline3.Click += new System.EventHandler(this.nClick);
            this.pnlUnderline3.MouseLeave += new System.EventHandler(this.pnlUnderline3_MouseLeave);
            this.pnlUnderline3.MouseHover += new System.EventHandler(this.pnlUnderline3_MouseHover);
            this.pnlUnderline3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbOver_MouseMove);
            // 
            // lbOver
            // 
            this.lbOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOver.CheckReference = null;
            this.lbOver.CustomLabelType = Presentacion.Controles.LabelType.Hide;
            this.lbOver.EnabledTransitions = true;
            this.lbOver.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbOver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbOver.Link = "";
            this.lbOver.Location = new System.Drawing.Point(9, 15);
            this.lbOver.Name = "lbOver";
            this.lbOver.Size = new System.Drawing.Size(352, 16);
            this.lbOver.SizeTag = new System.Drawing.Size(0, 0);
            this.lbOver.Style = Presentacion.Controles.LabelStyle.Custom;
            this.lbOver.TabIndex = 1;
            this.lbOver.Text = "OverText*";
            this.lbOver.Click += new System.EventHandler(this.nClick);
            this.lbOver.MouseHover += new System.EventHandler(this.pnlUnderline3_MouseHover);
            this.lbOver.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbOver_MouseMove);
            // 
            // TextBoxValide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderColorFocused = System.Drawing.SystemColors.HotTrack;
            this.BorderColorIdle = System.Drawing.Color.Gray;
            this.BorderColorMouseHover = System.Drawing.SystemColors.Highlight;
            this.Controls.Add(this.pnlUnderline3);
            this.Controls.Add(this.pnlUnderline2);
            this.Controls.Add(this.lbOver);
            this.Controls.Add(this.pnlUnderline1);
            this.Name = "TextBoxValide";
            this.OnValueChanged += new System.EventHandler(this.nOnValueChanged);
            this.ForeColorChanged += new System.EventHandler(this.TextBoxValide_ForeColorChanged);
            this.Click += new System.EventHandler(this.nClick);
            this.Enter += new System.EventHandler(this.TextBoxValide_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxValide_KeyDown);
            this.Leave += new System.EventHandler(this.TextBoxXD_Leave);
            this.MouseLeave += new System.EventHandler(this.pnlUnderline3_MouseLeave);
            this.MouseHover += new System.EventHandler(this.pnlUnderline3_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbOver_MouseMove);
            this.Controls.SetChildIndex(this.pnlUnderline1, 0);
            this.Controls.SetChildIndex(this.lbOver, 0);
            this.Controls.SetChildIndex(this.pnlUnderline2, 0);
            this.Controls.SetChildIndex(this.pnlUnderline3, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LabelPro lbOver;
        private DevComponents.DotNetBar.SuperTooltip superTooltip1;
        private System.Windows.Forms.Panel pnlUnderline1;
        private System.Windows.Forms.Panel pnlUnderline2;
        private System.Windows.Forms.Panel pnlUnderline3;
    }
}
