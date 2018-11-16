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
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmTipoBusqueda : MetroForm
    {
        public frmTipoBusqueda(char[] pTipo)
        {
            InitializeComponent();
            if(pTipo[0] == '%' && pTipo[1] == '%')
            {
                chTodo.Checked = true;
            }
            else if (pTipo[0] == '%')
            {
                chFinal.Checked = true;
            }
            else if (pTipo[1] == '%')
            {
                chInicio.Checked = true;
            }
            else
                chTodo.Checked = true;

        }
        public char[] MostrarDialogo()
        {
            ShowDialog();
            if (chTodo.Checked)
            {
                char[] ch = { '%', '%' };
                return ch;
            }
            else if (chInicio.Checked)
            {
                char[] ch = { '\0', '%' };
                return ch;
            }
            else
            {
                char[] ch = { '%', '\0' };
                return ch;
            }
        }
        private void checkBoxX1_Click(object sender, EventArgs e)
        {
            foreach (CheckBoxX ch in panelEx1.Controls.OfType<CheckBoxX>())
                ch.Checked = false;
            ((CheckBoxX)sender).Checked = true;
        }

        private void bnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
