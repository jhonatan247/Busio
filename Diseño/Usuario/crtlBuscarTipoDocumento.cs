using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentacion.Properties;
using Negocio.Manejo_de_datos;
using DevComponents.DotNetBar;
using Negocio.Lógica;

namespace Presentacion.Usuario
{
    public partial class crtlBuscarTipoDocumento : UserControl
    {
        #region Delegados
        public delegate void AccionDelegate(DataRow pSelect);
        #endregion
        #region Eventos
        public event AccionDelegate AccionSeleccionar;
        #endregion
        public crtlBuscarTipoDocumento()
        {
            InitializeComponent();
        }
        public void Buscar()
        {
            dtBuscar.Rows.Clear();

            DataTable dTable = new Tipo_Documento().Like(txBuscar.Text);
            foreach (DataRow row in dTable.Rows)
            {
                dtBuscar.Rows.Add(Resources.TipoDocumento, row[1].ToString());
            }
        }

        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dtBuscar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow dRow = new Tipo_Documento().Select(
                    new Tipo_Documento().SelectId(AccionesSistema.ObtenerValorSelecion(dtBuscar, 1).ToString()));
                try
                {
                    AccionSeleccionar(dRow);
                }
                catch { }
            }
            catch
            {
                AccionesSistema.RemoverSelecion(dtBuscar);
            }
        }
    }
}
