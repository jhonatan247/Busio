using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar;

namespace Presentacion.Controles
{
    public partial class InputEx : MetroForm
    {
        public String Value
        {
            get { return txValue.Text; }
        }
        public InputEx(string title, string description, ValidatingType type) 
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Text = title;
            txValue.Validacion = type;
            txValue.WatermarkText = title;
            superTooltip1.SetSuperTooltip(txValue, new SuperTooltipInfo(title, "", description, null, null, eTooltipColor.Gray));
        }
        public InputEx(string title, string description, ValidatingType type, String def) : this(title, description, type)
        {
            txValue.Text = def;
        }

        public InputEx(string title, string description, ValidatingType type, String def, double min, double max) : this(title, description, type, def)
        {
            txValue.MinValue = min;
            txValue.MaxValue = max;
            txValue.MaxMinCompare = true;
        }

        private void bnAcept_Click(object sender, EventArgs e)
        {
            if (txValue.IsCorrect())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void bnCanclel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
