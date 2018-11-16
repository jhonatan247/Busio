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
using Presentacion.Properties;
using Negocio.Manejo_de_datos;
using Presentacion.Vistas;
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmElegirSucursal : MetroAppForm
    {
        public static long IdUsuario = 0;
        public frmElegirSucursal(long pUsuario)
        {
            InitializeComponent();
            styleManager1.ManagerStyle = (eStyle)(10 + Settings.Default.Diseño);
            IdUsuario = pUsuario;
            Cargar();
        }
        void Cargar()
        {
            pnlSucursales.Controls.Clear();
            if (Convert.ToBoolean(new Negocio.Manejo_de_datos.Usuario().Select(IdUsuario)[3]))
            {
                bnSuperUsuario.Show();
            }
            else
            {
                bnSuperUsuario.Hide();
            }
            DataTable Dtable = new Permisos_Usuario_Sucursal().SelectPermisos(IdUsuario);
            for (int i = 0; i < Dtable.Rows.Count; i++)
            {
                viewCortaSucursal sucursal = new viewCortaSucursal(Dtable.Rows[i]);
                //sucursal.Location = new Point(0, 130*i);
                sucursal.AccionSeleccionar += Sucural_Select;
                sucursal.Dock = DockStyle.Top;
                pnlSucursales.Controls.Add(sucursal);
            }
        }
        private void Sucural_Select(DataRow pPermisos)
        {
            Hide();
            if (new frmInicio(pPermisos).ShowDialog() == DialogResult.OK)
            {
                Cargar();
                Show();
            }
            else
            {
                Close();
            }
        }
        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void bnSuperUsuario_Click(object sender, EventArgs e)
        {
            Hide();
            if (new frmInicio().ShowDialog() == DialogResult.OK)
            {
                Cargar();
                Show();
            }
            else
            {
                Close();
            }
        }
    }
}
