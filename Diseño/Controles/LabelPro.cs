using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Bunifu.Framework.UI;
using DevComponents.DotNetBar;
using Presentacion.Properties;
using Negocio.Lógica;

namespace Presentacion.Controles
{
    public partial class LabelPro : BunifuCustomLabel
    {
        
        string link = "";
        LabelType customLabelType = LabelType.Custom;
        Color forColor = Color.FromArgb(20, 122, 224);
        BunifuCheckbox checkReference = null;
        private bool enabledTransitions = true;
        private LabelStyle style = LabelStyle.Custom;
        bool clck = false;
        Size sizeTag = new Size(0, 0);
        
        public Size SizeTag
        {
            get
            {
                return sizeTag;
            }
            set
            {
                sizeTag = value;
            }
        }
        public LabelStyle Style
        {
            get
            {
                return style;
            }
            set
            {
                style = value;
                UpdateStyle();
            }
        }
        /// <summary>
        /// True para activar transiciones
        /// </summary>
        public bool EnabledTransitions
        {
            get
            {
                return enabledTransitions;
            }
            set
            {
                enabledTransitions = value;
            }
        }
        public BunifuCheckbox CheckReference
        {
            get
            {
                return checkReference;
            }
            set
            {
                checkReference = value;
                if(value != null)
                {
                    checkReference.OnChange += new EventHandler(Check_OnChanged);
                    onCheck();
                }
            }
        }
        public Color ForColor
        {
            get
            {
                return forColor;
            }
            set
            {
                forColor = ForeColor = value;
            }
        }
        public string Link
        {
            get
            {
                return link;
            }
            set
            {
                link = value;
            }
        }
        public LabelType CustomLabelType
        {
            get
            {
                return customLabelType;
            }
            set
            {
                SuspendLayout();
                if (ActualizarTipo(value))
                    customLabelType = value;
                ResumeLayout();
            }
        }
        public LabelPro()
        {
            InitializeComponent();
            foreach (ToolStripMenuItemPro tsm in contextMenuPro1.Items.OfType<ToolStripMenuItemPro>())
                tsm.Click += new EventHandler(context_click);
        }
        public void Mostrar()
        {
            if (!Visible)
            {
                if (enabledTransitions)
                {
                    Animator.ShowSync(this);
                }
                else
                    Show();
            }
        }
        public void Ocultar()
        {
            if (Visible)
            {
                if (enabledTransitions)
                {
                    Animator.HideSync(this);
                }
                else
                    Hide();
            }
        }
        public void Animar()
        {
            Hide();
            Animator.ShowSync(this);
        }
        void onCheck()
        {
            checkReference.Select();
            if( checkReference.Checked)
            {
                tsmCheck.Text = "Uncheck";
            }
            else
                tsmCheck.Text = "Check";
        }
        void UpdateStyle()
        {
            SuspendLayout();
            switch (style)
            {
                case LabelStyle.Link:
                    ForColor = Color.FromArgb(20,122,224);
                    break;
                case LabelStyle.Opaque:
                    ForColor = Color.FromArgb(84, 103, 130);
                    break;
                case LabelStyle.Over:
                    ForColor = Color.FromArgb(114, 133, 160);
                    break;
            }
            ResumeLayout();
        }
        bool ActualizarTipo(LabelType tipo) {
            OcultarContext();
            switch(tipo)
            {
                case LabelType.TextOnly:
                    tsmCopy.Show();
                    break;
                case LabelType.ContextMenu:
                    if (ContextMenuStrip == contextMenuPro1)
                    {
                        MessageBox.Show("Establezca un menú contextual diferente al predeterminado");
                        return false;
                    }
                    ContextMenuStrip.VisibleChanged += new EventHandler(context_VisibleChanged);
                    break;
                case LabelType.Link:
                    if(link == "")
                    {
                        MessageBox.Show("Establezca un valor en la propiedad link");
                        return false;
                    }
                    tsmGo.Show();
                    tsmCopyLink.Show();
                    break;
                case LabelType.CheckBx:
                    if(checkReference == null)
                    {
                        MessageBox.Show("Establezca el check box referente al label");
                        return false;
                    }
                    tsmCheck.Show();
                    break;
                case LabelType.Hide:
                    Animator.TimeStep = 0.05f;
                    break;
            }
            return true;
        }
        void OcultarContext()
        {
            foreach(ToolStripMenuItemPro tsm in contextMenuPro1.Items.OfType<ToolStripMenuItemPro>())
                tsm.Hide();
        }
        private void LinkLabelDesign_MouseHover(object sender, EventArgs e)
        {
            int r = forColor.R +30, g = forColor.G + 30, b = forColor.B + 30;
            ForeColor = Color.FromArgb((r > 255 ? 255 : r), (g > 255 ? 255 : g), (b > 255 ? 255 : b));
        }

        private void LinkLabelDesign_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = forColor;
        }

        private void context_click(object sender, EventArgs e)
        {
            switch (customLabelType)
            {
                case LabelType.Link:
                    Process.Start(link);
                    AccionesSistema.ShowToast("Abriendo, por favor espera", this);
                    break;
                case LabelType.CheckBx:
                    checkReference.Checked = !checkReference.Checked;
                    onCheck();
                    break;
                case LabelType.TextOnly:
                    Clipboard.SetText(Text);
                    AccionesSistema.ShowToast("Copiado al portapapeles", this);
                    break;
            }
        }
        private void LinkLabelDesign_Click(object sender, EventArgs e)
        {
            switch (customLabelType)
            {
                case LabelType.Link:
                    Process.Start(link);
                    break;
                case LabelType.ContextMenu:
                    clck = true;
                    ContextMenuStrip.Show(Parent, Location.X, Location.Y);
                    clck = false;
                    break;
                case LabelType.CheckBx:
                    checkReference.Checked = !checkReference.Checked;
                    onCheck();
                    break;
                case LabelType.Hide:
                    Ocultar();
                    return;
            }
            if (enabledTransitions)
                Animar();
        }
        private void context_VisibleChanged(object sender, EventArgs e)
        {
            if (!clck)
            {
                ContextMenuStrip.Hide();
                OnClick(new EventArgs());
            }
        }
        private void Check_OnChanged(object sender, EventArgs e)
        {
            onCheck();
        }
    }
    public enum LabelType
    {
        Custom,
        Hide,
        TextOnly,
        Link,
        ContextMenu,
        CheckBx
    }
    public enum LabelStyle
    {
        Custom,
        Text,
        Link,
        Opaque,
        Over
    }
}
