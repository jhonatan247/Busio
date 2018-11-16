namespace Presentacion.Usuario
{
    partial class crtlCliente
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
            this.bnEditTipoDocumento = new DevComponents.DotNetBar.ButtonX();
            this.labelX15 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lbTitulo = new DevComponents.DotNetBar.LabelX();
            this.bnActualizar = new DevComponents.DotNetBar.ButtonX();
            this.bnLimpiar = new DevComponents.DotNetBar.ButtonX();
            this.bnGuardar = new DevComponents.DotNetBar.ButtonX();
            this.bnBorrar = new DevComponents.DotNetBar.ButtonX();
            this.bnBuscar = new DevComponents.DotNetBar.ButtonX();
            this.txNombres = new Presentacion.Controles.TextBoxExValide();
            this.txNumeroDocumento = new Presentacion.Controles.TextBoxExValide();
            this.txApellidos = new Presentacion.Controles.TextBoxExValide();
            this.txLimiteCredito = new Presentacion.Controles.TextBoxExValide();
            this.cbTipoDocumento = new Presentacion.Controles.ComboEXValide();
            this.cbSexo = new Presentacion.Controles.ComboEXValide();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txCorreo = new Presentacion.Controles.TextBoxExValide();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txTelefono = new Presentacion.Controles.TextBoxExValide();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txDireccion = new Presentacion.Controles.TextBoxExValide();
            this.dtmFechaNacimiento = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dtmFechaNacimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // bnEditTipoDocumento
            // 
            this.bnEditTipoDocumento.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnEditTipoDocumento.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnEditTipoDocumento.Location = new System.Drawing.Point(370, 180);
            this.bnEditTipoDocumento.Name = "bnEditTipoDocumento";
            this.bnEditTipoDocumento.Size = new System.Drawing.Size(23, 23);
            this.bnEditTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnEditTipoDocumento.Symbol = "57680";
            this.bnEditTipoDocumento.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnEditTipoDocumento.TabIndex = 86;
            this.bnEditTipoDocumento.TabStop = false;
            this.bnEditTipoDocumento.Click += new System.EventHandler(this.bnEditEmpresaDistribuidora_Click);
            // 
            // labelX15
            // 
            this.labelX15.AutoSize = true;
            // 
            // 
            // 
            this.labelX15.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX15.Location = new System.Drawing.Point(57, 367);
            this.labelX15.Name = "labelX15";
            this.labelX15.Size = new System.Drawing.Size(98, 15);
            this.labelX15.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX15.TabIndex = 65;
            this.labelX15.Text = "Límite de crédito:  $";
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(43, 182);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(100, 15);
            this.labelX9.TabIndex = 59;
            this.labelX9.Text = "Típo de documento:";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(26, 220);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(117, 15);
            this.labelX7.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX7.TabIndex = 55;
            this.labelX7.Text = "Número de documento:";
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(93, 111);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(50, 15);
            this.labelX6.TabIndex = 53;
            this.labelX6.Text = "Apellidos:";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(94, 73);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(50, 15);
            this.labelX5.TabIndex = 51;
            this.labelX5.Text = "Nombres:";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            // 
            // 
            // 
            this.lbTitulo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(40, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(212, 40);
            this.lbTitulo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.lbTitulo.TabIndex = 50;
            this.lbTitulo.Text = "  Nuevo Cliente  ";
            // 
            // bnActualizar
            // 
            this.bnActualizar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnActualizar.AutoSize = true;
            this.bnActualizar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bnActualizar.Location = new System.Drawing.Point(373, 478);
            this.bnActualizar.Name = "bnActualizar";
            this.bnActualizar.Size = new System.Drawing.Size(174, 45);
            this.bnActualizar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnActualizar.Symbol = "57673";
            this.bnActualizar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnActualizar.TabIndex = 17;
            this.bnActualizar.Text = "Actualizar";
            this.bnActualizar.Visible = false;
            this.bnActualizar.Click += new System.EventHandler(this.bnActualizar_Click);
            // 
            // bnLimpiar
            // 
            this.bnLimpiar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnLimpiar.AutoSize = true;
            this.bnLimpiar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bnLimpiar.Location = new System.Drawing.Point(22, 478);
            this.bnLimpiar.Name = "bnLimpiar";
            this.bnLimpiar.Size = new System.Drawing.Size(128, 45);
            this.bnLimpiar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnLimpiar.Symbol = "58392";
            this.bnLimpiar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnLimpiar.TabIndex = 19;
            this.bnLimpiar.Text = "Limpiar";
            this.bnLimpiar.Click += new System.EventHandler(this.bnLimpiar_Click);
            // 
            // bnGuardar
            // 
            this.bnGuardar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnGuardar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bnGuardar.Location = new System.Drawing.Point(419, 478);
            this.bnGuardar.Name = "bnGuardar";
            this.bnGuardar.Size = new System.Drawing.Size(128, 45);
            this.bnGuardar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnGuardar.Symbol = "57697";
            this.bnGuardar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnGuardar.TabIndex = 17;
            this.bnGuardar.Text = "Guardar";
            this.bnGuardar.Click += new System.EventHandler(this.bnGuardar_Click);
            // 
            // bnBorrar
            // 
            this.bnBorrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnBorrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bnBorrar.Location = new System.Drawing.Point(196, 478);
            this.bnBorrar.Name = "bnBorrar";
            this.bnBorrar.Size = new System.Drawing.Size(128, 45);
            this.bnBorrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnBorrar.Symbol = "59506";
            this.bnBorrar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnBorrar.TabIndex = 18;
            this.bnBorrar.Text = "Borrar";
            this.bnBorrar.Visible = false;
            this.bnBorrar.Click += new System.EventHandler(this.bnBorrar_Click);
            // 
            // bnBuscar
            // 
            this.bnBuscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bnBuscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bnBuscar.Dock = System.Windows.Forms.DockStyle.Left;
            this.bnBuscar.Location = new System.Drawing.Point(0, 0);
            this.bnBuscar.MaximumSize = new System.Drawing.Size(40, 40);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(40, 40);
            this.bnBuscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.bnBuscar.Symbol = "59574";
            this.bnBuscar.SymbolSet = DevComponents.DotNetBar.eSymbolSet.Material;
            this.bnBuscar.TabIndex = 20;
            this.bnBuscar.Visible = false;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // txNombres
            // 
            this.txNombres.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txNombres.Border.Class = "TextBoxBorder";
            this.txNombres.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNombres.CampoObligatorio = true;
            this.txNombres.DisabledBackColor = System.Drawing.Color.White;
            this.txNombres.ForeColor = System.Drawing.Color.Black;
            this.txNombres.Location = new System.Drawing.Point(144, 72);
            this.txNombres.MaxLength = 40;
            this.txNombres.MaxMinCompare = false;
            this.txNombres.MaxValue = 0D;
            this.txNombres.MinimLengtth = ((uint)(3u));
            this.txNombres.MinValue = 0D;
            this.txNombres.Name = "txNombres";
            this.txNombres.PermEspacios = true;
            this.txNombres.PreventEnterBeep = true;
            this.txNombres.Size = new System.Drawing.Size(399, 20);
            this.txNombres.TabIndex = 0;
            this.txNombres.Tag = "txApellidos";
            this.txNombres.TextBoxCompare = null;
            this.txNombres.TextCompare = "";
            this.txNombres.Validacion = ValidatingType.Letras;
            this.txNombres.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // txNumeroDocumento
            // 
            this.txNumeroDocumento.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txNumeroDocumento.Border.Class = "TextBoxBorder";
            this.txNumeroDocumento.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txNumeroDocumento.CampoObligatorio = true;
            this.txNumeroDocumento.DisabledBackColor = System.Drawing.Color.White;
            this.txNumeroDocumento.ForeColor = System.Drawing.Color.Black;
            this.txNumeroDocumento.Location = new System.Drawing.Point(144, 219);
            this.txNumeroDocumento.MaxLength = 20;
            this.txNumeroDocumento.MaxMinCompare = false;
            this.txNumeroDocumento.MaxValue = 0D;
            this.txNumeroDocumento.MinimLengtth = ((uint)(7u));
            this.txNumeroDocumento.MinValue = 0D;
            this.txNumeroDocumento.Name = "txNumeroDocumento";
            this.txNumeroDocumento.PermEspacios = false;
            this.txNumeroDocumento.PreventEnterBeep = true;
            this.txNumeroDocumento.Size = new System.Drawing.Size(399, 20);
            this.txNumeroDocumento.TabIndex = 4;
            this.txNumeroDocumento.Tag = "txCorreo";
            this.txNumeroDocumento.TextBoxCompare = null;
            this.txNumeroDocumento.TextCompare = "";
            this.txNumeroDocumento.Validacion = ValidatingType.Ninguna;
            this.txNumeroDocumento.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // txApellidos
            // 
            this.txApellidos.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txApellidos.Border.Class = "TextBoxBorder";
            this.txApellidos.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txApellidos.CampoObligatorio = true;
            this.txApellidos.DisabledBackColor = System.Drawing.Color.White;
            this.txApellidos.ForeColor = System.Drawing.Color.Black;
            this.txApellidos.Location = new System.Drawing.Point(144, 110);
            this.txApellidos.MaxLength = 40;
            this.txApellidos.MaxMinCompare = false;
            this.txApellidos.MaxValue = 0D;
            this.txApellidos.MinimLengtth = ((uint)(3u));
            this.txApellidos.MinValue = 0D;
            this.txApellidos.Name = "txApellidos";
            this.txApellidos.PermEspacios = true;
            this.txApellidos.PreventEnterBeep = true;
            this.txApellidos.Size = new System.Drawing.Size(399, 20);
            this.txApellidos.TabIndex = 1;
            this.txApellidos.Tag = "cbSexo";
            this.txApellidos.TextBoxCompare = null;
            this.txApellidos.TextCompare = "";
            this.txApellidos.Validacion = ValidatingType.Letras;
            this.txApellidos.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // txLimiteCredito
            // 
            this.txLimiteCredito.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txLimiteCredito.Border.Class = "TextBoxBorder";
            this.txLimiteCredito.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txLimiteCredito.CampoObligatorio = true;
            this.txLimiteCredito.DisabledBackColor = System.Drawing.Color.White;
            this.txLimiteCredito.ForeColor = System.Drawing.Color.Black;
            this.txLimiteCredito.Location = new System.Drawing.Point(157, 366);
            this.txLimiteCredito.MaxMinCompare = false;
            this.txLimiteCredito.MaxValue = 0D;
            this.txLimiteCredito.MinimLengtth = ((uint)(1u));
            this.txLimiteCredito.MinValue = 0D;
            this.txLimiteCredito.Name = "txLimiteCredito";
            this.txLimiteCredito.PermEspacios = false;
            this.txLimiteCredito.PreventEnterBeep = true;
            this.txLimiteCredito.Size = new System.Drawing.Size(386, 20);
            this.txLimiteCredito.TabIndex = 8;
            this.txLimiteCredito.Tag = "dtmFechaNacimiento";
            this.txLimiteCredito.Text = "0,00";
            this.txLimiteCredito.TextBoxCompare = null;
            this.txLimiteCredito.TextCompare = "";
            this.txLimiteCredito.Validacion = ValidatingType.uDecimal;
            this.txLimiteCredito.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.DisplayMember = "Text";
            this.cbTipoDocumento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTipoDocumento.ForeColor = System.Drawing.Color.White;
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.ItemHeight = 14;
            this.cbTipoDocumento.Location = new System.Drawing.Point(144, 182);
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(223, 20);
            this.cbTipoDocumento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbTipoDocumento.TabIndex = 3;
            this.cbTipoDocumento.Tag = "txNumeroDocumento";
            this.cbTipoDocumento.UserGo += new Presentacion.Controles.ComboEXValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // cbSexo
            // 
            this.cbSexo.DisplayMember = "Text";
            this.cbSexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSexo.ForeColor = System.Drawing.Color.White;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.ItemHeight = 14;
            this.cbSexo.Location = new System.Drawing.Point(144, 146);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(249, 20);
            this.cbSexo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbSexo.TabIndex = 2;
            this.cbSexo.Tag = "cbTipoDocumento";
            this.cbSexo.UserGo += new Presentacion.Controles.ComboEXValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(112, 146);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(31, 15);
            this.labelX2.TabIndex = 96;
            this.labelX2.Text = "Sexo:";
            // 
            // txCorreo
            // 
            this.txCorreo.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txCorreo.Border.Class = "TextBoxBorder";
            this.txCorreo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txCorreo.CampoObligatorio = false;
            this.txCorreo.DisabledBackColor = System.Drawing.Color.White;
            this.txCorreo.ForeColor = System.Drawing.Color.Black;
            this.txCorreo.Location = new System.Drawing.Point(144, 255);
            this.txCorreo.MaxLength = 50;
            this.txCorreo.MaxMinCompare = false;
            this.txCorreo.MaxValue = 0D;
            this.txCorreo.MinimLengtth = ((uint)(5u));
            this.txCorreo.MinValue = 7D;
            this.txCorreo.Name = "txCorreo";
            this.txCorreo.PermEspacios = false;
            this.txCorreo.PreventEnterBeep = true;
            this.txCorreo.Size = new System.Drawing.Size(399, 20);
            this.txCorreo.TabIndex = 5;
            this.txCorreo.Tag = "txTelefono";
            this.txCorreo.TextBoxCompare = null;
            this.txCorreo.TextCompare = "";
            this.txCorreo.Validacion = ValidatingType.Correo;
            this.txCorreo.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(106, 256);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(37, 15);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX3.TabIndex = 98;
            this.labelX3.Text = "E-mail:";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(95, 292);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(48, 15);
            this.labelX4.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX4.TabIndex = 100;
            this.labelX4.Text = "Teléfono:";
            // 
            // txTelefono
            // 
            this.txTelefono.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txTelefono.Border.Class = "TextBoxBorder";
            this.txTelefono.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txTelefono.CampoObligatorio = false;
            this.txTelefono.DisabledBackColor = System.Drawing.Color.White;
            this.txTelefono.ForeColor = System.Drawing.Color.Black;
            this.txTelefono.Location = new System.Drawing.Point(144, 291);
            this.txTelefono.MaxLength = 10;
            this.txTelefono.MaxMinCompare = false;
            this.txTelefono.MaxValue = 0D;
            this.txTelefono.MinimLengtth = ((uint)(10u));
            this.txTelefono.MinValue = 0D;
            this.txTelefono.Name = "txTelefono";
            this.txTelefono.PermEspacios = true;
            this.txTelefono.PreventEnterBeep = true;
            this.txTelefono.Size = new System.Drawing.Size(249, 20);
            this.txTelefono.TabIndex = 6;
            this.txTelefono.Tag = "txDireccion";
            this.txTelefono.TextBoxCompare = null;
            this.txTelefono.TextCompare = "";
            this.txTelefono.Validacion = ValidatingType.uInt;
            this.txTelefono.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(91, 327);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(52, 15);
            this.labelX8.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX8.TabIndex = 102;
            this.labelX8.Text = "Dirección:";
            // 
            // txDireccion
            // 
            this.txDireccion.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txDireccion.Border.Class = "TextBoxBorder";
            this.txDireccion.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txDireccion.CampoObligatorio = false;
            this.txDireccion.DisabledBackColor = System.Drawing.Color.White;
            this.txDireccion.ForeColor = System.Drawing.Color.Black;
            this.txDireccion.Location = new System.Drawing.Point(144, 326);
            this.txDireccion.MaxLength = 50;
            this.txDireccion.MaxMinCompare = false;
            this.txDireccion.MaxValue = 0D;
            this.txDireccion.MinimLengtth = ((uint)(5u));
            this.txDireccion.MinValue = 7D;
            this.txDireccion.Name = "txDireccion";
            this.txDireccion.PermEspacios = true;
            this.txDireccion.PreventEnterBeep = true;
            this.txDireccion.Size = new System.Drawing.Size(399, 20);
            this.txDireccion.TabIndex = 7;
            this.txDireccion.Tag = "txLimiteCredito";
            this.txDireccion.TextBoxCompare = null;
            this.txDireccion.TextCompare = "";
            this.txDireccion.Validacion = ValidatingType.Ninguna;
            this.txDireccion.UserGo += new Presentacion.Controles.TextBoxExValide.UserGoDelegate(this.txCodigoBarras_UserGo);
            // 
            // dtmFechaNacimiento
            // 
            // 
            // 
            // 
            this.dtmFechaNacimiento.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtmFechaNacimiento.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFechaNacimiento.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtmFechaNacimiento.ButtonDropDown.Visible = true;
            this.dtmFechaNacimiento.IsPopupCalendarOpen = false;
            this.dtmFechaNacimiento.Location = new System.Drawing.Point(144, 403);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtmFechaNacimiento.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFechaNacimiento.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtmFechaNacimiento.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtmFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtmFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtmFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtmFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtmFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtmFechaNacimiento.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFechaNacimiento.MonthCalendar.DisplayMonth = new System.DateTime(2017, 7, 1, 0, 0, 0, 0);
            this.dtmFechaNacimiento.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtmFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtmFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtmFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtmFechaNacimiento.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtmFechaNacimiento.MonthCalendar.TodayButtonVisible = true;
            this.dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            this.dtmFechaNacimiento.Size = new System.Drawing.Size(399, 20);
            this.dtmFechaNacimiento.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtmFechaNacimiento.TabIndex = 9;
            this.dtmFechaNacimiento.ValueChanged += new System.EventHandler(this.Finalizar_UserGo);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(36, 403);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(108, 15);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.labelX1.TabIndex = 104;
            this.labelX1.Text = "Fecha de nacimiento:";
            // 
            // crtlCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dtmFechaNacimiento);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txDireccion);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txTelefono);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txCorreo);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.txNombres);
            this.Controls.Add(this.txApellidos);
            this.Controls.Add(this.txNumeroDocumento);
            this.Controls.Add(this.txLimiteCredito);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.bnBuscar);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.bnGuardar);
            this.Controls.Add(this.bnBorrar);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.bnLimpiar);
            this.Controls.Add(this.bnActualizar);
            this.Controls.Add(this.bnEditTipoDocumento);
            this.Controls.Add(this.labelX15);
            this.MinimumSize = new System.Drawing.Size(588, 566);
            this.Name = "crtlCliente";
            this.Size = new System.Drawing.Size(588, 566);
            ((System.ComponentModel.ISupportInitialize)(this.dtmFechaNacimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX bnEditTipoDocumento;
        private DevComponents.DotNetBar.LabelX labelX15;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lbTitulo;
        private DevComponents.DotNetBar.ButtonX bnActualizar;
        private DevComponents.DotNetBar.ButtonX bnLimpiar;
        private DevComponents.DotNetBar.ButtonX bnGuardar;
        private DevComponents.DotNetBar.ButtonX bnBorrar;
        private DevComponents.DotNetBar.ButtonX bnBuscar;
        private Controles.TextBoxExValide txNombres;
        private Controles.TextBoxExValide txApellidos;
        private Controles.TextBoxExValide txNumeroDocumento;
        private Controles.TextBoxExValide txLimiteCredito;
        private Controles.ComboEXValide cbTipoDocumento;
        private Controles.ComboEXValide cbSexo;
        private DevComponents.DotNetBar.LabelX labelX2;
        private Controles.TextBoxExValide txCorreo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private Controles.TextBoxExValide txTelefono;
        private DevComponents.DotNetBar.LabelX labelX8;
        private Controles.TextBoxExValide txDireccion;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtmFechaNacimiento;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}
