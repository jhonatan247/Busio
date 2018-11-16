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
    public partial class crtlProducto : UserControl
    {
        bool accion = true;
        long id = 0, Idsucursal = 0;
        
        public BuscadorProducto Identidad
        {
            get
            {
                return new BuscadorProducto(Idsucursal, id);
            }
            set
            {
                id = value.Id_Producto;
                Idsucursal = value.Id_Sucursal;
                if (id != 0)
                {
                    Cargar();
                    DataRow Drow = null;
                    try
                    {
                        Drow = new Producto().SelectVista(Idsucursal, id);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    SuspendLayout();
                    //id = Convert.ToInt64(Drow[0].ToString());
                    //Idsucursal = new Sucursal().SelectId(Drow[1].ToString());
                    cbEmpresaDistribuidora.SelectedItem = Drow[2].ToString();
                    cbMarca.SelectedItem = Drow[3].ToString();
                    cbPresentacion.SelectedItem = Drow[4].ToString();
                    cbCategoria.SelectedItem = Drow[5].ToString();
                    cbUnidadMedida.SelectedItem = Drow[6].ToString();
                    txCodigoBarras.Text = Drow[8].ToString();
                    txNombraAcortado.Text = Drow[9].ToString();
                    txDescripcion.Text = Drow[10].ToString();
                    if (Drow[11].ToString() != "")
                    {
                        pbImagen.Image = AccionesSistema.ObtenerImagen(Drow[11]);
                    }
                    else
                    {
                        pbImagen.Image = Resources.producto;
                    }
                    txPrecioCompra.Text = Drow[12].ToString();
                    ChequearPorcentajes();
                    txImpuestoAplicado.Text = Drow[7].ToString();
                    txGananciaAlDetalPorcentaje.Text = Drow[13].ToString();
                    txGananciaAlMayorPorcentaje.Text = Drow[14].ToString();
                    txGananciaMinimaPorcentaje.Text = Drow[15].ToString();
                    chImpuestoIncluido.Checked = Convert.ToBoolean(Drow[16].ToString());
                    chManejaInventario.Checked = Convert.ToBoolean(Drow[17].ToString());
                    txInventarioMinimo.Text = Drow[18].ToString();
                    txInventarioCantidad.Text = Drow[19].ToString();
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
                    lbTitulo.Text = "  Nuevo Producto";
                }
                else
                {
                    bnActualizar.Visible = bnBorrar.Visible = bnBuscar.Visible = true;
                    bnGuardar.Visible = false;
                    lbTitulo.Text = "  Modificar Producto";
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

        public crtlProducto()
        {
            InitializeComponent();
        }
        public bool Borrar(long pId)
        {
            try
            {
                if (pId > 0 && new Producto(pId, false).Update_Estado() > 0)
                    return true;
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
            foreach(TextBoxExValide tx in gbGananciaAlDetal.Controls.OfType<TextBoxExValide>())
            {
                if (!tx.IsCorrect())
                    return false;
            }
            return true;
        }
        void CalcularPorcentajes()
        {
            decimal
                    valor = Convert.ToDecimal(txPrecioCompra.Text),
                    gananciaNorm = Convert.ToDecimal(txGananciaAlDetalPorcentaje.Text),
                    dineroNorm = valor * gananciaNorm / 100,
                    gananciaMayor = Convert.ToDecimal(txGananciaAlMayorPorcentaje.Text),
                    dineroMayor = valor * gananciaMayor / 100,
                    gananciaMinim = Convert.ToDecimal(txGananciaMinimaPorcentaje.Text),
                    dineroMinim = valor * gananciaMinim / 100,
                    impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                    totalNorm = Math.Round(valor + dineroNorm, 2),
                    valorImpuestoNorm = totalNorm * impuesto / 100,
                    totalMayor = Math.Round(valor + dineroMayor, 2),
                    valorImpuestoMayor = totalMayor * impuesto / 100,
                    totalMinim = Math.Round(valor + dineroMinim, 2),
                    valorImpuestoMinim = totalMinim * impuesto / 100;

            bool imp = chImpuestoIncluido.Checked;
            ChequearPorcentajes();

            txGananciaAlDetalDinero.Text = Math.Round(dineroNorm, 2).ToString();
            txGananciaAlMayorDinero.Text = Math.Round(dineroMayor, 2).ToString();
            txGananciaMinimaDinero.Text = Math.Round(dineroMinim, 2).ToString();
            txGananciaAlDetalTotal.Text = (imp ? totalNorm.ToString() : (totalNorm + valorImpuestoNorm).ToString());
            txGananciaAlMayorTotal.Text = (imp ? totalMayor.ToString() : (totalMayor + valorImpuestoMayor).ToString());
            txGananciaMinimaTotal.Text = (imp ? totalMinim.ToString() : (totalMinim + valorImpuestoMinim).ToString());
        }
        void ChequearPorcentajes()
        {
            chGananciaAlDetalPorcentaje_Click(chGananciaAlDetalPorcentaje, new EventArgs());
            chGananciaAlDetalPorcentaje_Click(chGananciaAlMayorPorcentaje, new EventArgs());
            chGananciaAlDetalPorcentaje_Click(chGananciaMinimaPorcentaje, new EventArgs());
        }
        void CambiarImagen(PictureBox pbImagen)
        {
            AccionesSistema.DialogoImagen((accion ? "Nuevo" : "Modificar") + " Producto", pbImagen);
        }
        public void Limpiar()
        {
            id = 0;
            ChequearPorcentajes();
            //txGananciaAlDetalPorcentaje.Value = txGananciaAlMayorPorcentaje.Value = txGananciaMinimaPorcentaje.Value = 0;
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
            txPrecioCompra.Text = txInventarioCantidad.Text = txInventarioMinimo.Text = "0,00";
            /*chImpuestoIncluido.Checked = chGananciaAlDetal.Checked =
                chGananciaAlMayor.Checked = chGananciaMinima.Checked = chManejaInventario.Checked = true;*/
            pbImagen.Image = Resources.producto;
            pbImagen.Tag = null;
            InitFocus();
        }
        public void InitFocus()
        {
            txCodigoBarras.Focus();
        }
        public void Cargar()
        {
            if(accion && AccionesSistema.Id_sucursal == 0)
            {
                lbSucursal.Visible = cbSucursal.Visible = true;
                cbSucursal.DataSource = new Sucursal().SelectAll();
            }
            else
            {
                lbSucursal.Visible = cbSucursal.Visible = false;
            }
            cbEmpresaDistribuidora.DataSource = new Empresa_Distribuidora().SelectAll();
            cbCategoria.DataSource = new Categoria().SelectAll();
            cbMarca.DataSource = new Marca().SelectAll();
            cbPresentacion.DataSource = new Negocio.Manejo_de_datos.Presentacion().SelectAll();
            cbUnidadMedida.DataSource = new Unidad_Medida().SelectAll();
            InitFocus();
        }
        public void Guardar()
        {
            try
            {
                Idsucursal = (cbSucursal.Visible ? new Sucursal().SelectId(cbSucursal.SelectedValue.ToString()):AccionesSistema.Id_sucursal);
                if (new Producto(new Empresa_Distribuidora().SelectId(cbEmpresaDistribuidora.SelectedValue.ToString()), new Marca().SelectId(cbMarca.SelectedValue.ToString()),
                    new Negocio.Manejo_de_datos.Presentacion().SelectId(cbPresentacion.SelectedValue.ToString()),new Categoria().SelectId(cbCategoria.SelectedValue.ToString()), 
                    new Unidad_Medida().SelectId(cbUnidadMedida.SelectedValue.ToString()), txCodigoBarras.Text,
                    txNombraAcortado.Text, txDescripcion.Text, pbImagen.Tag == null ? null: pbImagen.Image, Convert.ToDouble(txPrecioCompra.Text),Convert.ToDouble(txImpuestoAplicado.Text), Convert.ToDouble(txGananciaAlDetalPorcentaje.Text),
                    Convert.ToDouble(txGananciaAlMayorPorcentaje.Text), Convert.ToDouble(txGananciaMinimaPorcentaje.Text),
            chImpuestoIncluido.Checked, chManejaInventario.Checked).InsertCompleto(new Inventario(Idsucursal, Convert.ToDouble(txInventarioMinimo.Text)), new Movimiento_Inventario(Convert.ToDouble(txInventarioCantidad.Text))) > 0)
                {
                    MessageBoxEx.Show("Se ha insertado correctamente");
                    Limpiar();
                    return;
                }
            }
            catch
            {
            }

            MessageBoxEx.Show("No se ha insertado");
        }
        public void Actualizar()
        {
            try
            {
                if (id > 0 && new Producto(id, new Empresa_Distribuidora().SelectId(cbEmpresaDistribuidora.SelectedValue.ToString()), new Marca().SelectId(cbMarca.SelectedValue.ToString()),
                    new Negocio.Manejo_de_datos.Presentacion().SelectId(cbPresentacion.SelectedValue.ToString()), new Categoria().SelectId(cbCategoria.SelectedValue.ToString()),
                    new Unidad_Medida().SelectId(cbUnidadMedida.SelectedValue.ToString()), txCodigoBarras.Text,
                    txNombraAcortado.Text, txDescripcion.Text, pbImagen.Tag == null ? null : pbImagen.Image, Convert.ToDouble(txPrecioCompra.Text), Convert.ToDouble(txImpuestoAplicado.Text), Convert.ToDouble(txGananciaAlDetalPorcentaje.Text),
                    Convert.ToDouble(txGananciaAlMayorPorcentaje.Text), Convert.ToDouble(txGananciaMinimaPorcentaje.Text),
            chImpuestoIncluido.Checked, chManejaInventario.Checked).Update_Completo(new Inventario(Idsucursal,Convert.ToDouble(txInventarioMinimo.Text)), new Movimiento_Inventario(Convert.ToDouble(txInventarioCantidad.Text))) > 0)
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
        private void chGananciaAlDetal_CheckedChanged(object sender, EventArgs e)
        {
            gbGananciaAlDetal.Enabled = chGananciaAlDetal.Checked;
            if (chGananciaAlDetal.Checked)
            {
                txGananciaAlDetalPorcentaje.Enabled = chGananciaAlDetalPorcentaje.Checked;
                txGananciaAlDetalDinero.Enabled = chGananciaAlDetalDinero.Checked;
                txGananciaAlDetalTotal.Enabled = chGananciaAlDetalTotal.Checked;
            }
            else
            {
                txGananciaAlDetalPorcentaje.Enabled = chGananciaAlDetalPorcentaje.Checked = true;
                txGananciaAlDetalDinero.Enabled = chGananciaAlDetalDinero.Checked =
                txGananciaAlDetalTotal.Enabled = chGananciaAlDetalTotal.Checked = false;
                txGananciaAlDetalPorcentaje.Text = "0,00";
            }

            gbGananciaAlMayor.Enabled = chGananciaAlMayor.Checked;
            if (chGananciaAlMayor.Checked)
            {
                txGananciaAlMayorPorcentaje.Enabled = chGananciaAlMayorPorcentaje.Checked;
                txGananciaAlMayorDinero.Enabled = chGananciaAlMayorDinero.Checked;
                txGananciaAlMayorTotal.Enabled = chGananciaAlMayorTotal.Checked;
            }
            else
            {
                txGananciaAlMayorPorcentaje.Enabled = chGananciaAlMayorPorcentaje.Checked = true;
                txGananciaAlMayorDinero.Enabled = chGananciaAlMayorDinero.Checked =
                txGananciaAlMayorTotal.Enabled = chGananciaAlMayorTotal.Checked = false;
                txGananciaAlMayorPorcentaje.Text = "0,00";
            }

            gbGananciaMinima.Enabled = chGananciaMinima.Checked;
            if (chGananciaMinima.Checked)
            {
                txGananciaMinimaPorcentaje.Enabled = chGananciaMinimaPorcentaje.Checked;
                txGananciaMinimaDinero.Enabled = chGananciaMinimaDinero.Checked;
                txGananciaMinimaTotal.Enabled = chGananciaMinimaTotal.Checked;
            }
            else
            {
                txGananciaMinimaPorcentaje.Enabled = chGananciaMinimaPorcentaje.Checked = false;
                txGananciaMinimaDinero.Enabled = chGananciaMinimaDinero.Checked =
                txGananciaMinimaTotal.Enabled = chGananciaMinimaTotal.Checked = false;
                txGananciaMinimaPorcentaje.Text = "0,00";
            }
        }
        private void chGananciaAlDetalPorcentaje_Click(object sender, EventArgs e)
        {
            foreach(CheckBoxX ch in ((Control)sender).Parent.Controls.OfType<CheckBoxX>())
            {
                ch.Checked = false;
            }
            ((CheckBoxX)sender).Checked = true;
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

        private void txPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcularPorcentajes();
            }
            catch
            {
                txPrecioCompra_Error();
            }
        }
        private void txPrecioCompra_Error()
        {
            decimal
                       ganancia = Convert.ToDecimal(txGananciaAlDetalPorcentaje.Text),
                       dinero = Convert.ToDecimal(txGananciaAlDetalDinero.Text),
                       valor = dinero*100/ganancia;
            txPrecioCompra.Text = Math.Round(valor, 2).ToString();
        }
        private void chGananciaAlDetalDinero_StyleChanged(object sender, EventArgs e)
        {
            
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            CambiarImagen((PictureBox)sender);
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
        private void chImpuestoIncluido_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }
        private void txGananciaAlDetalPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            if (chGananciaAlDetalPorcentaje.Checked)
            {
                decimal
                   valor = Convert.ToDecimal(txPrecioCompra.Text),
                   ganancia = Convert.ToDecimal(txGananciaAlDetalPorcentaje.Text),
                   dinero = valor * ganancia / 100,
                   impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                   total = Math.Round(valor + dinero, 2),
                   valorImpuesto = total * impuesto / 100;

                bool imp = chImpuestoIncluido.Checked;

                txGananciaAlDetalDinero.Text = Math.Round(dinero, 2).ToString();
                txGananciaAlDetalTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
            }
        }
        private void txGananciaAlDetalDinero_TextChanged(object sender, EventArgs e)
        {
            if (chGananciaAlDetalDinero.Checked)
            {
                try
                {
                    decimal
                       valor = Convert.ToDecimal(txPrecioCompra.Text),
                       dinero = Convert.ToDecimal(txGananciaAlDetalDinero.Text),
                       ganancia = dinero * 100 / valor,
                       impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                       total = Math.Round(valor + dinero, 2),
                       valorImpuesto = total * impuesto / 100;

                    bool imp = chImpuestoIncluido.Checked;

                    txGananciaAlDetalPorcentaje.Text = ganancia.ToString();
                    txGananciaAlDetalTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
                }
                catch
                {
                    txGananciaAlDetalDinero_Error();
                }
            }
        }
        private void txGananciaAlDetalDinero_Error()
        {
            decimal
                       valor = Convert.ToDecimal(txPrecioCompra.Text),
                       ganancia = Convert.ToDecimal(txGananciaAlDetalPorcentaje.Text),
                       dinero = valor * ganancia / 100;
            txGananciaAlDetalDinero.Text = Math.Round(dinero, 2).ToString();
        }
        private void txGananciaAlDetalTotal_TextChanged(object sender, EventArgs e)
        {
            if (chGananciaAlDetalTotal.Checked)
            {
                try
                {
                    bool imp = chImpuestoIncluido.Checked;
                    decimal
                       valor = Convert.ToDecimal(txPrecioCompra.Text),
                       impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                       totalTemp = Convert.ToDecimal(txGananciaAlDetalTotal.Text),
                       valorImpuesto = totalTemp * impuesto / 100,
                       total = (imp ? totalTemp : totalTemp - valorImpuesto),
                       dinero = valor - total,
                       ganancia = dinero * 100 / valor;

                    txGananciaAlDetalPorcentaje.Text = ganancia.ToString(); ;
                    txGananciaAlDetalDinero.Text = dinero.ToString();
                }
                catch
                {
                    txGananciaAlDetalTotal_Error();
                }
            }
        }
        private void txGananciaAlDetalTotal_Error()
        {
            decimal
               valor = Convert.ToDecimal(txPrecioCompra.Text),
               dinero = Convert.ToDecimal(txGananciaAlDetalDinero.Text),
               impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
               total = Math.Round(valor + dinero, 2),
               valorImpuesto = total * impuesto / 100;

            bool imp = chImpuestoIncluido.Checked;

            txGananciaAlDetalTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
        }
        private void txGananciaAlMayorPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            if (chGananciaAlMayorPorcentaje.Checked)
            {
                Decimal
                   valor = Convert.ToDecimal(txPrecioCompra.Text),
                   ganancia = Convert.ToDecimal(txGananciaAlMayorPorcentaje.Text),
                   dinero = valor * ganancia / 100,
                   impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                   total = Math.Round(valor + dinero, 2),
                   valorImpuesto = total * impuesto / 100;

                bool imp = chImpuestoIncluido.Checked;
                
                txGananciaAlMayorDinero.Text = Math.Round(dinero, 2).ToString();
                txGananciaAlMayorTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
            }
        }
        private void txGananciaAlMayorDinero_TextChanged(object sender, EventArgs e)
        {
            if (chGananciaAlMayorDinero.Checked)
            {
                try
                {
                    decimal
                       valor = Convert.ToDecimal(txPrecioCompra.Text),
                       dinero = Convert.ToDecimal(txGananciaAlMayorDinero.Text),
                       ganancia = dinero * 100 / valor,
                       impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                       total = Math.Round(valor + dinero, 2),
                       valorImpuesto = total * impuesto / 100;

                    bool imp = chImpuestoIncluido.Checked;

                    txGananciaAlMayorPorcentaje.Text = ganancia.ToString();
                    txGananciaAlMayorTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
                }
                catch
                {
                    txGananciaAlMayorDinero_Error();
                }
            }
        }
        private void txGananciaAlMayorDinero_Error()
        {
            decimal
               valor = Convert.ToDecimal(txPrecioCompra.Text),
               ganancia = Convert.ToDecimal(txGananciaAlMayorPorcentaje.Text),
               dinero = valor * ganancia / 100;
            txGananciaAlMayorDinero.Text = Math.Round(dinero, 2).ToString();
        }
        private void txGananciaMinimaPorcentaje_ValueChanged(object sender, EventArgs e)
        {
            decimal
                   valor = Convert.ToDecimal(txPrecioCompra.Text),
                   ganancia = Convert.ToDecimal(txGananciaMinimaPorcentaje.Text),
                   dinero = valor * ganancia / 100,
                   impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                   total = Math.Round(valor + dinero, 2),
                   valorImpuesto = total * impuesto / 100;

            bool imp = chImpuestoIncluido.Checked;
                
                txGananciaMinimaDinero.Text = Math.Round(dinero, 2).ToString();
                txGananciaMinimaTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
            
        }
        private void txGananciaAlMayorTotal_TextChanged(object sender, EventArgs e)
        {
            if (chGananciaAlMayorTotal.Checked)
            {
                try
                {
                    bool imp = chImpuestoIncluido.Checked;
                    decimal
                       valor = Convert.ToDecimal(txPrecioCompra.Text),
                       impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                       totalTemp = Convert.ToDecimal(txGananciaAlMayorTotal.Text),
                       valorImpuesto = totalTemp * impuesto / 100,
                       total = (imp ? totalTemp : totalTemp - valorImpuesto),
                       dinero = valor - total,
                       ganancia = dinero * 100 / valor;

                    txGananciaAlMayorPorcentaje.Text = ganancia.ToString();
                    txGananciaAlMayorDinero.Text = dinero.ToString();
                }
                catch
                {
                }
            }
        }
        private void txGananciaAlMayorTotal_Error()
        {
            decimal
               valor = Convert.ToDecimal(txPrecioCompra.Text),
               dinero = Convert.ToDecimal(txGananciaAlMayorDinero.Text),
               impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
               total = Math.Round(valor + dinero, 2),
               valorImpuesto = total * impuesto / 100;

            bool imp = chImpuestoIncluido.Checked;

            txGananciaAlMayorTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
        }
        private void txGananciaMinimaDinero_TextChanged(object sender, EventArgs e)
        {
            if (chGananciaMinimaDinero.Checked)
            {
                try
                {
                    decimal
                       valor = Convert.ToDecimal(txPrecioCompra.Text),
                       dinero = Convert.ToDecimal(txGananciaMinimaDinero.Text),
                       ganancia = dinero * 100 / valor,
                       impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                       total = Math.Round(valor + dinero, 2),
                       valorImpuesto = total * impuesto / 100;

                    bool imp = chImpuestoIncluido.Checked;

                    txGananciaMinimaPorcentaje.Text = ganancia.ToString();
                    txGananciaMinimaTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
                }
                catch
                {
                    txGananciaMinimaDinero_Error();
                }
            }
        }
        private void txGananciaMinimaDinero_Error()
        {
            decimal
               valor = Convert.ToDecimal(txPrecioCompra.Text),
               ganancia = Convert.ToDecimal(txGananciaMinimaPorcentaje.Text),
               dinero = valor * ganancia / 100;
            txGananciaMinimaDinero.Text = Math.Round(dinero, 2).ToString();
        }

        private void txGananciaMinimaTotal_TextChanged(object sender, EventArgs e)
        {
            if (chGananciaMinimaTotal.Checked)
            {
                try
                {
                    bool imp = chImpuestoIncluido.Checked;
                    decimal
                       valor = Convert.ToDecimal(txPrecioCompra.Text),
                       impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
                       totalTemp = Convert.ToDecimal(txGananciaMinimaTotal.Text),
                       valorImpuesto = totalTemp * impuesto / 100,
                       total = (imp ? totalTemp : totalTemp - valorImpuesto),
                       dinero = valor- total,
                       ganancia = dinero * 100 / valor;

                    txGananciaMinimaPorcentaje.Text = ganancia.ToString();
                    txGananciaMinimaDinero.Text = dinero.ToString();
                }
                catch
                {
                    txGananciaMinimaTotal_Error();
                }
            }
        }
        private void txGananciaMinimaTotal_Error()
        {
            decimal
               valor = Convert.ToDecimal(txPrecioCompra.Text),
               dinero = Convert.ToDecimal(txGananciaMinimaDinero.Text),
               impuesto = Convert.ToDecimal(txImpuestoAplicado.Text),
               total = Math.Round(valor + dinero, 2),
               valorImpuesto = total * impuesto / 100;

            bool imp = chImpuestoIncluido.Checked;

            txGananciaMinimaTotal.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            AccionBuscar();
        }

        private void cbImpuestoAplicado_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        private void chManejaInventario_CheckedChanged(object sender, EventArgs e)
        {
            txInventarioCantidad.Enabled = txInventarioMinimo.Enabled = chManejaInventario.Checked;
            txInventarioCantidad.Text = txInventarioMinimo.Text = "0,00";
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

        private void txInventarioMinimo_UserGo(object sender, EventArgs e)
        {
            if (accion)
            {
                bnGuardar.PerformClick();
            }
            else
                bnActualizar.PerformClick();
        }

        private void txGananciaAlDetalPorcentaje_ErrorTextChanged()
        {
            chGananciaAlDetalDinero.Checked = false;
            chGananciaAlDetalTotal.Checked = false;
            chGananciaAlDetalPorcentaje.Checked = true;
        }

        private void txGananciaAlMayorPorcentaje_ErrorTextChanged()
        {
            chGananciaAlMayorDinero.Checked = false;
            chGananciaAlMayorTotal.Checked = false;
            chGananciaAlMayorPorcentaje.Checked = true;
        }

        private void txGananciaMinimaPorcentaje_ErrorTextChanged()
        {
            chGananciaMinimaDinero.Checked = false;
            chGananciaMinimaTotal.Checked = false;
            chGananciaMinimaPorcentaje.Checked = true;
        }

        private void bnEditMarca_Click(object sender, EventArgs e)
        {
            new frmMarca().ShowDialog();
            Cargar();
        }

        private void bnEditCategoria_Click(object sender, EventArgs e)
        {
            new frmCategoria().ShowDialog();
            Cargar();
        }

        private void bnEditPresentacion_Click(object sender, EventArgs e)
        {
            new frmPresentacion().ShowDialog();
            Cargar();
        }

        private void bnEditUnidadMedida_Click(object sender, EventArgs e)
        {
            new frmUnidadMedida().ShowDialog();
            Cargar();
        }

        private void bnEditEmpresaDistribuidora_Click(object sender, EventArgs e)
        {
            new frmEmpresaDistribuidora().ShowDialog();
            Cargar();
        }

        private void txImpuestoAplicado_TextChanged(object sender, EventArgs e)
        {
            CalcularPorcentajes();
        }

        private void gbGananciaAlDetal_Enter(object sender, EventArgs e)
        {
            foreach (Control c in ((GroupPanel)sender).Controls)
                if (c.Enabled && c.TabStop)
                    c.Focus();
        }
    }
    public class BuscadorProducto
    {
        public long Id_Sucursal { get; set; }
        public long Id_Producto { get; set; }
        public BuscadorProducto(long pId_Sucursal, long pId_Producto)
        {
            Id_Sucursal = pId_Sucursal;
            Id_Producto = pId_Producto;
        }
    }
}
