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
using Presentacion.Vistas;
using Negocio.Lógica;
using ProfessionalTicket;
using Negocio.Manejo_de_datos;
using DevComponents.DotNetBar.Metro;

namespace Presentacion.Formularios
{
    public partial class frmInicio : MetroAppForm
    {
        public static bool ventas = true;
        public static double DineroEnCaja { get; set; }
        public frmInicio(DataRow pPermisos)
        {
            AccionesSistema.Id_permisos = Convert.ToInt64(pPermisos[0]);
            AccionesSistema.Id_usuario = Convert.ToInt64(pPermisos[1]);
            AccionesSistema.Id_sucursal = Convert.ToInt64(pPermisos[2]);
            if (Settings.Default.Caja > 0 && Convert.ToBoolean(pPermisos[3]))
            {
                DineroEnCaja = new frmDineroInicial().get();
            }
            else
            {
                ventas = false;
            }
            InitializeComponent();
            snvVender.Visible = ventas;
            snvProductos.Visible = Convert.ToBoolean(pPermisos[4]);
            snvServicios.Visible = Convert.ToBoolean(pPermisos[5]);
            snvClientes.Visible = Convert.ToBoolean(pPermisos[6]);
            snvProveedores.Visible = Convert.ToBoolean(pPermisos[7]);
            snvCorte.Visible = Convert.ToBoolean(pPermisos[8]);
            snvInventario.Visible = Convert.ToBoolean(pPermisos[9]);
            snvPedidos.Visible = Convert.ToBoolean(pPermisos[10]);
            snvEstadisticas.Visible = Convert.ToBoolean(pPermisos[11]);
            snvHerramientas.Visible = Convert.ToBoolean(pPermisos[12]);
            snvConfiguracion.Visible = Convert.ToBoolean(pPermisos[13]);
        }

        public frmInicio()
        {
            if (Settings.Default.Caja > 0)
            {
                frmDineroInicial fDinero = new frmDineroInicial();
                fDinero.ShowDialog();
                DineroEnCaja = fDinero.Value;
            }
            else
            {
                ventas = false;
            }
            InitializeComponent();
            snvVender.Visible = ventas;
        }

        /*string ObtenerDiaSemana(DayOfWeek d)
        {
            switch (d)
            {
                case DayOfWeek.Monday:
                    return "Lunes";
                case DayOfWeek.Tuesday:
                    return "Martes";
                case DayOfWeek.Wednesday:
                    return "Miércoles";
                case DayOfWeek.Thursday:
                    return "Jueves";
                case DayOfWeek.Friday:
                    return "Viernes";
                case DayOfWeek.Saturday:
                    return "Sábado";
                case DayOfWeek.Sunday:
                    return "Domingo";
            }
            return "";
        }
        

        private void tFecha_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            string[] mes = {"Enero", "Febrero", "Marzo", "Abril",
                "Mayo","Junio", "Julio", "Agosto", "Septiembre",
                "Octubre", "Noviembre", "Diciembre"};
            lbFecha.Text = ObtenerDiaSemana(t.DayOfWeek)+", "+(t.Day > 9 ? "" + t.Day : "0" + t.Day) + " de " + mes[t.Month - 1] + " del " + t.Year + 
                "     " + (t.Hour > 9 ? "" + t.Hour : "0" + t.Hour) + ':' + (t.Minute > 9 ? "" + t.Minute : "0" + t.Minute) + 
                ':' + (t.Second > 9 ? "" + t.Second : "0" + t.Second);
           
        }*/

      

        private void frmInicio_Load(object sender, EventArgs e)
        {
            comboBoxEx1.Items.AddRange(new object[] { "Claro", "Oscuro", "Naranja", "Moderno"});
            try
            {
                comboBoxEx1.SelectedIndex = Settings.Default.Diseño;
            }
            catch
            {
                comboBoxEx1.SelectedIndex = 0;
            }
            sideNav1.SelectedItem = snvVender;
            pnlVender.BringToFront();
            tLoad.Start();
        }

        private void tLoad_Tick(object sender, EventArgs e)
        {
            Opacity += 0.02D;
            if (Opacity >= 1D)
                tLoad.Stop();
        }
        

        private void superTabItem4_Click(object sender, EventArgs e)
        {
            crtlBuscarProductoBuscar.Buscar();
            crtlBuscarProductoBuscar.Show();
        }

        private void crtlBuscarProductoActualizar_AccionSeleccionar(DataRow pSelect)
        {
            crtlBuscarProductoActualizar.Hide();
            crtlProductoActualizar.Identidad = new Usuario.BuscadorProducto(new Sucursal().SelectId(pSelect[1].ToString()), Convert.ToInt64(pSelect[0]));
            crtlProductoActualizar.Show();
        }

        private void crtlProductoActualizar_AccionBuscar()
        {
            crtlProductoActualizar.Hide();
            crtlBuscarProductoActualizar.Buscar();
            crtlBuscarProductoActualizar.Show();
        }

        private void superTabItem6_Click(object sender, EventArgs e)
        {
            crtlBuscarProductoEliminar.Buscar();
            crtlBuscarProductoEliminar.Show();
        }

        private void crtlBuscarProductoEliminar_AccionSeleccionar(DataRow pSelect)
        {
            crtlProductoNuevo.Borrar(Convert.ToInt64(pSelect[0]));
            crtlBuscarProductoEliminar.Buscar();
        }

        private void crtlBuscarProductoPapelera_AccionSeleccionar(DataRow pSelect)
        {
            switch (new frmOpcionesSeleccionPapelera().MostrarDialogo())
            {
                case AccionesSeleccionPapelera.Recuparar:
                    if (new Producto(Convert.ToInt64(pSelect[0]), true).Update_Estado() <1 )
                        MessageBox.Show("Ha ocurrido un error");
                    break;
                case AccionesSeleccionPapelera.Eliminar:
                    if (MessageBoxEx.Show("El elemento seleccionado se eliminará permantentemente.\n¿Desea continuar?", "Eliminar",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                        if (new Producto().Delete(Convert.ToInt64(pSelect[0])) < 1)
                            MessageBox.Show("Ha ocurrido un error");
                    break;
                case AccionesSeleccionPapelera.Copiar:
                    break;
                case AccionesSeleccionPapelera.RecuperarTodos:
                    if (MessageBoxEx.Show("Todos los elementos de la papelera serán recuperados.\n¿Desea continuar?", "Recuperar",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if(new Producto(true).UpdateAll_Estado() <1)
                            MessageBox.Show("Ha ocurrido un error");
                    }
                    break;
                case AccionesSeleccionPapelera.VaciarPapelera:
                    if (MessageBoxEx.Show("Todos los elementos de la papelera serán eliminados permantentemente.\n¿Desea continuar?", "Vaciar papelera", 
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (new Producto().DeleteAll() > 0)
                            MessageBox.Show("Ha ocurrido un error");
                    }
                    break;
                case AccionesSeleccionPapelera.Galeria:
                    break;
            }
            crtlBuscarProductoPapelera.Buscar();
        }

        private void superTabItem5_Click(object sender, EventArgs e)
        {
            crtlBuscarProductoPapelera.Buscar();
            crtlBuscarProductoPapelera.Show();
        }

        

        private void comboBoxEx1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEx1.SelectedItem == null) return;
            eStyle style = (eStyle)(10+comboBoxEx1.SelectedIndex);
            if (styleManager1.ManagerStyle != style)
            {
                styleManager1.ManagerStyle = style;
            }
            if (comboBoxEx1.SelectedIndex != Settings.Default.Diseño)
            {

                Settings.Default.Diseño = comboBoxEx1.SelectedIndex;
                Settings.Default.Save();
                MessageBoxEx.Show("Te recomendamos reiniciar el programa para aplicar los cambios completamente", "Cambio de estilo");
            }
        }

        private void bnSalir_Click(object sender, EventArgs e)
        {
            frmCerrarTurno fCerrar = new frmCerrarTurno();
            Enabled = false;
            fCerrar.ShowDialog();
            Enabled = true;
            if (fCerrar.DialogResult == DialogResult.OK)
            {
                if (ventas)
                {
                    frmDineroFinal fDFinal = new frmDineroFinal(DineroEnCaja);
                    if (fDFinal.ShowDialog() == DialogResult.OK)
                    {
                        Application.Restart();
                    }
                }
                else
                {
                    Application.Restart();
                }
            }
            if (fCerrar.DialogResult == DialogResult.Abort)
            {
                if (ventas)
                {
                    frmDineroFinal fDFinal = new frmDineroFinal(DineroEnCaja);
                    if (fDFinal.ShowDialog() == DialogResult.OK)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else if (fCerrar.DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void bnDiseñoElegirColor_Click(object sender, EventArgs e)
        {
        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.Bloquear = switchButton1.Value;
            Settings.Default.Save();
        }

        private void snvVender_Click(object sender, EventArgs e)
        {
            crtVender1.Fucus();
        }

        private void crtlBuscarProductoBuscar_AccionSeleccionar(DataRow pSelect)
        {
            switch(new frmOpcionesSeleccion().MostrarDialogo())
            {
                case AccionesSeleccion.MostrarDetalle:
                    new frmView(new viewProducto(new Producto().SelectVista(new Sucursal().SelectId(pSelect[1].ToString()), Convert.ToInt64(pSelect[0])))).ShowDialog();
                    break;
                case AccionesSeleccion.Reportar:
                    new Reportes.frmReporteProducto().ShowDialog();
                    break;
                case AccionesSeleccion.AgregarProductos:
                    new frmProducto().ShowDialog();
                    break;
                case AccionesSeleccion.Modificar:
                    new frmProducto().ShowDialog();
                    break;
                case AccionesSeleccion.Borrar:
                    crtlProductoNuevo.Borrar(Convert.ToInt64(pSelect[0]));
                    break;
            }
            crtlBuscarProductoBuscar.Buscar();
        }
        

        private void tabProductoActualizar_Click(object sender, EventArgs e)
        {
            crtlProductoActualizar_AccionBuscar();
        }

        private void tabProductoNuevo_Click(object sender, EventArgs e)
        {
            crtlProductoNuevo.Cargar();
            crtlProductoNuevo.Show();
        }

        private void tabProductoMarcas_Click(object sender, EventArgs e)
        {
            crtlMarcaProducto.Restablecer();
            crtlMarcaProducto.Show();
        }

        private void tabProductoPresentaciones_Click(object sender, EventArgs e)
        {
            crtlPresentacionProducto.Restablecer();
            crtlPresentacionProducto.Show();
        }

        private void tabProductosCategorias_Click(object sender, EventArgs e)
        {
            crtlCategoriaProducto.Restablecer();
            crtlCategoriaProducto.Show();
        }

        private void tabProductosUnidadMedida_Click(object sender, EventArgs e)
        {
            crtlUnidadMedidaProducto.Restablecer();
            crtlUnidadMedidaProducto.Show();
        }

        private void tabProductoEmpresaDistribuidora_Click(object sender, EventArgs e)
        {
            crtlEmpresaDistribuidoraProducto.Restablecer();
            crtlEmpresaDistribuidoraProducto.Show();
        }

        private void tabClienteNuevo_Click(object sender, EventArgs e)
        {
            crtlCliente1.Cargar();
            crtlCliente1.Show();
        }

        private void superTabProductos_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            ((SuperTabControl)sender).SelectedTab.Focus();
        }
    }
}
