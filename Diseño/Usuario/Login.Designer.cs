namespace Presentacion.Usuario
{
    partial class Login
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
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbLogin = new Presentacion.Controles.LabelPro();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.pbLock = new System.Windows.Forms.PictureBox();
            this.bnContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txUsuario = new Presentacion.Controles.TextBoxValide();
            this.lbCreateOne = new Presentacion.Controles.LabelPro();
            this.lbMoreOpt = new Presentacion.Controles.LabelPro();
            this.chRecordar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ctxMoreOptions = new Presentacion.Controles.ContextMenuPro();
            this.tsmForgetUsername = new Presentacion.Controles.ToolStripMenuItemPro();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemPro1 = new Presentacion.Controles.ToolStripMenuItemPro();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.lbNombre = new Presentacion.Controles.LabelPro();
            this.bnSignIn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txContraseña = new Presentacion.Controles.TextBoxValide();
            this.lbForgot = new Presentacion.Controles.LabelPro();
            this.bnBack = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbRecordar = new Presentacion.Controles.LabelPro();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.Animator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).BeginInit();
            this.ctxMoreOptions.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.CheckReference = null;
            this.lbLogin.CustomLabelType = Presentacion.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbLogin, BunifuAnimatorNS.DecorationType.None);
            this.lbLogin.EnabledTransitions = true;
            this.lbLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbLogin.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbLogin.Link = "";
            this.lbLogin.Location = new System.Drawing.Point(6, 1);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(132, 28);
            this.lbLogin.SizeTag = new System.Drawing.Size(0, 0);
            this.lbLogin.Style = Presentacion.Controles.LabelStyle.Custom;
            this.lbLogin.TabIndex = 5;
            this.lbLogin.Text = "Caja Principal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlUser);
            this.panel1.Controls.Add(this.pnlPassword);
            this.Animator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 331);
            this.panel1.TabIndex = 12;
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUser.Controls.Add(this.pbLock);
            this.pnlUser.Controls.Add(this.bnContinue);
            this.pnlUser.Controls.Add(this.txUsuario);
            this.pnlUser.Controls.Add(this.lbLogin);
            this.pnlUser.Controls.Add(this.lbCreateOne);
            this.pnlUser.Controls.Add(this.lbMoreOpt);
            this.Animator.SetDecoration(this.pnlUser, BunifuAnimatorNS.DecorationType.None);
            this.pnlUser.Location = new System.Drawing.Point(15, 15);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(287, 301);
            this.pnlUser.TabIndex = 14;
            // 
            // pbLock
            // 
            this.Animator.SetDecoration(this.pbLock, BunifuAnimatorNS.DecorationType.None);
            this.pbLock.Image = global::Presentacion.Properties.Resources.Lock_2_100px;
            this.pbLock.Location = new System.Drawing.Point(108, 93);
            this.pbLock.Name = "pbLock";
            this.pbLock.Size = new System.Drawing.Size(70, 70);
            this.pbLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLock.TabIndex = 38;
            this.pbLock.TabStop = false;
            this.pbLock.Click += new System.EventHandler(this.pbLock_Click);
            // 
            // bnContinue
            // 
            this.bnContinue.ActiveBorderThickness = 1;
            this.bnContinue.ActiveCornerRadius = 40;
            this.bnContinue.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bnContinue.ActiveForecolor = System.Drawing.Color.White;
            this.bnContinue.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.bnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bnContinue.BackColor = System.Drawing.Color.White;
            this.bnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnContinue.BackgroundImage")));
            this.bnContinue.ButtonText = "Continuar";
            this.bnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnContinue, BunifuAnimatorNS.DecorationType.None);
            this.bnContinue.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bnContinue.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnContinue.IdleBorderThickness = 1;
            this.bnContinue.IdleCornerRadius = 20;
            this.bnContinue.IdleFillColor = System.Drawing.Color.White;
            this.bnContinue.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnContinue.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnContinue.Location = new System.Drawing.Point(172, 248);
            this.bnContinue.Margin = new System.Windows.Forms.Padding(5);
            this.bnContinue.Name = "bnContinue";
            this.bnContinue.Size = new System.Drawing.Size(100, 45);
            this.bnContinue.TabIndex = 37;
            this.bnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnContinue.Visible = false;
            this.bnContinue.Click += new System.EventHandler(this.bnContinue_Click);
            // 
            // txUsuario
            // 
            this.txUsuario.BackColor = System.Drawing.Color.White;
            this.txUsuario.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUsuario.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUsuario.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUsuario.BorderThickness = 3;
            this.txUsuario.CampoObligatorio = true;
            this.txUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txUsuario, BunifuAnimatorNS.DecorationType.None);
            this.txUsuario.Enabled = false;
            this.txUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUsuario.isPassword = false;
            this.txUsuario.Location = new System.Drawing.Point(29, 180);
            this.txUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txUsuario.MaxLength = ((uint)(100u));
            this.txUsuario.MinimLengtth = ((uint)(0u));
            this.txUsuario.Name = "txUsuario";
            this.txUsuario.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txUsuario.OverText = "Usuario o documento";
            this.txUsuario.PermEspacios = false;
            this.txUsuario.Size = new System.Drawing.Size(228, 44);
            this.txUsuario.TabIndex = 18;
            this.txUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txUsuario.TextBoxCompare = null;
            this.txUsuario.TextCompare = "";
            this.txUsuario.Underline = true;
            this.txUsuario.Validacion = ValidatingType.Ninguna;
            this.txUsuario.UserGo += new Presentacion.Controles.TextBoxValide.UserGoDelegate(this.bnContinue_Click);
            // 
            // lbCreateOne
            // 
            this.lbCreateOne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCreateOne.CheckReference = null;
            this.lbCreateOne.CustomLabelType = Presentacion.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbCreateOne, BunifuAnimatorNS.DecorationType.None);
            this.lbCreateOne.EnabledTransitions = true;
            this.lbCreateOne.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreateOne.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCreateOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbCreateOne.Link = "";
            this.lbCreateOne.Location = new System.Drawing.Point(21, 38);
            this.lbCreateOne.Name = "lbCreateOne";
            this.lbCreateOne.Size = new System.Drawing.Size(247, 52);
            this.lbCreateOne.SizeTag = new System.Drawing.Size(0, 0);
            this.lbCreateOne.Style = Presentacion.Controles.LabelStyle.Custom;
            this.lbCreateOne.TabIndex = 17;
            this.lbCreateOne.Text = "Bienvenido(a), ingresa para iniciar un nuevo turno\r\n";
            // 
            // lbMoreOpt
            // 
            this.lbMoreOpt.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbMoreOpt.AutoSize = true;
            this.lbMoreOpt.CheckReference = this.chRecordar;
            this.lbMoreOpt.ContextMenuStrip = this.ctxMoreOptions;
            this.lbMoreOpt.CustomLabelType = Presentacion.Controles.LabelType.ContextMenu;
            this.Animator.SetDecoration(this.lbMoreOpt, BunifuAnimatorNS.DecorationType.None);
            this.lbMoreOpt.EnabledTransitions = false;
            this.lbMoreOpt.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbMoreOpt.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbMoreOpt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbMoreOpt.Link = "";
            this.lbMoreOpt.Location = new System.Drawing.Point(15, 262);
            this.lbMoreOpt.Name = "lbMoreOpt";
            this.lbMoreOpt.Size = new System.Drawing.Size(89, 19);
            this.lbMoreOpt.SizeTag = new System.Drawing.Size(0, 0);
            this.lbMoreOpt.Style = Presentacion.Controles.LabelStyle.Link;
            this.lbMoreOpt.TabIndex = 16;
            this.lbMoreOpt.Text = "Más opciones";
            this.lbMoreOpt.Visible = false;
            // 
            // chRecordar
            // 
            this.chRecordar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chRecordar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chRecordar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chRecordar.Checked = false;
            this.chRecordar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            this.Animator.SetDecoration(this.chRecordar, BunifuAnimatorNS.DecorationType.None);
            this.chRecordar.ForeColor = System.Drawing.Color.White;
            this.chRecordar.Location = new System.Drawing.Point(26, 209);
            this.chRecordar.Name = "chRecordar";
            this.chRecordar.Size = new System.Drawing.Size(20, 20);
            this.chRecordar.TabIndex = 13;
            // 
            // ctxMoreOptions
            // 
            this.ctxMoreOptions.AutoSize = false;
            this.ctxMoreOptions.BackColor = System.Drawing.Color.White;
            this.Animator.SetDecoration(this.ctxMoreOptions, BunifuAnimatorNS.DecorationType.None);
            this.ctxMoreOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmForgetUsername,
            this.toolStripSeparator1,
            this.toolStripMenuItemPro1});
            this.ctxMoreOptions.Name = "contextMenuPro1";
            this.ctxMoreOptions.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ctxMoreOptions.ShowItemToolTips = false;
            this.ctxMoreOptions.Size = new System.Drawing.Size(260, 90);
            this.ctxMoreOptions.Text = "¿Olvidaste tu contraseña?";
            // 
            // tsmForgetUsername
            // 
            this.tsmForgetUsername.AutoSize = false;
            this.tsmForgetUsername.BackColor = System.Drawing.Color.White;
            this.tsmForgetUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmForgetUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tsmForgetUsername.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.tsmForgetUsername.Name = "tsmForgetUsername";
            this.tsmForgetUsername.ShortcutKeyDisplayString = "";
            this.tsmForgetUsername.Size = new System.Drawing.Size(260, 40);
            this.tsmForgetUsername.Text = "¿Olvidaste tu nombre de usuario?";
            this.tsmForgetUsername.Click += new System.EventHandler(this.toolStripMenuItemPro1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(256, 6);
            // 
            // toolStripMenuItemPro1
            // 
            this.toolStripMenuItemPro1.AutoSize = false;
            this.toolStripMenuItemPro1.BackColor = System.Drawing.Color.White;
            this.toolStripMenuItemPro1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemPro1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.toolStripMenuItemPro1.ImageTransparentColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripMenuItemPro1.Name = "toolStripMenuItemPro1";
            this.toolStripMenuItemPro1.ShortcutKeyDisplayString = "";
            this.toolStripMenuItemPro1.Size = new System.Drawing.Size(260, 40);
            this.toolStripMenuItemPro1.Text = "Borrar usuario guardado";
            this.toolStripMenuItemPro1.Click += new System.EventHandler(this.toolStripMenuItemPro1_Click_1);
            // 
            // pnlPassword
            // 
            this.pnlPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlPassword.Controls.Add(this.lbNombre);
            this.pnlPassword.Controls.Add(this.bnSignIn);
            this.pnlPassword.Controls.Add(this.txContraseña);
            this.pnlPassword.Controls.Add(this.lbForgot);
            this.pnlPassword.Controls.Add(this.bnBack);
            this.pnlPassword.Controls.Add(this.lbRecordar);
            this.pnlPassword.Controls.Add(this.chRecordar);
            this.pnlPassword.Controls.Add(this.pbPicture);
            this.Animator.SetDecoration(this.pnlPassword, BunifuAnimatorNS.DecorationType.None);
            this.pnlPassword.Location = new System.Drawing.Point(15, 15);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(287, 301);
            this.pnlPassword.TabIndex = 13;
            this.pnlPassword.Visible = false;
            // 
            // lbNombre
            // 
            this.lbNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbNombre.CheckReference = null;
            this.lbNombre.CustomLabelType = Presentacion.Controles.LabelType.Custom;
            this.Animator.SetDecoration(this.lbNombre, BunifuAnimatorNS.DecorationType.None);
            this.lbNombre.EnabledTransitions = true;
            this.lbNombre.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.lbNombre.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbNombre.Link = "";
            this.lbNombre.Location = new System.Drawing.Point(0, 110);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(287, 28);
            this.lbNombre.SizeTag = new System.Drawing.Size(0, 0);
            this.lbNombre.Style = Presentacion.Controles.LabelStyle.Custom;
            this.lbNombre.TabIndex = 39;
            this.lbNombre.Text = "Caja Principal";
            this.lbNombre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bnSignIn
            // 
            this.bnSignIn.ActiveBorderThickness = 1;
            this.bnSignIn.ActiveCornerRadius = 40;
            this.bnSignIn.ActiveFillColor = System.Drawing.SystemColors.Highlight;
            this.bnSignIn.ActiveForecolor = System.Drawing.Color.White;
            this.bnSignIn.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.bnSignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bnSignIn.BackColor = System.Drawing.Color.White;
            this.bnSignIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnSignIn.BackgroundImage")));
            this.bnSignIn.ButtonText = "Ingresar";
            this.bnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Animator.SetDecoration(this.bnSignIn, BunifuAnimatorNS.DecorationType.None);
            this.bnSignIn.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bnSignIn.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnSignIn.IdleBorderThickness = 1;
            this.bnSignIn.IdleCornerRadius = 20;
            this.bnSignIn.IdleFillColor = System.Drawing.Color.White;
            this.bnSignIn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnSignIn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bnSignIn.Location = new System.Drawing.Point(172, 248);
            this.bnSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.bnSignIn.Name = "bnSignIn";
            this.bnSignIn.Size = new System.Drawing.Size(100, 45);
            this.bnSignIn.TabIndex = 38;
            this.bnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnSignIn.Click += new System.EventHandler(this.bnSignIn_Click);
            // 
            // txContraseña
            // 
            this.txContraseña.BackColor = System.Drawing.Color.White;
            this.txContraseña.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txContraseña.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txContraseña.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txContraseña.BorderThickness = 3;
            this.txContraseña.CampoObligatorio = true;
            this.txContraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animator.SetDecoration(this.txContraseña, BunifuAnimatorNS.DecorationType.None);
            this.txContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txContraseña.isPassword = true;
            this.txContraseña.Location = new System.Drawing.Point(21, 149);
            this.txContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txContraseña.MaxLength = ((uint)(20u));
            this.txContraseña.MinimLengtth = ((uint)(0u));
            this.txContraseña.Name = "txContraseña";
            this.txContraseña.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txContraseña.OverText = "Contraseña";
            this.txContraseña.PermEspacios = false;
            this.txContraseña.Size = new System.Drawing.Size(244, 44);
            this.txContraseña.TabIndex = 19;
            this.txContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txContraseña.TextBoxCompare = null;
            this.txContraseña.TextCompare = "";
            this.txContraseña.Underline = true;
            this.txContraseña.Validacion = ValidatingType.Ninguna;
            this.txContraseña.UserGo += new Presentacion.Controles.TextBoxValide.UserGoDelegate(this.bnSignIn_Click);
            // 
            // lbForgot
            // 
            this.lbForgot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbForgot.AutoSize = true;
            this.lbForgot.CheckReference = null;
            this.lbForgot.CustomLabelType = Presentacion.Controles.LabelType.TextOnly;
            this.Animator.SetDecoration(this.lbForgot, BunifuAnimatorNS.DecorationType.None);
            this.lbForgot.EnabledTransitions = true;
            this.lbForgot.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgot.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.lbForgot.Link = "";
            this.lbForgot.Location = new System.Drawing.Point(15, 262);
            this.lbForgot.Name = "lbForgot";
            this.lbForgot.Size = new System.Drawing.Size(149, 17);
            this.lbForgot.SizeTag = new System.Drawing.Size(0, 0);
            this.lbForgot.Style = Presentacion.Controles.LabelStyle.Link;
            this.lbForgot.TabIndex = 18;
            this.lbForgot.Text = "¿Olvidaste tu contraseña?";
            // 
            // bnBack
            // 
            this.bnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnBack.BackColor = System.Drawing.Color.Transparent;
            this.Animator.SetDecoration(this.bnBack, BunifuAnimatorNS.DecorationType.None);
            this.bnBack.Image = global::Presentacion.Properties.Resources.Back_50px;
            this.bnBack.ImageActive = null;
            this.bnBack.Location = new System.Drawing.Point(11, 6);
            this.bnBack.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bnBack.Name = "bnBack";
            this.bnBack.Size = new System.Drawing.Size(30, 30);
            this.bnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnBack.TabIndex = 17;
            this.bnBack.TabStop = false;
            this.toolTip1.SetToolTip(this.bnBack, "Volver");
            this.bnBack.Zoom = 20;
            this.bnBack.Click += new System.EventHandler(this.bnBack_Click);
            // 
            // lbRecordar
            // 
            this.lbRecordar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbRecordar.AutoSize = true;
            this.lbRecordar.BackColor = System.Drawing.Color.Transparent;
            this.lbRecordar.CheckReference = this.chRecordar;
            this.lbRecordar.CustomLabelType = Presentacion.Controles.LabelType.CheckBx;
            this.Animator.SetDecoration(this.lbRecordar, BunifuAnimatorNS.DecorationType.None);
            this.lbRecordar.EnabledTransitions = true;
            this.lbRecordar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecordar.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbRecordar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbRecordar.Link = "";
            this.lbRecordar.Location = new System.Drawing.Point(47, 209);
            this.lbRecordar.Name = "lbRecordar";
            this.lbRecordar.Size = new System.Drawing.Size(88, 17);
            this.lbRecordar.SizeTag = new System.Drawing.Size(0, 0);
            this.lbRecordar.Style = Presentacion.Controles.LabelStyle.Custom;
            this.lbRecordar.TabIndex = 14;
            this.lbRecordar.Text = "Recordarme";
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Animator.SetDecoration(this.pbPicture, BunifuAnimatorNS.DecorationType.None);
            this.pbPicture.Image = global::Presentacion.Properties.Resources.user;
            this.pbPicture.Location = new System.Drawing.Point(98, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(90, 90);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 11;
            this.pbPicture.TabStop = false;
            // 
            // Animator
            // 
            this.Animator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.Animator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.Animator.DefaultAnimation = animation3;
            this.Animator.TimeStep = 0.01F;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Animator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.MinimumSize = new System.Drawing.Size(317, 331);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(317, 331);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.VisibleChanged += new System.EventHandler(this.Login_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLock)).EndInit();
            this.ctxMoreOptions.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Controles.LabelPro lbLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Panel pnlPassword;
        public Controles.LabelPro lbRecordar;
        public Bunifu.Framework.UI.BunifuCheckbox chRecordar;
        public System.Windows.Forms.PictureBox pbPicture;
        private Controles.LabelPro lbMoreOpt;
        private Controles.LabelPro lbForgot;
        private Bunifu.Framework.UI.BunifuImageButton bnBack;
        private Controles.LabelPro lbCreateOne;
        private BunifuAnimatorNS.BunifuTransition Animator;
        private System.Windows.Forms.ToolTip toolTip1;
        private Controles.ContextMenuPro ctxMoreOptions;
        private Controles.ToolStripMenuItemPro tsmForgetUsername;
        private Controles.TextBoxValide txUsuario;
        private Controles.TextBoxValide txContraseña;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Controles.ToolStripMenuItemPro toolStripMenuItemPro1;
        public Bunifu.Framework.UI.BunifuThinButton2 bnSignIn;
        public Bunifu.Framework.UI.BunifuThinButton2 bnContinue;
        private Controles.LabelPro lbNombre;
        private System.Windows.Forms.PictureBox pbLock;
    }
}
