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
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmColumnasVisibles : MetroForm
    {
        public List<string> nombres = new List<string>();
        public List<bool> visible = new List<bool>();
        public frmColumnasVisibles(DataGridViewColumnCollection clmns)
        {
            InitializeComponent();
            foreach(DataGridViewColumn clmn in clmns)
                dataGridViewX1.Rows.Add(clmn.Name, clmn.HeaderText, clmn.Visible);
            DialogResult = DialogResult.Cancel;
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bnAceptar_Click(object sender, EventArgs e)
        {
            for(int i = 0; i<dataGridViewX1.RowCount; i++)
            {
                nombres.Add(dataGridViewX1.Rows[i].Cells[0].Value.ToString());
                visible.Add(Convert.ToBoolean(dataGridViewX1.Rows[i].Cells[2].Value));
            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
