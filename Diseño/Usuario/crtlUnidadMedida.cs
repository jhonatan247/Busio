﻿using System;
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
    public partial class crtlUnidadMedida : UserControl
    {
        long Id = 0;
        public crtlUnidadMedida()
        {
            InitializeComponent();
        }
        public void Restablecer()
        {
            lbMarca.Text = "NUEVA UNIDAD DE MEDIDA";
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
                    if (new Unidad_Medida(Id, txNombre.Text, txPrefijo.Text, true).Update() > 0)
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
                    if (new Unidad_Medida(txNombre.Text, txPrefijo.Text).Insert() > 0)
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
                txPrefijo.Focus();
            }
        }

        private void bnBorrar_Click(object sender, EventArgs e)
        {
            if (Id > 0)
            {
                if (MessageBoxEx.Show("La Unidad de Medida seleccionada será enviada a la papelera y los productos relacionados dejarán de mostrarse.\n¿Deseas continuar?", "Reciclar",
                    MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (new Unidad_Medida(Id, false).Update_Estado() > 0)
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
            bnBorrar.Enabled = true;
        }

        private void bnPapelera_Click(object sender, EventArgs e)
        {
            try
            {
                ((Form)Parent.Parent).Opacity = 0;
            }
            catch { }
            new frmReciclajeUnidadMedida().ShowDialog();
            crtlBuscar.Buscar();
            try
            {
                ((Form)Parent.Parent).Opacity = 1;
            }
            catch { }
        }
    }
}
