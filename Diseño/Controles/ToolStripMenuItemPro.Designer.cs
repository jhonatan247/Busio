namespace Presentacion.Controles
{
    partial class ToolStripMenuItemPro
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
            // 
            // ToolStripMenuItemPro
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.ShortcutKeyDisplayString = "";
            this.MouseEnter += new System.EventHandler(this.ToolStripMenuItemPro_MouseHover);
            this.MouseLeave += new System.EventHandler(this.ToolStripMenuItemPro_MouseLeave);
            this.MouseHover += new System.EventHandler(this.ToolStripMenuItemPro_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ToolStripMenuItemPro_MouseMove);

        }

        #endregion
    }
}
