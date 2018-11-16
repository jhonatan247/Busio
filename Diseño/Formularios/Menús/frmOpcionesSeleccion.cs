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
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmOpcionesSeleccion : MetroForm
    {
        AccionesSeleccion accion = AccionesSeleccion.Cancelar;
        public AccionesSeleccion Accion
        {
            get
            {
                return accion;
            }
            set
            {
                accion = value;
                Close();
            }
        }
        public frmOpcionesSeleccion()
        {
            InitializeComponent();
        }
        public AccionesSeleccion MostrarDialogo()
        {
            ShowDialog();
            return Accion;
        }

        private void bnMostrarDetalle_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.MostrarDetalle;
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Enviar;
        }

        private void bnImprimir_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Imprimir;
        }

        private void bnGenerarEtiqueta_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.GenerarEtiqueta;
        }

        private void bnCopiar_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Copiar;
        }

        private void bnExportar_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Exportar;
        }

        private void bnAplicarPromocion_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.AplicarPromocion;
        }

        private void bnModificar_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Modificar;
        }

        private void bnBorrar_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Borrar;
        }

        private void bnVerListaCompleta_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.VerListaCompleta;
        }

        private void bnMostrarVarios_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.MostrarVarios;
        }

        private void bnGenerarReporte_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Reportar;
        }

        private void bnGenerarEstadistica_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Graficar;
        }

        private void bnCompartirVarios_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.CompartirVarios;
        }

        private void bnGaleria_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.Galeria;
        }

        private void bnAgregarProductos_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.AgregarProductos;
        }

        private void bnModificacionRapida_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.ModificacionRapida;
        }

        private void bnEliminacionRapida_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccion.EliminacionRapida;
        }
    }
    public enum AccionesSeleccion
    {
        Cancelar,
        MostrarDetalle,
        Enviar,
        Imprimir,
        GenerarEtiqueta,
        Copiar,
        Exportar,
        AplicarPromocion,
        Modificar,
        Borrar,
        VerListaCompleta,
        MostrarVarios,
        Reportar,
        Graficar,
        CompartirVarios,
        Galeria,
        AgregarProductos,
        ModificacionRapida,
        EliminacionRapida

    }
}
