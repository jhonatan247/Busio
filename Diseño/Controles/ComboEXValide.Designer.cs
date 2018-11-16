namespace Presentacion.Controles
{
    partial class ComboEXValide
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
            this.SuspendLayout();
            // 
            // ComboEXValide
            // 
            this.SelectedIndexChanged += new System.EventHandler(this.ComboEXValide_SelectedIndexChanged);
            this.TextChanged += new System.EventHandler(this.ComboEXValide_TextChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboEXValide_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboEXValide_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
