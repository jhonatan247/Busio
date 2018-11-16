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
using Presentacion.Properties;

namespace Presentacion.Formularios
{
    public partial class frmBuscarProducto : MetroForm
    {
        public DataRow Drow;
        public List<long> lstSelect { get; set; }

        public frmBuscarProducto(bool pMultiSelect, bool pVender)
        {
            InitializeComponent();
            crtlBuscarProducto1.MultiSelect = pMultiSelect;
            crtlBuscarProducto1.Vender = pVender;
            DialogResult = DialogResult.Cancel;
            crtlBuscarProducto1.Buscar();
            
        }

        private void crtlBuscarProducto1_AccionSeleccionar(DataRow pSelect)
        {
            DialogResult = DialogResult.OK;
            Drow = pSelect;
            Close();
        }

        private void crtlBuscarProducto1_AccionSeleccionarMultiple(List<long> pSelect)
        {
            lstSelect = pSelect;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
