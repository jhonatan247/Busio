namespace Presentacion.Controles
{
    partial class DropDownPro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DropDownPro));
            this.SuspendLayout();
            // 
            // Style
            // 
            this.Style.Activecolor = System.Drawing.Color.Gray;
            this.Style.BackColor = System.Drawing.Color.Gray;
            this.Style.ButtonText = "    OverText*";
            this.Style.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Style.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("Style.Iconimage_right")));
            this.Style.Normalcolor = System.Drawing.Color.Gray;
            this.Style.OnHovercolor = System.Drawing.SystemColors.HotTrack;
            this.Style.Text = "    OverText*";
            this.Style.Click += new System.EventHandler(this.Style_Click);
            this.Style.Leave += new System.EventHandler(this.nOnValueChanged);
            // 
            // DropDownPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Items = new string[] {
        "OverText*"};
            this.Name = "DropDownPro";
            this.NomalColor = System.Drawing.Color.Gray;
            this.onHoverColor = System.Drawing.SystemColors.HotTrack;
            this.selectedIndex = 0;
            this.ResumeLayout(false);

        }

        #endregion
    }
}
