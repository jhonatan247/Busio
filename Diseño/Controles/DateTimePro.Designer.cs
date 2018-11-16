namespace Presentacion.Controles
{
    partial class DateTimePro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateTimePro));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbOver = new Presentacion.Controles.LabelPro();
            this.SuspendLayout();
            // 
            // Style
            // 
            this.Style.Activecolor = System.Drawing.SystemColors.Highlight;
            this.Style.BackColor = System.Drawing.Color.DarkGray;
            this.Style.ButtonText = "martes, 9 de mayo de 2017";
            this.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Style.ForeColor = System.Drawing.Color.White;
            this.Style.Iconimage = ((System.Drawing.Image)(resources.GetObject("Style.Iconimage")));
            this.Style.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("Style.Iconimage_right")));
            this.Style.Normalcolor = System.Drawing.Color.DarkGray;
            this.Style.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.Style.Text = "martes, 9 de mayo de 2017";
            this.Style.Click += new System.EventHandler(this.lbOver_Click);
            this.Style.Leave += new System.EventHandler(this.nOnValueChanged);
            // 
            // lbOver
            // 
            this.lbOver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbOver.BackColor = System.Drawing.Color.Transparent;
            this.lbOver.CheckReference = null;
            this.lbOver.CustomLabelType = Presentacion.Controles.LabelType.Hide;
            this.lbOver.EnabledTransitions = false;
            this.lbOver.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOver.ForColor = System.Drawing.Color.White;
            this.lbOver.ForeColor = System.Drawing.Color.White;
            this.lbOver.Link = "";
            this.lbOver.Location = new System.Drawing.Point(36, 0);
            this.lbOver.Name = "lbOver";
            this.lbOver.Size = new System.Drawing.Size(232, 36);
            this.lbOver.SizeTag = new System.Drawing.Size(0, 0);
            this.lbOver.Style = Presentacion.Controles.LabelStyle.Custom;
            this.lbOver.TabIndex = 4;
            this.lbOver.Text = "OverText*";
            this.lbOver.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbOver.Click += new System.EventHandler(this.lbOver_Click_1);
            // 
            // DateTimePro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.lbOver);
            this.Name = "DateTimePro";
            this.Controls.SetChildIndex(this.Style, 0);
            this.Controls.SetChildIndex(this.lbOver, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private LabelPro lbOver;
    }
}
