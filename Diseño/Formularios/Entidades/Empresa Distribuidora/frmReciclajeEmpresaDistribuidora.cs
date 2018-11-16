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
using Negocio.Manejo_de_datos;
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmReciclajeEmpresaDistribuidora : MetroForm
    {
        public frmReciclajeEmpresaDistribuidora()
        {
            InitializeComponent();
            crtlBuscarMarca1.Buscar();
        }

        private void crtlBuscarMarca1_AccionSeleccionar(DataRow pSelect)
        {
            switch (new frmOpcionesSeleccionPapelera().MostrarDialogo())
            {
                case AccionesSeleccionPapelera.Recuparar:
                    if(new Marca(Convert.ToInt64(pSelect[0]), true).Update_Estado() < 1)
                        MessageBox.Show("Ha ocurrido un error");
                    break;
                case AccionesSeleccionPapelera.Eliminar:
                    if (MessageBoxEx.Show("El elemento seleccionado se eliminará permantentemente y los objetos relacionados volverán a mostrarse con el valor por defecto.\n¿Desea continuar?","Eliminar", 
                        MessageBoxButtons.OKCancel) == DialogResult.OK )
                        if(new Marca().Delete(Convert.ToInt64(pSelect[0])) < 1)
                            MessageBox.Show("Ha ocurrido un error");
                    break;
                case AccionesSeleccionPapelera.Copiar:
                    break;
                case AccionesSeleccionPapelera.RecuperarTodos:
                    if (MessageBoxEx.Show("Todos los elementos de la papelera serán recuperados.\n¿Desea continuar?", "Recuperar", 
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (new Marca(true).UpdateAll_Estado() > 0)
                        {
                            Close();
                        }
                        else
                            MessageBox.Show("Ha ocurrido un error");
                    }
                    break;
                case AccionesSeleccionPapelera.VaciarPapelera:
                    if (MessageBoxEx.Show("Todos los elementos de la papelera serán eliminados permantentemente y los objetos relacionados volverán a mostrarse con el valor por defecto.\n¿Desea continuar?", "Vaciar papelera", 
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (new Marca().DeleteAll() > 0)
                        {
                            Close();
                        }
                        else
                            MessageBox.Show("Ha ocurrido un error");
                    }
                    break;
                case AccionesSeleccionPapelera.Galeria:
                    break;
            }
            crtlBuscarMarca1.Buscar();
        }
    }
}
