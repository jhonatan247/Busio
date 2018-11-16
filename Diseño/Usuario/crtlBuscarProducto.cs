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
using DevComponents.DotNetBar.Controls;
using Negocio.Lógica;
using Presentacion.Formularios;
using DevComponents.AdvTree;
using Presentacion.Controles;
using Presentacion.Properties;

namespace Presentacion.Usuario
{
    public partial class crtlBuscarProducto : UserControl
    {
        bool accion = true;
        bool multiSelect = false;
        bool vender = false;
        bool primero = true;
        char[] TipoBusqNormal = { '%', '%' };
        char[] TipoBusqCodigo = { '%', '%' };
        char[] TipoBusqNombre = { '%', '%' };
        char[] TipoBusqDescripcion = { '%', '%' };
        public bool Vender
        {
            get
            {
                return vender;
            }
            set
            {
                vender = value;
                bnElegirColumnas.Visible =
                bnElegirColumnasAvanzado.Visible =
                clId.Visible =
                clSucursal.Visible =
                clEmpD.Visible =
                clUndMed.Visible =
                clImpuesto.Visible =
                clPrecioCompra.Visible =
                clPrecioMayoreo.Visible =
                clPrecioMinim.Visible =
                !value;
            }
        }
        public bool MultiSelect
        {
            get
            {
                return multiSelect;
            }
            set
            {
                multiSelect = value;
                if (multiSelect)
                {
                    SuspendLayout();
                    pnlMultiSelect.Show();
                    pnlOpcionesMultiselect.Show();
                    ResumeLayout();
                }
                else
                {
                    SuspendLayout();
                    pnlMultiSelect.Hide();
                    pnlOpcionesMultiselect.Hide();
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
            }
        }
        #region Delegados
        public delegate void AccionDelegate(DataRow pSelect);
        public delegate void AccionMultipleDelegate(List<long> pSelect);
        #endregion
        #region Eventos
        public event AccionDelegate AccionSeleccionar;
        public event AccionMultipleDelegate AccionSeleccionarMultiple;
        #endregion
        public crtlBuscarProducto()
        {
            InitializeComponent();
            cbBuscarPor.SelectedIndex = 0;
        }
        bool Pertenece(DataRow Row)
        {
            for (int i = 0; i < dtMultiSelect.Rows.Count; i++)
            {
                if (Convert.ToInt64(dtMultiSelect[0, i].Value) == Convert.ToInt64(Row[0]))
                    return true;
            }
            return false;
        }
        public void Cargar()
        {
            long IdSucursal = AccionesSistema.Id_sucursal;
            if (IdSucursal == 0)
            {
                cbSucursal.DataSource = new Sucursal().SelectAll();
            }
            else
            {
                List<string> lst = new List<string>();
                lst.Add(new Sucursal().Select(IdSucursal)[1].ToString());
                cbSucursal.DataSource = lst;
                cbSucursal.SelectedIndex = 0;
            }
            cbSucursal.DataSource = new Sucursal().SelectAll();
            cbEmpresaDistribuidora.DataSource = new Empresa_Distribuidora().SelectAll();
            cbCategoria.DataSource = new Categoria().SelectAll();
            cbMarca.DataSource = new Marca().SelectAll();
            cbPresentacion.DataSource = new Negocio.Manejo_de_datos.Presentacion().SelectAll();
            cbUnidadMedida.DataSource = new Unidad_Medida().SelectAll();
            txNombre.Focus();
        }
        DataTable BusquedaPorCampoSucursal(long pSucursal)
        {
            string
                spCodigo = "%%",
                spNombre = "%%",
                spDescripcion = "%%",
                spSucursal = "%"+new Sucursal().Select(pSucursal)[1].ToString() +"%",
                spMarca = "%%",
                spEmpresa = "%%",
                spPresentacion = "%%",
                spcategoria = "%%",
                spUnidadmedida = "%%";
            switch (cbBuscarPor.SelectedIndex)
            {
                case 1:
                    spCodigo = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 2:
                    spNombre = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 3:
                    spDescripcion = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 4:
                    spEmpresa = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 5:
                    spMarca = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 6:
                    spPresentacion = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 7:
                    spcategoria = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 8:
                    spUnidadmedida = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
            }
            if (accion)
            {
                return new Producto().LikeAvanzado(spCodigo, spNombre, spDescripcion,
                spSucursal, spEmpresa, spMarca, spPresentacion, spcategoria, spUnidadmedida);
            }
            else
            {
                return new Producto().LikeAvanzadoOf(spCodigo, spNombre, spDescripcion,
                spSucursal, spEmpresa, spMarca, spPresentacion, spcategoria, spUnidadmedida);
            }
        }
        DataTable BusquedaPorCampoSuper()
        {
            string
                spCodigo = "%%",
                spNombre = "%%",
                spDescripcion = "%%",
                spSucursal = "%%",
                spMarca = "%%",
                spEmpresa = "%%",
                spPresentacion = "%%",
                spcategoria = "%%",
                spUnidadmedida = "%%";
            switch (cbBuscarPor.SelectedIndex)
            {
                case 1:
                    spCodigo = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 2:
                    spNombre = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 3:
                    spDescripcion = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 4:
                    spSucursal = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 5:
                    spEmpresa = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 6:
                    spMarca = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 7:
                    spPresentacion = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 8:
                    spcategoria = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
                case 9:
                    spUnidadmedida = TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1];
                    break;
            }
            if (accion)
            {
                return new Producto().LikeAvanzado(spCodigo, spNombre, spDescripcion,
                spSucursal, spEmpresa, spMarca, spPresentacion, spcategoria, spUnidadmedida);
            }
            else
            {
                return new Producto().LikeAvanzadoOf(spCodigo, spNombre, spDescripcion,
                spSucursal, spEmpresa, spMarca, spPresentacion, spcategoria, spUnidadmedida);
            }
        }

        public void Buscar()
        {
            dtBuscar.Rows.Clear();
            DataTable dTable;
            long IdSucursal = AccionesSistema.Id_sucursal;
            if (primero && IdSucursal > 0)
            {
                cbBuscarPor.Items.Remove(comboItem1); primero = false;
            }
            if (accion)
            {
                if (!pnlBusquedaAvanzada.Visible)
                {
                    if (IdSucursal == 0)
                    {
                        if (cbBuscarPor.SelectedIndex == 0)
                        {
                            dTable = new Producto().Like(TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1]);
                        }
                        else
                            dTable = BusquedaPorCampoSuper();
                    }
                    else
                    {
                        if (cbBuscarPor.SelectedIndex == 0)
                        {
                            dTable = new Producto().LikeSucursal(IdSucursal, TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1]);
                        }
                        else
                            dTable = BusquedaPorCampoSucursal(IdSucursal);
                    }
                }
                else
                {
                    dTable = new Producto().LikeAvanzado(
                        chCodigo.Checked ? TipoBusqCodigo[0] + txCodigo.Text + TipoBusqCodigo[1] : "%%",
                       chNombre.Checked ? TipoBusqNombre[0] + txNombre.Text + TipoBusqNombre[1] : "%%",
                       chDescripcion.Checked ? TipoBusqDescripcion[0] + txDescripcion.Text + TipoBusqDescripcion[1] : "%%",
                       chSucursal.Checked ? cbSucursal.SelectedValue.ToString() : "", chEmpresaDistribuidora.Checked ? cbEmpresaDistribuidora.SelectedValue.ToString() : "",
                       chMarca.Checked ? cbMarca.SelectedValue.ToString() : "", chPresentacion.Checked ? cbPresentacion.SelectedValue.ToString() : "",
                       chCategoria.Checked ? cbCategoria.SelectedValue.ToString() : "", chUnidadMedida.Checked ? cbUnidadMedida.SelectedValue.ToString() : "");
                }
            }
            else
            {
                if (!pnlBusquedaAvanzada.Visible)
                {
                    if (IdSucursal == 0)
                    {
                        if (cbBuscarPor.SelectedIndex == 0)
                        {
                            dTable = new Producto().LikeOf(TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1]);
                        }
                        else
                        {
                            if (cbBuscarPor.SelectedIndex == 0)
                            {
                                dTable = new Producto().LikeSucursalOf(IdSucursal, TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1]);
                            }
                            else
                                dTable = BusquedaPorCampoSucursal(IdSucursal);
                        }
                    }
                    else
                    {
                        dTable = new Producto().LikeSucursalOf(IdSucursal, TipoBusqNormal[0] + txBuscar.Text + TipoBusqNormal[1]);
                    }
                }
                else
                {
                    dTable = new Producto().LikeAvanzadoOf(
                        chCodigo.Checked ? TipoBusqCodigo[0] + txCodigo.Text + TipoBusqCodigo[1] : "%%",
                       chNombre.Checked ? TipoBusqNombre[0] + txNombre.Text + TipoBusqNombre[1] : "%%",
                       chDescripcion.Checked ? TipoBusqDescripcion[0] + txDescripcion.Text + TipoBusqDescripcion[1] : "%%",
                       chSucursal.Checked ? cbSucursal.SelectedValue.ToString() : "", chEmpresaDistribuidora.Checked ? cbEmpresaDistribuidora.SelectedValue.ToString() : "",
                       chMarca.Checked ? cbMarca.SelectedValue.ToString() : "", chPresentacion.Checked ? cbPresentacion.SelectedValue.ToString() : "",
                       chCategoria.Checked ? cbCategoria.SelectedValue.ToString() : "", chUnidadMedida.Checked ? cbUnidadMedida.SelectedValue.ToString() : "");
                }
            }

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                DataRow dRow = dTable.Rows[i];
                if (!multiSelect || !Pertenece(dRow))
                {
                    double precioNormal = Convert.ToDouble(dRow[12].ToString()) + (Convert.ToDouble(dRow[12].ToString()) * Convert.ToDouble(dRow[13].ToString()) / 100),
                        precioMayoreo = Convert.ToDouble(dRow[12].ToString()) + (Convert.ToDouble(dRow[12].ToString()) * Convert.ToDouble(dRow[14].ToString()) / 100),
                        precioMinimo = Convert.ToDouble(dRow[12].ToString()) + (Convert.ToDouble(dRow[12].ToString()) * Convert.ToDouble(dRow[15].ToString()) / 100);

                    double PrecioVentaNormal = (dRow[16].ToString() == "True" ?
                          precioNormal : precioNormal + (precioNormal * (Convert.ToDouble(dRow[7].ToString()) / 100))),
                          precioVentaMayoreo = (dRow[16].ToString() == "True" ?
                          precioMayoreo : precioMayoreo + (precioMayoreo * (Convert.ToDouble(dRow[7].ToString()) / 100))),
                         precioVentaMinimo = (dRow[16].ToString() == "True" ?
                        precioMinimo : precioMinimo + (precioMinimo * (Convert.ToDouble(dRow[7].ToString()) / 100)));

                    string Inventario = (dRow[17].ToString() == "True" ? dRow[19].ToString() : "Idefinido");

                    string EstadoInv = (Inventario == "Idefinido" ? "Idefinido" :
                        (Convert.ToDouble(dRow[18].ToString()) >= Convert.ToDouble(dRow[19].ToString()) ? "Alerta" : "Normal"));


                    dtBuscar.Rows.Add(dRow[0], dRow[1], dRow[2], dRow[3], dRow[4], dRow[5], dRow[6],
                        dRow[7]+"%", dRow[8], dRow[9], dRow[10], dRow[11].ToString() == "" ? Resources.producto : dRow[11], "$"+dRow[12], "$"+PrecioVentaNormal, "$"+precioVentaMayoreo, "$"+precioVentaMinimo, "0,00%", Inventario, EstadoInv);
                }
            }
        }
        public void TrasladarSelecion(DataGridViewX dOutput, DataGridViewX dInput)
        {
            if (dOutput.SelectedRows.Count >= 1)
            {
                try
                {
                    int m = dOutput.SelectedRows.Count;
                    for (int i = 0; i < m; i++)
                    {
                        dInput.Rows.Add(
                            dOutput.SelectedRows[0].Cells[0].Value, dOutput.SelectedRows[0].Cells[1].Value,
                            dOutput.SelectedRows[0].Cells[2].Value, dOutput.SelectedRows[0].Cells[3].Value,
                            dOutput.SelectedRows[0].Cells[4].Value, dOutput.SelectedRows[0].Cells[5].Value,
                            dOutput.SelectedRows[0].Cells[6].Value, dOutput.SelectedRows[0].Cells[7].Value,
                            dOutput.SelectedRows[0].Cells[8].Value, dOutput.SelectedRows[0].Cells[9].Value,
                            dOutput.SelectedRows[0].Cells[10].Value, dOutput.SelectedRows[0].Cells[11].Value,
                            dOutput.SelectedRows[0].Cells[12].Value, dOutput.SelectedRows[0].Cells[13].Value,
                            dOutput.SelectedRows[0].Cells[14].Value, dOutput.SelectedRows[0].Cells[15].Value,
                            dOutput.SelectedRows[0].Cells[16].Value, dOutput.SelectedRows[0].Cells[17].Value
                            , dOutput.SelectedRows[0].Cells[18].Value);
                        dOutput.Rows.Remove(dOutput.SelectedRows[0]);
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            }
            else if (dOutput.SelectedCells.Count >= 1)
            {
                TrasladarSelecionCelda(dOutput, dInput);
            }
            else
            {
                MessageBox.Show("Selección Incorrecta", "CleanServices");
            }
        }
        public void TrasladarSelecionCelda(DataGridViewX dOutput, DataGridViewX dInput)
        {
            int Row = dOutput.SelectedCells[0].RowIndex;
            try
            {
                dInput.Rows.Add(
                    dOutput[0, Row].Value, dOutput[1, Row].Value,
                    dOutput[2, Row].Value, dOutput[3, Row].Value,
                    dOutput[4, Row].Value, dOutput[5, Row].Value,
                    dOutput[6, Row].Value, dOutput[7, Row].Value,
                    dOutput[8, Row].Value, dOutput[9, Row].Value,
                    dOutput[10, Row].Value, dOutput[11, Row].Value,
                    dOutput[12, Row].Value, dOutput[13, Row].Value,
                    dOutput[14, Row].Value, dOutput[15, Row].Value,
                    dOutput[16, Row].Value, dOutput[17, Row].Value, dOutput[18, Row].Value);
                dOutput.Rows.Remove(dOutput.Rows[Row]);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.ToString()); }
        }
        public void TrasladarTodos(DataGridViewX dOutput, DataGridViewX dInput)
        {
            try
            {
                int m = dOutput.Rows.Count;
                for (int i = 0; i < m; i++)
                {
                    dInput.Rows.Add(
                        dOutput[0, 0].Value, dOutput[1, 0].Value,
                        dOutput[2, 0].Value, dOutput[3, 0].Value,
                        dOutput[4, 0].Value, dOutput[5, 0].Value,
                        dOutput[6, 0].Value, dOutput[7, 0].Value,
                        dOutput[8, 0].Value, dOutput[9, 0].Value,
                        dOutput[10, 0].Value, dOutput[11, 0].Value,
                        dOutput[12, 0].Value, dOutput[13, 0].Value,
                        dOutput[14, 0].Value, dOutput[15, 0].Value,
                        dOutput[16, 0].Value, dOutput[17, 0].Value, dOutput[18, 0].Value);
                    dOutput.Rows.Remove(dOutput.Rows[0]);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }
        private void txBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar();
            //dataGridViewX1.DataSource = new Producto().Like(txBuscar.Text);
        }
        private void dataGridViewX1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!multiSelect)
            {
                long id = Convert.ToInt64(AccionesSistema.ObtenerValorSelecion(dtBuscar, 0).ToString());
                if (id != 0)
                {
                    try
                    {
                        DataRow dRow; 
                        dRow = accion?new Producto().SelectVista(new Sucursal().SelectId(AccionesSistema.ObtenerValorSelecion(dtBuscar, 1).ToString()), id):
                            new Producto().SelectVistaOf(new Sucursal().SelectId(AccionesSistema.ObtenerValorSelecion(dtBuscar, 1).ToString()), id);

                        try
                        {
                            AccionSeleccionar(dRow);
                        }
                        catch { }
                    }
                    catch(Exception ex)
                    {
                        AccionesSistema.RemoverSelecion(dtBuscar);
                        //MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                TrasladarSelecion(dtBuscar, dtMultiSelect);
            }
        }

        private void bnElegirColumnas_Click(object sender, EventArgs e)
        {
            frmColumnasVisibles fVisibles = new frmColumnasVisibles(dtBuscar.Columns);
            if (fVisibles.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < fVisibles.nombres.Count; i++)
                {
                    dtBuscar.Columns[fVisibles.nombres[i]].Visible = fVisibles.visible[i];
                }
            }
        }

        private void dtMultiSelect_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TrasladarSelecion(dtMultiSelect, dtBuscar);
        }

        private void bnDeseleccionarTodos_Click(object sender, EventArgs e)
        {
            TrasladarTodos(dtMultiSelect, dtBuscar);
        }

        private void bnDeseleccionar_Click(object sender, EventArgs e)
        {
            TrasladarSelecion(dtMultiSelect, dtBuscar);
        }

        private void bnSeleccionar_Click(object sender, EventArgs e)
        {
            TrasladarSelecion(dtBuscar, dtMultiSelect);
        }

        private void bnSeleccionarTodos_Click(object sender, EventArgs e)
        {
            TrasladarTodos(dtBuscar, dtMultiSelect);
        }

        private void bnListo_Click(object sender, EventArgs e)
        {
            if (dtMultiSelect.RowCount > 0)
            {
                List<long> lst = new List<long>();
                for (int i = 0; i < dtMultiSelect.RowCount; i++)
                {
                    long idValue = new Inventario(new Sucursal().SelectId( dtMultiSelect[1, i].Value.ToString()), Convert.ToInt64(dtMultiSelect[0, i].Value)).SelectId();
                    if (idValue > 0)
                    {
                        lst.Add(idValue);
                    }
                    else
                    {
                        dtMultiSelect.Rows.Remove(dtMultiSelect.Rows[i]);
                    }
                }
                try
                {
                    AccionSeleccionarMultiple(lst);
                }
                catch { }
            }
            else
            {
                MessageBox.Show("Selección incorrecta");
            }
        }

        private void bnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            pnlBusquedaNormal.Hide();
            Cargar();
            pnlBusquedaAvanzada.Show();
        }

        private void bnBusquedaNormal_Click(object sender, EventArgs e)
        {
            pnlBusquedaAvanzada.Hide();
            pnlBusquedaNormal.Show();
        }

        private void bnRefescar_Click(object sender, EventArgs e)
        {
            Cargar();
        }

        private void chNombre_CheckedChanged(object sender, EventArgs e)
        {
            txNombre.Enabled = bnConfigNorm.Enabled = chNombre.Checked;
            if (chNombre.Checked)
                txNombre.Focus();
        }

        private void chDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            txDescripcion.Enabled = bnConfigDescripcion.Enabled = chDescripcion.Checked;
            if (chDescripcion.Checked)
                txDescripcion.Focus();
        }

        private void chSucursal_CheckedChanged(object sender, EventArgs e)
        {
            cbSucursal.Enabled = chSucursal.Checked;
            if (chSucursal.Checked)
                cbSucursal.Focus();
        }

        private void chMarca_CheckedChanged(object sender, EventArgs e)
        {
            cbMarca.Enabled = chMarca.Checked;
            if (chMarca.Checked)
                cbMarca.Focus();
        }

        private void chEmpresaDistribuidora_CheckedChanged(object sender, EventArgs e)
        {
            cbEmpresaDistribuidora.Enabled = chEmpresaDistribuidora.Checked;
            if (chEmpresaDistribuidora.Checked)
                cbEmpresaDistribuidora.Focus();
        }

        private void chPresentacion_CheckedChanged(object sender, EventArgs e)
        {
            cbPresentacion.Enabled = chPresentacion.Checked;
            if (chPresentacion.Checked)
                cbPresentacion.Focus();
        }

        private void chCategoria_CheckedChanged(object sender, EventArgs e)
        {
            cbCategoria.Enabled = chCategoria.Checked;
            if (chCategoria.Checked)
                cbCategoria.Focus();
        }

        private void chUnidadMedida_CheckedChanged(object sender, EventArgs e)
        {
            cbUnidadMedida.Enabled = chUnidadMedida.Checked;
            if (chUnidadMedida.Checked)
                cbUnidadMedida.Focus();
        }

        private void cbMarca_UserGo(object sender, EventArgs e)
        {
            Buscar();
        }

        private void chCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txCodigo.Enabled  = bnConfigCodigo.Enabled = chCodigo.Checked;
            if (chCodigo.Checked)
                txCodigo.Focus();
        }

        private void bnConfigNorm_Click(object sender, EventArgs e)
        {
            TipoBusqNormal = new frmTipoBusqueda(TipoBusqNormal).MostrarDialogo();
            txBuscar.Focus();
        }

        private void bnConfigCodigo_Click(object sender, EventArgs e)
        {
            TipoBusqCodigo = new frmTipoBusqueda(TipoBusqCodigo).MostrarDialogo();
            txCodigo.Focus();
        }

        private void nConfigNombre_Click(object sender, EventArgs e)
        {
            TipoBusqNombre = new frmTipoBusqueda(TipoBusqNombre).MostrarDialogo();
            txNombre.Focus();
        }

        private void bnConfigDescripcion_Click(object sender, EventArgs e)
        {
            TipoBusqDescripcion = new frmTipoBusqueda(TipoBusqNombre).MostrarDialogo();
            txDescripcion.Focus();
        }

        private void bnElegirColumnasSeleccion_Click(object sender, EventArgs e)
        {
            frmColumnasVisibles fVisibles = new frmColumnasVisibles(dtMultiSelect.Columns);
            if (fVisibles.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < fVisibles.nombres.Count; i++)
                {
                    dtMultiSelect.Columns[fVisibles.nombres[i]].Visible = fVisibles.visible[i];
                }
            }
        }
    }
}
