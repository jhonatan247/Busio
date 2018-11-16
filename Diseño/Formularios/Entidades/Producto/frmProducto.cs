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
using Presentacion.Usuario;
using Negocio.Manejo_de_datos;

namespace Presentacion.Formularios
{
    public partial class frmProducto : OfficeForm
    {
        public frmProducto()
        {
            InitializeComponent();
            crtlProducto1.Cargar();
        }
        public frmProducto(BuscadorProducto pIdentidad)
        {
            InitializeComponent();
            crtlProducto1.Cargar();
            crtlProducto1.Accion = false;
            crtlProducto1.Identidad = pIdentidad;
        }

        private void crtlProducto1_AccionBuscar()
        {
            frmBuscarProducto fBuscarProd = new frmBuscarProducto(false, false);
            if (fBuscarProd.ShowDialog() == DialogResult.OK)
            {
                crtlProducto1.Identidad = new BuscadorProducto(new Sucursal().SelectId(fBuscarProd.Drow[1].ToString()), Convert.ToInt64(fBuscarProd.Drow[0]));
            }
        }

        private void crtlProducto1_AccionEliminar()
        {
            Close();
        }
    }
}
