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
    public partial class frmDineroInicial : MetroForm
    {
        public double Value { get { return Convert.ToDouble(txDinero.Text); } }
        public frmDineroInicial()
        {
            InitializeComponent();
            styleManager1.ManagerStyle = (eStyle)(10 + Settings.Default.Diseño);
            txDinero.Focus();
        }

        public double get(){
            ShowDialog();
            return Value;
        }
        private void bnCalc_Click(object sender, EventArgs e)
        {
            if (calculator1.Visible)
            {

                calculator1.Hide();
                txDinero.Text = calculator1.Value.ToString();
                txDinero.Enabled = true;
                txDinero.Fucus();
                Height = 225;
                CenterToScreen();
                bnCalc.Symbol = "58831";
            }
            else
            {
                Height = 390;
                CenterToScreen();
                txDinero.Enabled = false;
                calculator1.Value = Value;
                calculator1.Show();
                calculator1.Focus();
                bnCalc.Symbol = "58830";
            }
        }

        private void bnFinalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDineroInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (calculator1.Visible)
                txDinero.Text = calculator1.Value.ToString();
            if (!txDinero.IsCorrect())
                e.Cancel = true;
        }

        private void calculator1_ValueChanged(object sender, DevComponents.Editors.ValueChangedEventArgs e)
        {
            txDinero.Text = calculator1.Value.ToString();
        }

        private void txDinero_Click(object sender, EventArgs e)
        {
            if (!txDinero.Enabled)
                calculator1.Focus();
        }

        private void calculator1_CalculatorDisplayChanged(object sender, EventArgs e)
        {
            txDinero.Text = calculator1.Value.ToString();
        }
        
    }
}
