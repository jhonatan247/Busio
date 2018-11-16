using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar.Controls;
using Negocio.Lógica;
using System.Net.Mail;

namespace Presentacion.Controles
{
    public partial class TextBoxExValide : TextBoxX
    {
        bool maxMinCompare = false;
        double maxValue = 0, minValue = 0;
        uint minimLength = 0;
        ValidatingType validacion = ValidatingType.Ninguna;
        bool permEspacios = true, campoObligatorio = true;
        TextBoxExValide textBoxCompare = null;
        string textCompare = "";

        #region Delegados
        public delegate void UserGoDelegate(object sender, EventArgs e);
        public delegate void DefaultDelegate();
        #endregion
        #region Eventos
        public event UserGoDelegate UserGo;
        public event DefaultDelegate ErrorTextChanged;
        #endregion
        public bool MaxMinCompare
        {
            get
            {
                return maxMinCompare;
            }
            set
            {
                maxMinCompare = value;
            }
        }
        public double MaxValue
        {
            get
            {
                return maxValue;
            }
            set
            {
                maxValue = value;
            }
        }
        public double MinValue
        {
            get
            {
                return minValue;
            }
            set
            {
                minValue = value;
            }
        }
        public string TextCompare
        {
            get
            {
                return textCompare;
            }
            set
            {
                textCompare = value;
            }
        }
        public TextBoxExValide TextBoxCompare
        {
            get
            {
                return textBoxCompare;
            }
            set
            {
                textBoxCompare = value;
            }
        }
        public bool CampoObligatorio
        {
            get
            {
                return campoObligatorio;
            }
            set
            {
                campoObligatorio = value;
            }
        }
        public bool PermEspacios
        {
            get
            {
                return permEspacios;
            }
            set
            {
                permEspacios = value;
            }
        }
        public ValidatingType Validacion
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
        public uint MinimLengtth
        {
            get
            {
                return minimLength;
            }
            set
            {
                minimLength = value;
            }
        }


        public TextBoxExValide()
        {
            InitializeComponent();
        }
        bool IsNumber()
        {
            switch (validacion)
            {
                case ValidatingType.Double:
                case ValidatingType.uDouble:
                case ValidatingType.Decimal:
                case ValidatingType.Int:
                case ValidatingType.uDecimal:
                case ValidatingType.uInt:
                    return true;
                default:return false;
            }
        }


        public void mostrarMensaje(string text)
        {
            Focus();
            AccionesSistema.ShowToolTimInvaide(text, this);
            Focus();
        }
        public void Fucus()
        {
            Focus();
            SelectionStart = Text.Length - 1;
            SelectionLength = 0;
        }
        bool ValidarCorreo()
        {
            try
            {
                MailAddress MS = new MailAddress(Text);
                return true;
            }
            catch
            {
                return false;
            }
        }
        bool ValidarLetras()
        {
            foreach (char c in Text)
            {
                if (!char.IsLetter(c) && !char.IsControl(c) && !char.IsSeparator(c))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsCorrect()
        {
            if (!campoObligatorio && Text.Trim() == "")
                return true;
            if ((campoObligatorio && Text.Trim() == "") ||(campoObligatorio && IsNumber() && Convert.ToDouble(Text)==0))
            {
                mostrarMensaje("Este campo es obligatorio");
                return false;
            }
            if (validacion == ValidatingType.CompararConTextBox)
            {
                if (textBoxCompare.Text != Text)
                {
                    mostrarMensaje("Los valores ingresados no coinciden");
                    return false;
                }
            }
            if (validacion == ValidatingType.CompararTexto)
            {
                if (textCompare != Text)
                {
                    mostrarMensaje("El valor ingresado no es correcto, por favor verifica en intenta nuevamente.");
                    return false;
                }
            }
            if (maxMinCompare && IsNumber())
            {
                double temp = Convert.ToDouble(Text);
                if(temp < minValue || temp > maxValue)
                {
                    mostrarMensaje("El valor del campo debe estar entre "+minValue+" y "+maxValue);
                    return false;
                }
            }
            if (Text.Length >= minimLength)
            {
                bool retorno = true;
                switch (validacion)
                {
                    case ValidatingType.Correo:
                        retorno = ValidarCorreo();
                        if (!retorno)
                            mostrarMensaje("El valor ingresado no es una dirección de correo válida");
                        break;
                    case ValidatingType.Letras:
                        retorno = ValidarLetras();
                        if (!retorno)
                            mostrarMensaje("Este campo sólo acepta letras");
                        break;
                    case ValidatingType.User:
                        retorno = ValidarLetras() && !ValidarCorreo();
                        if (!retorno)
                            mostrarMensaje("El valor ingresado es incorrecto");
                        break;
                    case ValidatingType.Double:
                        try
                        {
                            Convert.ToDouble(Text);
                        }
                        catch
                        {
                            mostrarMensaje("El valor ingresado es incorrecto");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.uDouble:
                        try
                        {
                            Text = (Convert.ToDouble(Text) < 0 ? -Convert.ToDouble(Text) : Convert.ToDouble(Text)).ToString();
                        }
                        catch
                        {
                            mostrarMensaje("El valor ingresado es incorrecto");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.Decimal:
                        try
                        {
                            Convert.ToDecimal(Text);
                        }
                        catch
                        {
                            mostrarMensaje("El valor ingresado es incorrecto");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.uDecimal:
                        try
                        {
                            Text = (Convert.ToDecimal(Text) < 0 ? -Convert.ToDecimal(Text) : Convert.ToDecimal(Text)).ToString();
                        }
                        catch
                        {
                            mostrarMensaje("El valor ingresado es incorrecto");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.Int:
                        try
                        {
                            Convert.ToInt64(Text);
                        }
                        catch
                        {
                            mostrarMensaje("El valor ingresado es incorrecto");
                            retorno = false;
                        }
                        break;
                    case ValidatingType.uInt:
                        try
                        {
                            Text = Convert.ToUInt64(Text).ToString();
                        }
                        catch
                        {
                            mostrarMensaje("El valor ingresado es incorrecto");
                            retorno = false;
                        }
                        break;
                }
                return retorno;
            }
            mostrarMensaje("Este campo debe tener entre " + minimLength + " y " + MaxLength + " caracteres");
            return false;
        }
        string QuitarEspacios(string text)
        {
            string retorno = "";
            foreach (char c in text)
            {
                if (!char.IsSeparator(c))
                {
                    retorno += c;
                }
            }
            return retorno;
        }


        private void TextBoxValide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    UserGo(this, new EventArgs());
                }
                catch
                {
                }
            }
        }

        private void TextBoxExValide_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (validacion)
            {
                case ValidatingType.Letras:
                    if(  !char.IsLetter(e.KeyChar))
                        e.Handled = true;
                    if ((permEspacios && char.IsSeparator(e.KeyChar)))
                        e.Handled = false;
                    break;
                case ValidatingType.Double:
                case ValidatingType.Decimal:
                    if ((char.IsDigit(e.KeyChar) && Text.IndexOf('-') >= 0 && SelectionStart == 0 && SelectionLength == 0) || !(Char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && Text.IndexOf(",") < 0) || char.IsControl(e.KeyChar)))
                        e.Handled = true;
                    if (e.KeyChar == '-' && Text.IndexOf('-') < 0 && SelectionStart == 0 && SelectionLength == 0)
                        e.Handled = false;
                    break;
                case ValidatingType.uDouble:
                case ValidatingType.uDecimal:
                    if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == ',' && Text.IndexOf(",") < 0) || char.IsControl(e.KeyChar)))
                    {
                        e.Handled = true;
                    }
                    break;
                case ValidatingType.Int:
                    if ((char.IsDigit(e.KeyChar) && Text.IndexOf('-') >= 0 && SelectionStart == 0 && SelectionLength == 0) || !(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                        e.Handled = true;
                    if (e.KeyChar == '-' && Text.IndexOf('-') < 0 && SelectionStart == 0 && SelectionLength == 0)
                        e.Handled = false;
                    break;
                case ValidatingType.uInt:
                    if (!(Char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
                    {
                        e.Handled = true;
                    }
                    break;
            }
        }

        private void nOnValueChanged(object sender, EventArgs e)
        {
            if (!permEspacios)
            {
                string sinSp = QuitarEspacios(Text);
                if (sinSp != Text)
                {
                    Text = sinSp;
                    Focus();
                }
            }
            switch (validacion)
            {
                case ValidatingType.Letras:
                    if (!ValidarLetras())
                    {
                        Text = "";
                    }
                    break;
                case ValidatingType.Double:
                    try
                    {
                        Convert.ToDouble(Text);
                    }
                    catch
                    {
                        try
                        {
                            ErrorTextChanged();
                        }
                        catch { }
                        Text = "0,00";
                    }
                    break;
                case ValidatingType.uDouble:
                    try
                    {
                        if (Convert.ToDouble(Text) < 0)
                        {
                            int s = SelectionStart;
                            Text = Text.Substring(1, Text.Length - 1);
                            MoveTo(s);
                        }
                    }
                    catch
                    {
                        try
                        {
                            ErrorTextChanged();
                        }
                        catch { }
                        Text = "0,00";
                    }
                    break;
                case ValidatingType.Decimal:
                    try
                    {
                        Convert.ToDecimal(Text);
                    }
                    catch
                    {
                        try
                        {
                            ErrorTextChanged();
                        }
                        catch { }
                        Text = "0,00";
                    }
                    break;
                case ValidatingType.uDecimal:
                    try
                    {
                        if (Convert.ToDecimal(Text) < 0)
                        {
                            int s = SelectionStart;
                            Text = Text.Substring(1, Text.Length - 1);
                            MoveTo(s);
                        }
                    }
                    catch
                    {
                        try
                        {
                            ErrorTextChanged();
                        }
                        catch { }
                        Text = "0,00";
                    }
                    break;
                case ValidatingType.Int:
                    try
                    {
                        Convert.ToInt64(Text);
                    }
                    catch
                    {
                        try
                        {
                            ErrorTextChanged();
                        }
                        catch { }
                        Text = "0";
                    }
                    break;
                case ValidatingType.uInt:
                    try
                    {
                        Convert.ToUInt64(Text);
                    }
                    catch
                    {
                        try
                        {
                            ErrorTextChanged();
                        }
                        catch { }
                        Text = "0";
                    }
                    break;
            }

            if (maxMinCompare && IsNumber())
            {
                double temp = Convert.ToDouble(Text);
                if (temp < minValue || temp > maxValue)
                {
                    try
                    {
                        ErrorTextChanged();
                    }
                    catch { }
                    if(temp < minValue)
                    {
                        Text = minValue.ToString();
                        MoveToIni();
                    }
                    else
                    {
                        Text = maxValue.ToString();
                        MoveToEnd();
                    }
                }
            }
        }
        public void MoveToIni()
        {
            SelectionStart = 0;
            SelectionLength = 0;
        }
        public void MoveToEnd()
        {
            SelectionStart = Text.Length;
            SelectionLength = 0;
        }
        public void MoveTo(int val)
        {
            SelectionStart = val;
            SelectionLength = 0;
        }
    }
}
namespace Presentacion{
    public enum ValidatingType
    {
        Ninguna,
        Double,
        uDouble,
        Decimal,
        Int,
        uDecimal,
        uInt,
        Letras,
        User,
        Correo,
        CompararConTextBox,
        CompararTexto
    };
}
