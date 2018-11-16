namespace Presentacion.Controles
{
    partial class LabelPro
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabelPro));
            this.contextMenuPro1 = new Presentacion.Controles.ContextMenuPro();
            this.tsmCopy = new Presentacion.Controles.ToolStripMenuItemPro();
            this.tsmGo = new Presentacion.Controles.ToolStripMenuItemPro();
            this.tsmCheck = new Presentacion.Controles.ToolStripMenuItemPro();
            this.tsmCopyLink = new Presentacion.Controles.ToolStripMenuItemPro();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contextMenuPro1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuPro1
            // 
            this.Animator.SetDecoration(this.contextMenuPro1, BunifuAnimatorNS.DecorationType.None);
            this.contextMenuPro1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCopy,
            this.tsmGo,
            this.tsmCheck,
            this.tsmCopyLink});
            this.contextMenuPro1.Name = "contextMenuPro1";
            this.contextMenuPro1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuPro1.Size = new System.Drawing.Size(125, 92);
            // 
            // tsmCopy
            // 
            this.tsmCopy.AutoToolTip = true;
            this.tsmCopy.Name = "tsmCopy";
            this.tsmCopy.Size = new System.Drawing.Size(124, 22);
            this.tsmCopy.Text = "Copiar";
            // 
            // tsmGo
            // 
            this.tsmGo.AutoToolTip = true;
            this.tsmGo.Name = "tsmGo";
            this.tsmGo.Size = new System.Drawing.Size(124, 22);
            this.tsmGo.Text = "Ir";
            // 
            // tsmCheck
            // 
            this.tsmCheck.AutoToolTip = true;
            this.tsmCheck.Name = "tsmCheck";
            this.tsmCheck.Size = new System.Drawing.Size(124, 22);
            this.tsmCheck.Text = "Checkear";
            // 
            // tsmCopyLink
            // 
            this.tsmCopyLink.AutoToolTip = true;
            this.tsmCopyLink.Name = "tsmCopyLink";
            this.tsmCopyLink.Size = new System.Drawing.Size(124, 22);
            this.tsmCopyLink.Text = "Copiar link";
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.Animator.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.Animator.DefaultAnimation = animation6;
            this.Animator.TimeStep = 0.01F;
            // 
            // LabelPro
            // 
            this.ContextMenuStrip = this.contextMenuPro1;
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.Click += new System.EventHandler(this.LinkLabelDesign_Click);
            this.MouseLeave += new System.EventHandler(this.LinkLabelDesign_MouseLeave);
            this.MouseHover += new System.EventHandler(this.LinkLabelDesign_MouseHover);
            this.contextMenuPro1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuPro contextMenuPro1;
        private ToolStripMenuItemPro tsmCopy;
        private ToolStripMenuItemPro tsmGo;
        private ToolStripMenuItemPro tsmCheck;
        private ToolStripMenuItemPro tsmCopyLink;
        public BunifuAnimatorNS.BunifuTransition Animator;
    }
}
