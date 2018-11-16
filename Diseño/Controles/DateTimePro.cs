using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Lógica;

namespace Presentacion.Controles
{
    public partial class DateTimePro : Bunifu.Framework.UI.BunifuDatepicker
    {
        ValidatingDateType validacion = ValidatingDateType.Fecha;
        Color idle, fore, colornormal, colorHove;
        DateTime valueCompare = Convert.ToDateTime("01/01/1001");
        string obligatory = "*", overText = "OverText";
        bool campoObligatorio = true;
        public bool CampoObligatorio
        {
            get
            {
                return campoObligatorio;
            }
            set
            {
                campoObligatorio = value;
                if (campoObligatorio)
                {
                    obligatory = "*";
                }
                else
                    obligatory = "";
                UpdateOver();
            }
        }
        public string OverText
        {
            get
            {
                return overText;
            }
            set
            {
                overText = value;

                if (value == "")
                {
                    lbOver.Hide();
                }
                else
                    lbOver.Show();
                UpdateOver();
            }
        }
        public DateTime ValueCompare
        {
            get
            {
                return valueCompare;
            }
            set
            {
                valueCompare = value;
            }
        }
        public ValidatingDateType Validacion
        {
            get
            {
                return validacion;
            }
            set
            {
                    validacion = value;
            }
        }

        public DateTimePro()
        {
            InitializeComponent();
            idle = colornormal = Style.Normalcolor;

            fore = Style.Textcolor;
            colorHove = Style.OnHovercolor;
            Style.OnHovercolor = Style.Normalcolor;
        }
        public void Normalize()
        {
            Style.Normalcolor = colornormal = lbOver.BackColor = idle;
            Style.Textcolor = fore;
        }
        public void Limpiar()
        {
            Value = DateTime.Now;
            lbOver.Show();
            Normalize();
        }
        void UpdateOver()
        {
            lbOver.Text = OverText + obligatory;
        }
        public bool IsNull(DateTime d)
        {
            if (d == Convert.ToDateTime("01/01/1001"))
                return true;
            return false;
        }
        public void Invalide()
        {

            Style.Normalcolor = colornormal = lbOver.BackColor= Color.Tomato;
            Style.Textcolor = Color.White;
            lbOver.Hide();
            
        }

        public void mostrarMensaje(string text)
        {
            Invalide();
            AccionesSistema.ShowToolTimInvaide(text, this);
        }

        private void lbOver_Click_1(object sender, EventArgs e)
        {
            Focus();
        }

        public bool IsCorrect()
        {
            bool retorno = true;
            if (!campoObligatorio && lbOver.Visible)
                return true;
            if (campoObligatorio && lbOver.Visible)
            {
                mostrarMensaje("Este campo es obligatorio");
                return false;
            }
            switch (validacion)
            {
                case ValidatingDateType.FechaMenorQue:
                    try
                    {
                        if (DateTime.Compare(Value,  valueCompare) <= 0)
                            retorno = false;
                    }
                    catch
                    {
                        retorno = false;
                    }
                    if (!retorno)
                        mostrarMensaje("El valor ingresado es incorrecto");
                    break;
                case ValidatingDateType.FechaMayorQue:
                    try
                    {
                        if (DateTime.Compare(Value, valueCompare) <= 0)
                            retorno = false;
                    }
                    catch
                    {
                        retorno = false;
                    }
                    if (!retorno)
                        mostrarMensaje("El valor ingresado es incorrecto");
                    break;
            }
            return retorno;
        }

        private void lbOver_Click(object sender, EventArgs e)
        {
            Style.OnHovercolor = colorHove;
            lbOver.Ocultar();
        }
        
        private void nOnValueChanged(object sender, EventArgs e)
        {

            if (Style.Normalcolor == Color.Tomato || ForeColor == Color.White)
            {
                Normalize();
            }
        }
    }
    public enum ValidatingDateType
    {
        Fecha,
        FechaMenorQue,
        FechaMayorQue,
    };
}
