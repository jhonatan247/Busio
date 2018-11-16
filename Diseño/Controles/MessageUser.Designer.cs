namespace Presentacion.Controles
{
    partial class MessageUser
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageUser));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMensaje = new Presentacion.Controles.LabelPro();
            this.lbTitulo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.bnOk = new Bunifu.Framework.UI.BunifuImageButton();
            this.bnCancel = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbImageDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCancel)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(99, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 155);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.lbMensaje);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 116);
            this.panel3.TabIndex = 4;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.CheckReference = null;
            this.lbMensaje.CustomLabelType = Presentacion.Controles.LabelType.Custom;
            this.lbMensaje.EnabledTransitions = true;
            this.lbMensaje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbMensaje.ForColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.lbMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(133)))), ((int)(((byte)(160)))));
            this.lbMensaje.Link = "";
            this.lbMensaje.Location = new System.Drawing.Point(105, 28);
            this.lbMensaje.MaximumSize = new System.Drawing.Size(245, 1000);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(56, 15);
            this.lbMensaje.SizeTag = new System.Drawing.Size(245, 90);
            this.lbMensaje.Style = Presentacion.Controles.LabelStyle.Over;
            this.lbMensaje.TabIndex = 0;
            this.lbMensaje.Text = "labelPro1";
            // 
            // lbTitulo
            // 
            this.lbTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(256, 39);
            this.lbTitulo.TabIndex = 1;
            this.lbTitulo.Text = "Título";
            this.lbTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlButtons.Controls.Add(this.bnOk);
            this.pnlButtons.Controls.Add(this.bnCancel);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(99, 155);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(256, 25);
            this.pnlButtons.TabIndex = 3;
            this.pnlButtons.Visible = false;
            // 
            // bnOk
            // 
            this.bnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnOk.BackColor = System.Drawing.Color.Transparent;
            this.bnOk.ImageActive = null;
            this.bnOk.Location = new System.Drawing.Point(229, 0);
            this.bnOk.Name = "bnOk";
            this.bnOk.Size = new System.Drawing.Size(27, 25);
            this.bnOk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnOk.TabIndex = 6;
            this.bnOk.TabStop = false;
            this.toolTip1.SetToolTip(this.bnOk, "Ok");
            this.bnOk.Visible = false;
            this.bnOk.Zoom = 15;
            this.bnOk.Click += new System.EventHandler(this.bnOk_Click);
            // 
            // bnCancel
            // 
            this.bnCancel.BackColor = System.Drawing.Color.Transparent;
            this.bnCancel.ImageActive = null;
            this.bnCancel.Location = new System.Drawing.Point(0, 0);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(27, 25);
            this.bnCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bnCancel.TabIndex = 4;
            this.bnCancel.TabStop = false;
            this.toolTip1.SetToolTip(this.bnCancel, "Cancel");
            this.bnCancel.Visible = false;
            this.bnCancel.Zoom = 15;
            this.bnCancel.Click += new System.EventHandler(this.bnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.panel2.Controls.Add(this.lbImageDescription);
            this.panel2.Controls.Add(this.pbImagen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 180);
            this.panel2.TabIndex = 2;
            // 
            // lbImageDescription
            // 
            this.lbImageDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbImageDescription.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImageDescription.ForeColor = System.Drawing.Color.Silver;
            this.lbImageDescription.Location = new System.Drawing.Point(0, 130);
            this.lbImageDescription.Name = "lbImageDescription";
            this.lbImageDescription.Size = new System.Drawing.Size(99, 50);
            this.lbImageDescription.TabIndex = 8;
            this.lbImageDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(14, 12);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(70, 70);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 7;
            this.pbImagen.TabStop = false;
            // 
            // MessageUser
            // 
            this.AlertAnimationDuration = 300;
            this.AutoCloseTimeOut = 20;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(244)))));
            this.BackColor2 = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(213)))));
            this.CaptionFont = new System.Drawing.Font("Century Gothic", 9F);
            this.ClientSize = new System.Drawing.Size(355, 180);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(114)))), ((int)(((byte)(196)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "MessageUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = DevComponents.DotNetBar.eBallonStyle.Alert;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCancel)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbTitulo;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bnOk;
        private Bunifu.Framework.UI.BunifuImageButton bnCancel;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbImageDescription;
        private System.Windows.Forms.Panel panel3;
        private LabelPro lbMensaje;
    }
}