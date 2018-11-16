using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controles
{
    public partial class ToolStripMenuItemPro : ToolStripMenuItem
    {
        Color forColor;
        public ToolStripMenuItemPro()
        {
            InitializeComponent();
            forColor = ForeColor;
        }
        public void Hide()
        {
            Visible = false;
        }
        public void Show()
        {
            Visible = true;
        }

        private void ToolStripMenuItemPro_MouseHover(object sender, EventArgs e)
        {
            ForeColor = Color.WhiteSmoke;
        }

        private void ToolStripMenuItemPro_MouseLeave(object sender, EventArgs e)
        {
            ForeColor = forColor;
        }

        private void ToolStripMenuItemPro_MouseMove(object sender, MouseEventArgs e)
        {
            ForeColor = Color.WhiteSmoke;
        }
    }
}
