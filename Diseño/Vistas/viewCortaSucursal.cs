using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
using Presentacion.Properties;

namespace Presentacion.Vistas
{
    public partial class viewCortaSucursal : UserControl
    {
        public DataRow Permisos;

        #region Delegados
        public delegate void SeleccionarDelegate(DataRow pPermisos);
        #endregion
        #region Eventos
        public event SeleccionarDelegate AccionSeleccionar;
        #endregion
        public viewCortaSucursal(DataRow pPermisos)
        {
            InitializeComponent();
            Permisos = pPermisos;
            DataRow Drow = new Sucursal().Select(Convert.ToInt64(pPermisos[2]));
            lbSucursal.Text = Drow[1].ToString();
            lbDireccion.Text+= Drow[3].ToString();
            lbTelefono.Text += Drow[4].ToString();
            lbRepresentante.Text += Drow[7].ToString();
            if (Drow[8].ToString() != "")
            {
                pbImagen.Image = AccionesSistema.ObtenerImagen(Drow[8]);
            }
        }

        private void viewCortaSucursal_Click(object sender, EventArgs e)
        {
            AccionSeleccionar(Permisos);
        }
    }
}
