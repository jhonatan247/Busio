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
using Presentacion.Formularios;

namespace Presentacion.Usuario
{
    public partial class crtlTipoDocumento : UserControl
    {
        long Id = 0;
        public crtlTipoDocumento()
        {
            InitializeComponent();
            List<string> itm = new List<string>();
            itm.Add("Persona");
            itm.Add("Empresa");
            cbAplicacion.DataSource = itm;
        }
        public void Restablecer()
        {
            lbMarca.Text = "NUEVO TÍPO DE DOCUMENTO";
            txPrefijo.Clear();
            txNombre.Clear();
            bnBorrar.Enabled = false;
            Id = 0;
            txNombre.Focus();
            crtlBuscar.Buscar();
        }

        private void bnNuevo_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            if (!txNombre.IsCorrect() || !txPrefijo.IsCorrect())
                return;
            bnGuardar.Focus();
            if (Id > 0)
            {
                try
                {
                    if (new Tipo_Documento(Id, txNombre.Text, txPrefijo.Text, cbAplicacion.SelectedText).Update() > 0)
                    {
                        MessageBoxEx.Show("Actualización satisfactoria");
                        Restablecer();
                        return;
                    }
                }
                catch { }
                MessageBoxEx.Show("No se ha actualizado, posiblemente exista un registro con el mismo nombre.");
            }
            else
            {
                try
                {
                    if (new Tipo_Documento(txNombre.Text, txPrefijo.Text, cbAplicacion.SelectedText).Insert() > 0)
                    {
                        MessageBoxEx.Show("Registro satisfactorio");
                        Restablecer();
                        return;
                    }

                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                MessageBoxEx.Show("No se ha insertado, posiblemente exista un registro con el mismo nombre.");
            }
            txNombre.Focus();
        }

        private void txNombre_UserGo(object sender, EventArgs e)
        {
            if (txNombre.IsCorrect())
            {
                txPrefijo.Focus();
            }
        }

        private void bnBorrar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                if (MessageBoxEx.Show("El Típo de Documento seleccionado se elmininará permantentemente y los objetos relacionados tendrán el valor por defecto.\n¿Deseas continuar?", "Reciclar",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (new Tipo_Documento().Delete(Id) > 0)
                    {
                        Restablecer();
                        return;
                    }
                    else
                        MessageBoxEx.Show("Ha ocurrido un error");
                }
            }
        }

        private void crtlBuscarMarca1_AccionSeleccionar(DataRow pSelect)
        {
            Id = Convert.ToInt64(pSelect[0]);
            txNombre.Text = lbMarca.Text = pSelect[1].ToString();
            txPrefijo.Text = pSelect[2].ToString();
            cbAplicacion.SelectedItem = pSelect[3].ToString();
            bnBorrar.Enabled = true;
        }
    }
}
