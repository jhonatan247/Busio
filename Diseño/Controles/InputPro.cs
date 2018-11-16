using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Controles
{
    public partial class InputPro : Form
    {
        public string ValueName
        {
            get
            {
                return txInput.OverText;
            }
            set
            {
                txInput.OverText = value;
            }
        }
        public ValidatingType Validacion
        {
            get
            {
                return txInput.Validacion;
            }
            set
            {
                txInput.Validacion = value;
            }
        }
        public uint Min
        {
            get
            {
                return txInput.MinimLengtth;
            }
            set
            {
                txInput.MinimLengtth = value;
            }
        }
        public uint Max
        {
            get
            {
                return txInput.MaxLength;
            }
            set
            {
                txInput.MaxLength = value;
            }
        }
        public InputPro()
        {
            InitializeComponent();
        }
        public InputPro(String pValueName, ValidatingType pValidacion, uint pMin, uint pMax)
        {
            InitializeComponent();
            ValueName = pValueName;
            Validacion = pValidacion;
            Min = pMin;
            Max = pMax;
        }
        public InputPro(string pValueName, string pCompare)
        {
            InitializeComponent();
            ValueName = pValueName;
            txInput.TextCompare = pCompare;
            Validacion = ValidatingType.CompararTexto;
            txInput.isPassword = true;
        }
        public InputPro(String pValueName, ValidatingType pValidacion, uint pMin)
        {
            InitializeComponent();
            ValueName = pValueName;
            Validacion = pValidacion;
            Min = pMin;
        }
        public InputPro(String pValueName, ValidatingType pValidacion)
        {
            InitializeComponent();
            ValueName = pValueName;
            Validacion = pValidacion;
        }
        public string ShowInput()
        {
            if (ShowDialog()== DialogResult.OK)
            {
                return txInput.Text;
            }
            else
            {
                return "";
            }
        }
        void Validar()
        {
            DialogResult = DialogResult.Cancel;
            if (txInput.IsCorrect())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private void bnOk_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void bnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txInput_UserGo(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
