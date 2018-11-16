using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace Presentacion.Reportes
{
    public partial class frmReporteProducto : OfficeForm
    {
        public frmReporteProducto()
        {
            InitializeComponent();
        }

        private void frmReporteProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'cyberCatchVentasDataSet.Vista_Compatible_Producto' Puede moverla o quitarla según sea necesario.
            this.vista_Compatible_ProductoTableAdapter.Fill(this.cyberCatchVentasDataSet.Vista_Compatible_Producto);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
