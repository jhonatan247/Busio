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
    public partial class frmDineroFinal : MetroForm
    {
        double Value;
        double Esperado;
        public frmDineroFinal(double pEsperado)
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            Esperado = pEsperado;
            lbEsperado.Text = "$" + Esperado;
            txDinero.Text = pEsperado.ToString();
            txDinero.Focus();
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

        private void bnCalc_Click(object sender, EventArgs e)
        {
            if (calculator1.Visible)
            {

                calculator1.Hide();
                txDinero.Text = calculator1.Value.ToString();
                txDinero.Enabled = true;
                txDinero.Fucus();
                Height = 330;
                bnCalc.Symbol = "58831";
            }
            else
            {
                Height = 510;
                txDinero.Enabled = false;
                calculator1.Value = Value;
                calculator1.Show();
                calculator1.Focus();
                bnCalc.Symbol = "58830";
            }
            CenterToScreen();
        }
        private void txDinero_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Value = Convert.ToDouble(txDinero.Text);
                double dif = (Value > Esperado ? Value - Esperado : Esperado - Value);
                lbDiferencia.Text = "$" + dif;
                if(dif != 0)
                {
                    lbMensaje.Text = "La diferencia será registrada en el turno";
                    lbMensaje.Symbol = "57346";
                }
                else
                {
                    lbMensaje.Text = "¡Excelente! todo en orden";
                    lbMensaje.Symbol = "58826";
                }
            }
            catch
            {
                txDinero.Text = "0";
            }
        }

        private void txDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && txDinero.Text.IndexOf(",") < 0) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
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
    }
}
