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
    public partial class crtlBuscarEmpresaDistribuidora : UserControl
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
        public crtlBuscarEmpresaDistribuidora()
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
                dTable = new Empresa_Distribuidora().Like(txBuscar.Text);
                res = Resources.EmpresaD;
            }
            else
            {
                dTable = new Empresa_Distribuidora().LikeOf(txBuscar.Text);
                res = Resources.Reciclaje;
            }

            foreach (DataRow row in dTable.Rows)
            {
                dtBuscar.Rows.Add(row[4].ToString()==""?res: row[4], row[2].ToString());
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
                DataRow dRow = new Empresa_Distribuidora().Select(new Empresa_Distribuidora().SelectId(AccionesSistema.ObtenerValorSelecion(dtBuscar, 1).ToString()));
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
