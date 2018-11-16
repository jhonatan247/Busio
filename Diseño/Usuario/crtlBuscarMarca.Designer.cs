﻿namespace Presentacion.Usuario
{
    partial class crtlBuscarMarca
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
            this.dtBuscar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.clImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.clPrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.txBuscar = new Presentacion.Controles.TextBoxExValide();
            ((System.ComponentModel.ISupportInitialize)(this.dtBuscar)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtBuscar
            // 
            this.dtBuscar.AllowUserToAddRows = false;
            this.dtBuscar.AllowUserToDeleteRows = false;
            this.dtBuscar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtBuscar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtBuscar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clImagen,
            this.clPrecioCompra});
            this.dtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtBuscar.EnableHeadersVisualStyles = false;
            this.dtBuscar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dtBuscar.Location = new System.Drawing.Point(0, 34);
            this.dtBuscar.MultiSelect = false;
            this.dtBuscar.Name = "dtBuscar";
            this.dtBuscar.ReadOnly = true;
            this.dtBuscar.SelectAllSignVisible = false;
            this.dtBuscar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtBuscar.ShowEditingIcon = false;
            this.dtBuscar.ShowRowErrors = false;
            this.dtBuscar.Size = new System.Drawing.Size(317, 290);
            this.dtBuscar.TabIndex = 4;
            this.dtBuscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtBuscar_CellContentDoubleClick);
            // 
            // clImagen
            // 
            this.clImagen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clImagen.FillWeight = 300F;
            this.clImagen.HeaderText = "";
            this.clImagen.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.clImagen.Name = "clImagen";
            this.clImagen.ReadOnly = true;
            this.clImagen.Width = 30;
            // 
            // clPrecioCompra
            // 
            this.clPrecioCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clPrecioCompra.HeaderText = "Marca";
            this.clPrecioCompra.Name = "clPrecioCompra";
            this.clPrecioCompra.ReadOnly = true;
            this.clPrecioCompra.Width = 244;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.txBuscar);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(317, 34);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 3;
            // 
            // txBuscar
            // 
            this.txBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txBuscar.Border.Class = "TextBoxBorder";
            this.txBuscar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txBuscar.CampoObligatorio = true;
            this.txBuscar.DisabledBackColor = System.Drawing.Color.Black;
            this.txBuscar.Location = new System.Drawing.Point(6, 6);
            this.txBuscar.MaxMinCompare = false;
            this.txBuscar.MaxValue = 0D;
            this.txBuscar.MinimLengtth = ((uint)(0u));
            this.txBuscar.MinValue = 0D;
            this.txBuscar.Name = "txBuscar";
            this.txBuscar.PermEspacios = true;
            this.txBuscar.PreventEnterBeep = true;
            this.txBuscar.Size = new System.Drawing.Size(305, 20);
            this.txBuscar.TabIndex = 0;
            this.txBuscar.TextBoxCompare = null;
            this.txBuscar.TextCompare = "";
            this.txBuscar.Validacion = ValidatingType.Ninguna;
            this.txBuscar.WatermarkText = "Buscar";
            this.txBuscar.TextChanged += new System.EventHandler(this.txBuscar_TextChanged);
            // 
            // crtlBuscarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtBuscar);
            this.Controls.Add(this.panelEx1);
            this.MaximumSize = new System.Drawing.Size(317, 100000);
            this.MinimumSize = new System.Drawing.Size(317, 324);
            this.Name = "crtlBuscarMarca";
            this.Size = new System.Drawing.Size(317, 324);
            ((System.ComponentModel.ISupportInitialize)(this.dtBuscar)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.DataGridViewX dtBuscar;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private Controles.TextBoxExValide txBuscar;
        private System.Windows.Forms.DataGridViewImageColumn clImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecioCompra;
    }
}
