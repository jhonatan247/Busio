using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Net.Mail;
using Presentacion.Properties;
using Negocio.Lógica;

namespace Presentacion.Controles
{
    public partial class TextBoxValide : Bunifu.Framework.UI.BunifuMetroTextbox
    {

        Color idle, fore, Colornormal, Colorfocused, Colorhove;
        uint maxLength = 2000;
        uint minimLength = 0;
        ValidatingType validacion = ValidatingType.Ninguna;
        bool permEspacios = true, campoObligatorio = true, underline = true, focused=false;
        TextBoxValide textBoxCompare = null;
        string textCompare = "";
        string obligatory = "*", overText = "OverText";

        #region Delegados
        public delegate void UserGoDelegate(object sender, EventArgs e);
        #endregion
        #region Eventos
        public event UserGoDelegate UserGo;
        #endregion
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
        public bool Underline
        {
            get
            {
                return underline;
            }
            set
            {
                underline = value;
                if (!underline)
                {
                    pnlUnderline1.Visible = pnlUnderline2.Visible = pnlUnderline3.Visible = false;
                }
                else
                    pnlUnderline1.Visible = pnlUnderline2.Visible = pnlUnderline3.Visible = true;
            }
        }
        public TextBoxValide TextBoxCompare
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
                if (campoObligatorio)
                {
                    obligatory = "*";
                }
                else
                    obligatory = "";
                UpdateOver();
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
                if(value == ValidatingType.CompararConTextBox && textBoxCompare == null)
                {
                    MessageBox.Show("Ingrese un TextBox para comparar");
                }
                validacion = value;
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
        public uint MaxLength
        {
            get
            {
                return maxLength;
            }
            set
            {
                maxLength = value;
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
        public Color OverColor
        {
            get
            {
                return lbOver.ForColor;
            }
            set
            {
                lbOver.ForColor = value;
            }
        }
        public TextBoxValide()
        {
            InitializeComponent();
            idle= Colornormal = BorderColorIdle;
            Colorhove = BorderColorMouseHover;
            Colorfocused = BorderColorFocused;
            fore = ForeColor;
        }
        public void Limpiar()
        {
            Text = "";
            Normalize();
        }
        void UpdateOver()
        {
            lbOver.Text = OverText + obligatory;
        }
        public void Normalize()
        {
            BorderColorIdle = Colornormal = idle;
            lbOver.ForeColor = ForeColor = fore;
        }
        public void Invalide()
        {
            BorderColorIdle = Colornormal =
            lbOver.ForeColor = ForeColor = Color.Tomato;
        }

        private void pnlUnderline3_MouseHover(object sender, EventArgs e)
        {
            if(!focused)
                BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorhove;
        }

        private void lbOver_MouseMove(object sender, MouseEventArgs e)
        {
            if (!focused)
                BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorhove;
        }

        private void TextBoxValide_Enter(object sender, EventArgs e)
        {
            BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorfocused;
            focused = true;
        }

        private void pnlUnderline3_MouseLeave(object sender, EventArgs e)
        {
            if (!focused)
                BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colornormal;
        }

        private void TextBoxValide_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                UserGo(this, new EventArgs());
        }

        private void TextBoxValide_ForeColorChanged(object sender, EventArgs e)
        {
        }

        public void mostrarMensaje( string text){
            Invalide();
            AccionesSistema.ShowToolTimInvaide(text, this);
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
                if (!char.IsLetter(c) && !char.IsControl(c) && c != ' ')
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
            if (campoObligatorio && Text.Trim() == "")
            {
                mostrarMensaje("Este campo es obligatorio");
                return false;
            }

            if (Text.Length >= minimLength && Text.Length <= maxLength 
                || validacion == ValidatingType.CompararConTextBox 
                || validacion == ValidatingType.CompararTexto)
            {
                bool retorno = true;
                switch (validacion)
                {
                    case ValidatingType.CompararConTextBox:
                        if (textBoxCompare.Text != Text)
                        {
                            mostrarMensaje("Los valores no coinciden");
                            retorno= false;
                        }
                        break;
                    case ValidatingType.CompararTexto:
                        if (textCompare != Text)
                        {
                            mostrarMensaje("El valor ingresado no es correcto, por favor verifica en intenta nuevamente.");
                            retorno = false;
                        }
                        break;
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
                    case ValidatingType.uDecimal:
                        try
                        {
                            Text = (Convert.ToDouble(Text)<0? -Convert.ToDouble(Text): Convert.ToDouble(Text)).ToString();
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
            mostrarMensaje("Este campo debe tener entre " + minimLength + " y " + maxLength + " caracteres");
            return false;
        }
        string QuitarEspacios(string text)
        {
            string retorno = "";
            foreach(char c in text)
            {
                if(c!=' ')
                {
                    retorno += c;
                }
            }
            return retorno;
        }
        private void nClick(object sender, EventArgs e)
        {
            lbOver.Hide();
            Focus();
        }

        private void TextBoxXD_Leave(object sender, EventArgs e)
        {
            focused = false;
            BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colornormal;
            if (Text == "")
            {
                lbOver.Show();
            }
        }

        private void nOnValueChanged(object sender, EventArgs e)
        {
            BorderColorFocused = BorderColorIdle = BorderColorMouseHover = Colorfocused;
            focused = true;
            if (!permEspacios)
            {
                string sinSp = QuitarEspacios(Text);
                if (sinSp != Text)
                {
                    Text = sinSp;
                    Focus();
                }
            }
            if (Text == "")
            {
                lbOver.Mostrar();
            }
            else
                lbOver.Ocultar();
            
            if ( BorderColorIdle == Color.Tomato || ForeColor == Color.Tomato )
            {
                Normalize();
            }
        }
    }
    
}
