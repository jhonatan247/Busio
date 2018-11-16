using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using Presentacion.Properties;
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmCerrarTurno : MetroForm
    {
        public frmCerrarTurno()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnCerrarTurno_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void bnDejarAbierto_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void bnCerrarTurnoSucursal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
            Close();
        }
    }
}
