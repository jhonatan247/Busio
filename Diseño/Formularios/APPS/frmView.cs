using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using System.Windows.Forms;

namespace Presentacion.Formularios
{
    public partial class frmView : MetroAppForm
    {
        public frmView(Control panelBack)
        {
            InitializeComponent();
            pnlBack.Controls.Clear();
            int x = Screen.PrimaryScreen.Bounds.Width / 2 - panelBack.Width / 2;
            int y = Screen.PrimaryScreen.Bounds.Height / 2 - panelBack.Height / 2;
            panelBack.Location = new Point((x < 0 ? 0 : x), (y < 0 ? 0: y) );
            panelBack.Click += frmView_Click;
            pnlBack.Controls.Add(panelBack);
        }

        private void frmView_Click(object sender, EventArgs e)
        {
            
            Close();
        }
    }
}
