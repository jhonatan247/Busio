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
    public partial class crtlEmpresaDistribuidora : UserControl
    {
        long Id = 0;
        public crtlEmpresaDistribuidora()
        {
            InitializeComponent();
        }
        public void Restablecer()
        {
            Cargar();
            lbMarca.Text = "NUEVA EMPRESA DISTRIBUIDORA";
            txNumDocumento.Clear();
            txNombre.Clear();
            bnBorrar.Enabled = false;
            Id = 0;
            txNombre.Focus();
            crtlBuscar.Buscar();
        }
        public void Cargar()
        {
            comboEXValide1.DataSource = new Tipo_Documento().SelectAllEmpresa();
        }
        private void bnNuevo_Click(object sender, EventArgs e)
        {
            Restablecer();
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            if (!txNombre.IsCorrect())
                return;
            bnGuardar.Focus();
            if (Id > 0)
            {
                try
                {
                    if (new Empresa_Distribuidora(Id,new Tipo_Documento().SelectId(comboEXValide1.SelectedValue.ToString()), txNombre.Text,
                        txNumDocumento.Text, pbImagen.Tag == null ? null : pbImagen.Image, true).Update() > 0)
                    {
                        MessageBoxEx.Show("Actualización satisfactoria");
                        Restablecer();
                        return;
                    }
                }
                catch{ }
                MessageBoxEx.Show("No se ha actualizado, posiblemente exista un registro con el mismo nombre.");
            }
            else
            {
                try
                {
                    if (new Empresa_Distribuidora(new Tipo_Documento().SelectId(comboEXValide1.SelectedValue.ToString()), txNombre.Text, txNumDocumento.Text, pbImagen.Tag == null ? null : pbImagen.Image).Insert() > 0)
                    {
                        MessageBoxEx.Show("Registro satisfactorio");
                        Restablecer();
                        return;
                    }
                }
                catch { }
                MessageBoxEx.Show("No se ha insertado, posiblemente exista un registro con el mismo nombre.");
            }
            txNombre.Focus();
        }

        private void txNombre_UserGo(object sender, EventArgs e)
        {
            if (txNombre.IsCorrect())
            {
                txNumDocumento.Focus();
            }
        }

        private void bnBorrar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                if (MessageBoxEx.Show("La Marca seleccionada será enviada a la papelera y los productos relacionados dejarán de mostrarse.\n¿Deseas continuar?", "Reciclar",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (new Empresa_Distribuidora(Id, false).Update_Estado() > 0)
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
            comboEXValide1.SelectedItem = new Tipo_Documento().Select(Convert.ToInt64(pSelect[1]))[1].ToString();
            txNombre.Text = lbMarca.Text = pSelect[2].ToString();
            txNumDocumento.Text = pSelect[3].ToString();
            if (pSelect[4].ToString() != "")
            {
                pbImagen.Image = AccionesSistema.ObtenerImagen(pSelect[4]);
            }
            else
            {
                pbImagen.Image = Resources.EmpresaD;
            }
            bnBorrar.Enabled = true;
        }

        private void bnPapelera_Click(object sender, EventArgs e)
        {
            try
            {
                ((Form)Parent.Parent).Opacity = 0;
            }
            catch { }
            new frmReciclajeEmpresaDistribuidora().ShowDialog();
            crtlBuscar.Buscar();
            try
            {
                ((Form)Parent.Parent).Opacity = 1;
            }
            catch { }
        }

        private void comboEXValide1_UserGo(object sender, EventArgs e)
        {
            txNumDocumento.Focus();
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            AccionesSistema.DialogoImagen((Id<=0 ? "Nuevo" : "Modificar") + " Empresa Distribuidora", pbImagen);
        }

        private void bnEditTipoDocumento_Click(object sender, EventArgs e)
        {
            new frmTipoDocumento().ShowDialog();
            Cargar();
        }
    }
}
