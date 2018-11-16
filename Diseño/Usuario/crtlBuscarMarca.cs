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
    public partial class crtlBuscarMarca : UserControl
    {
        bool accion = true;

        public bool Accion
        {
            get
            {
                return accion;
            }
            set
            {
                accion = value;
            }
        }
        #region Delegados
        public delegate void AccionDelegate(DataRow pSelect);
        #endregion
        #region Eventos
        public event AccionDelegate AccionSeleccionar;
        #endregion
        public crtlBuscarMarca()
        {
            InitializeComponent();
        }
        public void Buscar()
        {
            dtBuscar.Rows.Clear();
            DataTable dTable;
            Image res;
            if (accion)
            {
                dTable = new Marca().Like(txBuscar.Text);
                res = Resources.Marca;
            }
            else
            {
                dTable = new Marca().LikeOf(txBuscar.Text);
                res = Resources.Reciclaje;
            }

            foreach (DataRow row in dTable.Rows)
            {
                dtBuscar.Rows.Add(res, row[1].ToString());
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
                DataRow dRow = new Marca().Select(new Marca().SelectId(AccionesSistema.ObtenerValorSelecion(dtBuscar, 1).ToString()));
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
