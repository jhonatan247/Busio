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
    public partial class frmOpcionesSeleccionPapelera : MetroForm
    {
        AccionesSeleccionPapelera accion = AccionesSeleccionPapelera.Cancelar;
        public AccionesSeleccionPapelera Accion
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
        public frmOpcionesSeleccionPapelera()
        {
            InitializeComponent();
        }
        public AccionesSeleccionPapelera MostrarDialogo()
        {
            ShowDialog();
            return Accion;
        }
        private void bnMostrarDetalle_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccionPapelera.Recuparar;
        }

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccionPapelera.Eliminar;
        }

        private void bnCopiar_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccionPapelera.Copiar;
        }
        private void bnVerListaCompleta_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccionPapelera.RecuperarTodos;
        }

        private void bnMostrarVarios_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccionPapelera.VaciarPapelera;
        }

        private void bnGaleria_Click(object sender, EventArgs e)
        {
            Accion = AccionesSeleccionPapelera.Galeria;
        }
    }
    public enum AccionesSeleccionPapelera
    {
        Cancelar,
        Recuparar,
        RecuperarTodos,
        Eliminar,
        VaciarPapelera,
        Copiar,
        Galeria
    }
}
