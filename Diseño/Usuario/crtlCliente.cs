using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Manejo_de_datos;
using Negocio.Lógica;
using DevComponents.DotNetBar.Controls;
using DevComponents.DotNetBar;
using Presentacion.Properties;
using Presentacion.Controles;
using Presentacion.Formularios;

namespace Presentacion.Usuario
{
    public partial class crtlCliente : UserControl
    {
        bool accion = true;
        long id = 0;
        
        public long Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                if (id != 0)
                {
                    Cargar();
                    DataRow Drow = null;
                    try
                    {
                        Drow = new Cliente().Select(id);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    SuspendLayout();
                    cbTipoDocumento.SelectedItem = new Tipo_Documento().Select(Convert.ToInt64( Drow[1] ))[1].ToString();
                    txNombres.Text = Drow[2].ToString();
                    txApellidos.Text = Drow[3].ToString();
                    cbSexo.SelectedItem = Drow[4].ToString();
                    txNumeroDocumento.Text = Drow[5].ToString();
                    txCorreo.Text = Drow[6].ToString();
                    txTelefono.Text = Drow[7].ToString();
                    txDireccion.Text = Drow[8].ToString();
                    txLimiteCredito.Text = Drow[9].ToString();
                    dtmFechaNacimiento.Value = Convert.ToDateTime(Drow[10].ToString());
                    ResumeLayout();
                }
            }
        }
        public bool Accion
        {
            get
            {
                return accion;
            }
            set
            {
                accion = value;

                SuspendLayout();
                if (accion) {
                    bnActualizar.Visible = bnBorrar.Visible = bnBuscar.Visible = false;
                    bnGuardar.Visible = true;
                    lbTitulo.Text = "  Nuevo Cliente";
                }
                else
                {
                    bnActualizar.Visible = bnBorrar.Visible = bnBuscar.Visible = true;
                    bnGuardar.Visible = false;
                    lbTitulo.Text = "  Modificar Cliente";
                }
                ResumeLayout();
            }
        }

        #region Delegados
        public delegate void AccionDelegate();
        #endregion
        #region Eventos
        public event AccionDelegate AccionBuscar;
        public event AccionDelegate AccionEliminar;
        #endregion

        public crtlCliente()
        {
            InitializeComponent();
        }
        public bool Borrar(long pId)
        {
            try
            {
                if (pId > 0 && new Cliente(pId, false).Update_Estado() > 0)
                {
                    MessageBoxEx.Show("Borrado");
                    return true;
                }
            }
            catch { }
            MessageBoxEx.Show("Error al borrar");
            return false;
        }
        public bool Validar()
        {
            foreach (TextBoxExValide tx in Controls.OfType<TextBoxExValide>())
            {
                if (!tx.IsCorrect())
                    return false;
            }
            return true;
        }
        public void Limpiar()
        {
            id = 0;
            List<int> index = new List<int>();
            foreach (ComboBoxEx cb in Controls.OfType<ComboBoxEx>())
                index.Add(cb.SelectedIndex);
            Cargar();
            int i = 0;
            foreach (ComboBoxEx cb in Controls.OfType<ComboBoxEx>())
            {
                try { cb.SelectedIndex = index[i]; }
                catch { cb.SelectedIndex = 0; }
                i++;
            }
            foreach (TextBoxX tx in Controls.OfType<TextBoxX>())
                tx.Text = "";
            txLimiteCredito.Text = "0,00";
            InitFocus();
        }
        public void InitFocus()
        {
            txNombres.Focus();
        }
        public void Cargar()
        {
            cbSexo.DataSource = AccionesSistema.SelectSexo();
            cbTipoDocumento.DataSource = new Tipo_Documento().SelectAllPersona();
            InitFocus();
        }
        public void Guardar()
        {
            try
            {
                if (new Cliente(new Tipo_Documento().SelectId(cbTipoDocumento.SelectedValue.ToString()), txNombres.Text,txApellidos.Text,
                    cbSexo.SelectedText, txNumeroDocumento.Text, txCorreo.Text, txTelefono.Text, txDireccion.Text, Convert.ToDouble(txLimiteCredito.Text), dtmFechaNacimiento.Value).Insert() > 0)
                {
                    MessageBoxEx.Show("Se ha insertado correctamente");
                    Limpiar();
                    return;
                }
            }
            catch(Exception es)
            {
                MessageBox.Show(es.ToString());
            }

            MessageBoxEx.Show("No se ha insertado");
        }
        public void Actualizar()
        {
            try
            {
                if (id > 0 && new Cliente(id, new Tipo_Documento().SelectId(cbTipoDocumento.SelectedValue.ToString()), txNombres.Text, txApellidos.Text,
                    cbSexo.SelectedText, txNumeroDocumento.Text, txCorreo.Text, txTelefono.Text, txDireccion.Text, Convert.ToDouble(txLimiteCredito.Text), dtmFechaNacimiento.Value, true).Update() > 0)
                {
                    MessageBoxEx.Show("Se ha actualizado correctamente");
                    return;
                }
            }
            catch
            {
            }

            MessageBoxEx.Show("No se ha actualizado", "Error");
        }

        private void bnGuardar_Click(object sender, EventArgs e)
        {
            if(Validar())
                Guardar();
        }

        private void bnActualizar_Click(object sender, EventArgs e)
        {
            if(Validar())
                Actualizar();
        }

        private void bnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void bnBorrar_Click(object sender, EventArgs e)
        {
            if (Borrar(id))
            {
                AccionEliminar();
            }
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            AccionBuscar();
        }

        private void txCodigoBarras_UserGo(object sender, EventArgs e)
        {

            try
            {
                if (!((TextBoxExValide)sender).IsCorrect())
                {
                    return;
                }
            }
            catch { }
            try
            {
                string crt = ((Control)sender).Tag.ToString();
                while (true) {
                    if (Controls[crt].Enabled)
                    {
                        Controls[crt].Focus();
                        break;
                    }
                    else
                    {
                        crt = Controls[crt].Tag.ToString();
                    }
                }
            }
            catch
            {
            }
        }

        private void Finalizar_UserGo(object sender, EventArgs e)
        {
            if (accion)
            {
                bnGuardar.PerformClick();
            }
            else
                bnActualizar.PerformClick();
        }

        private void bnEditEmpresaDistribuidora_Click(object sender, EventArgs e)
        {
            new frmTipoDocumento().ShowDialog();
            Cargar();
        }
    }
}
