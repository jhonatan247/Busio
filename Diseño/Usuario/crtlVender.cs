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
using ProfessionalTicket;
using Presentacion.Formularios;
using Negocio.Lógica;
using Presentacion.Properties;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
using Presentacion.Controles;

namespace Presentacion.Usuario
{
    public partial class crtVender : UserControl
    {
        public static int ID = 0;
        public static int SUCURSAL = 1;
        public static int EMPRESA_DISTRIBUIDORA = 2;
        public static int MARCA = 3;
        public static int PRESENTACION = 4;
        public static int CATEGORIA = 5;
        public static int UNIDAD_DE_MEDIDA = 6;
        public static int IMPUESTO = 7;
        public static int CODIGO_DEL_PRODUCTO = 8;
        public static int NOMBRE = 9;
        public static int DESCRIPCION = 10;
        public static int IMAGEN = 11;
        public static int PRECIO_DE_COMPRA = 12;
        public static int PRECIO_VENTA = 13;
        public static int PRECIO_VENTA_NORMAL = 14;
        public static int PRECIO_VENTA_MAYOR = 15;
        public static int PRECIO_VENTA_MENOR = 16;
        public static int CANTIDAD = 17;
        public static int DESCUENTO = 18;
        public static int EXISTENCIA = 19;
        public static int ESTADO_INVENTARIO = 20;
        public static int SUB_TOTAL = 21;
        public static int IMPORTE = 22;

        ProfessionalTicketEPSON Ticket;
        long Total = 0;
        long SubTotal = 0;
        double Cantidad = 0;
        public crtVender()
        {
            InitializeComponent();
        }
        void ImprimirCabecera()
        {
            Ticket.ImprimirImagen((Bitmap)Image.FromFile(@"C:\Users\Usuario\Desktop\CyberCatchLogo.png"), 380);
            Ticket.ImprimirSaltosLinea(1);

            Ticket.ImprimirTextoConEstilo(
                "CYBER CATCH LTDA",
                Alineacion.Centro, Fuente.GrandeComprimida, true, false, true);
            Ticket.ImprimirTextoConEstilo(
                "CLL138 BIS NO.127 C-05",
                Alineacion.Centro, Fuente.GrandeComprimida, false, false, true);
            Ticket.EnviarEstiloNegrita(true);
            Ticket.ImprimirLineaConEsquinas(32, (char)201, (char)205, (char)187);
            Ticket.ImprimirTextoConBordes(" ", 32, (char)186, (char)186);
            Ticket.ImprimirTextoConBordes("  JHONTATAN TORRES FORERO  ", 32, (char)186, (char)186);
            Ticket.ImprimirTextoConBordes(" ", 32, (char)186, (char)186);
            Ticket.ImprimirTextoConBordes("  EXPERTOS EN AUTOMATIZACION", 32, (char)186, (char)186);
            Ticket.ImprimirTextoConBordes("         EMPRESARIAL", 32, (char)186, (char)186);
            //Ticket.ImprimirLineaConEsquinas(32, (char)200, (char)205, (char)188);
            Ticket.ImprimirTexto("" + (char)200 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205
                + (char)203 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)188);

            Ticket.ImprimirTexto("        " + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205
                + (char)202 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + (char)205 + "       \n");

            Ticket.ImprimirTextoConEstilo(
                "TEL:6870946\nCEL: 3023366702\nE-MAIL: YON.T.F@HOTMAIL.COM",
                Alineacion.Centro, Fuente.GrandeComprimida, true, false, true);
            Ticket.ImprimirSaltosLinea(2);
        }
        void ImprimirTituloCotizacion()
        {
            Ticket.ImprimirTextoConEstilo(
            ((char)178).ToString() + ((char)177).ToString() + ((char)176).ToString() + "COTIZACION" + ((char)176).ToString() + ((char)177).ToString() + ((char)178).ToString(),
                Alineacion.Centro, Fuente.GrandeEstirada, false, false, true);
        }
        void ImprimirTituloVenta()
        {
            Ticket.ImprimirTextoConEstilo(
            ((char)178).ToString() +((char)178).ToString() + ((char)177).ToString() + ((char)176).ToString() + ((char)176).ToString() + "VENTA " + ((char)176).ToString() + ((char)176).ToString() + ((char)177).ToString() + ((char)178).ToString() + ((char)178).ToString(),
                Alineacion.Centro, Fuente.GrandeEstirada, false, false, true);
        }
        void ImprimirPiePagina()
        {
            Ticket.ImprimirSaltosLinea(2);

            Ticket.ImprimirTextoConEstilo("M" + (char)160 + "s informaci" + (char)162 + "n en:", Alineacion.Izquierda, Fuente.Normal, true, false, true);
            Ticket.ImprimirQR("CYBER CATCH LTDA\nTEL: 6870946\nCEL: 3023366702-3058180569\nEMAIL: YON.T.F@HOTMAIL.COM", 200);
            Ticket.ImprimirTicket();
            Ticket.CortarTicketConSaltosLinea(3);
        }
        void ImprimirArticulos()
        {
            Ticket.ImprimirSaltosLinea(1);
            Ticket.ImprimirTextoConEstilo("", Alineacion.Centro, Fuente.GrandeComprimida, false, false, false);
            Ticket.ImprimirLineaConEsquinas(32, (char)218, (char)196, (char)191);
            Ticket.ImprimirTextoConEstilo((char)179 + "Cant  Art" + (char)161 + "culo    Precio      " + (char)179, Alineacion.Centro, Fuente.GrandeComprimida, true, false, true);
            Ticket.ImprimirTextoConEstilo("", Alineacion.Centro, Fuente.GrandeComprimida, false, false, false);
            Ticket.ImprimirLineaConEsquinas(32, (char)195, (char)196, (char)180);
            for (int i = 0; i < dtVentaActual.RowCount; i++)
            {
                string nombre = GetCell(i, NOMBRE).ToString();
                nombre = nombre.Length>10? nombre.Substring(0,10): nombre;
                long cantidad = Convert.ToInt64(GetCell(i,CANTIDAD).ToString());
                long precio = Convert.ToInt64(GetCell(i, PRECIO_VENTA).ToString().Substring(1, GetCell(i, PRECIO_VENTA).ToString().Length - 1));
                double totalProd = Convert.ToDouble(GetCell(i, IMPORTE).ToString().Substring(1, GetCell(i, IMPORTE).ToString().Length - 1));
                Ticket.ImprimirTextoConEstilo((char)179 + AccionesSistema.addSpaces(cantidad,6)+AccionesSistema.addSpaces(nombre, 12)+ AccionesSistema.addSpacesPrice(precio,12)+ (char)179
                    , Alineacion.Centro, Fuente.GrandeComprimida, false, false, true);

            }
            Ticket.ImprimirTextoConEstilo("", Alineacion.Centro, Fuente.GrandeComprimida, false, false, false);
            Ticket.ImprimirLineaConEsquinas(32, (char)192, (char)196, (char)217);
            Ticket.ImprimirSaltosLinea(2);
            Ticket.ImprimirTextoConEstilo("Total: " +txTotal.Text, Alineacion.Derecha, Fuente.GrandeComprimida, true, true, true);
            Ticket.ImprimirSaltosLinea(2);
        }
        object GetCell(int r, int c)
        {
            return dtVentaActual[c,r].Value;
        }
        object SetCell(int r, int c, object val)
        {
            return dtVentaActual[c, r].Value = val;
        }
        void CalcRowDat(int r)
        {
            String precio = GetCell(r, PRECIO_VENTA).ToString();
            SetCell(r, IMPORTE, "$"+Math.Round(Convert.ToDouble(GetCell(r, CANTIDAD)) *Convert.ToDouble(precio.Substring(1, precio.Length - 1))));
        }
        public void ImprimirFactura()
        {
            Ticket = new ProfessionalTicketEPSON(Settings.Default.Impresora);
            /*Ticket.AbrirCajon();
            ImprimirCabecera();
            ImprimirTituloCotizacion();*/
            ImprimirArticulos();
            /*ImprimirCodigoCotizacion("07032745441703190642");
            ImprimirPiePagina();*/
            

            
        }
        void ImprimirCodigoCotizacion(string Codigo)
        {
            Ticket.ImprimirTextoConEstilo("C" + (char)162 + "digo de cotizaci" + (char)162 + "n", Alineacion.Centro, Fuente.Normal, false, false, true);
            Ticket.ImprimirCodigoBarrasProfesionalConLeyenda(Codigo,
                new Font("Segoe UI Light", 55F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))), 1000, 200, 380);
        }
        void ImprimirCodigoVenta(string Codigo)
        {
            Ticket.ImprimirTextoConEstilo("C" + (char)162 + "digo de venta", Alineacion.Centro, Fuente.Normal, false, false, true);
            Ticket.ImprimirCodigoBarrasProfesionalConLeyenda(Codigo,
                new Font("Segoe UI Light", 55F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0))), 1000, 200, 380);
        }
        void AgregarProducto()
        {
            double cantidad = 1;
            try
            {
                int indx = txVentasCodigoBarras.Text.IndexOf('*');
                int lngt = txVentasCodigoBarras.Text.Length-1;
                if (indx > 0 && indx < lngt)
                {
                    cantidad = Convert.ToDouble(txVentasCodigoBarras.Text.Substring(0, indx));
                    txVentasCodigoBarras.Text = txVentasCodigoBarras.Text.Substring(indx + 1, lngt - indx);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            bool pert = false;
            int row = 0;
            try
            {
                for (int f = 0; f < dtVentaActual.RowCount; f++)
                {
                    if (GetCell(f,CODIGO_DEL_PRODUCTO).ToString() == txVentasCodigoBarras.Text)
                    {
                        pert = true;
                        row = f;
                        break;
                    }
                }
            }
            catch
            {
                
            }
            if (pert)
            {
                AumentarCantidadVenta(row, cantidad);
                Fucus();
                return;
            }

            DataTable dTable = new Producto().SelectVender(1,txVentasCodigoBarras.Text);
            if (dTable.Rows.Count > 0)
            {
                DataRow dRow = dTable.Rows[0];
                if (Convert.ToDouble(dRow[Producto.CANTIDAD_EN_INVENTARIO].ToString()) > 0)
                {

                    double porc = (Convert.ToDouble(dRow[Producto.IMPUESTO].ToString()) / 100);

                    double precio = Convert.ToDouble(dRow[Producto.PRECIO_COMPRA].ToString()) * (1 + Convert.ToDouble(dRow[Producto.GANANCIA_NORMAL].ToString()) / 100);
                    double precioNormal = (dRow[Producto.IMPUESTO_INCLUIDO].ToString() == "True" ?
                          precio : precio * (1 + porc));

                    precio = Convert.ToDouble(dRow[Producto.PRECIO_COMPRA].ToString()) * (1+ Convert.ToDouble(dRow[Producto.GANANCIA_MAYOREO].ToString()) / 100);

                    double precioMayor = (dRow[Producto.IMPUESTO_INCLUIDO].ToString() == "True" ?
                          precio : precio * (1 + porc));

                    precio = Convert.ToDouble(dRow[Producto.PRECIO_COMPRA].ToString()) * (1 + Convert.ToDouble(dRow[Producto.GANANCIA_MINIMA].ToString()) / 100);

                    double precioMenor = (dRow[Producto.IMPUESTO_INCLUIDO].ToString() == "True" ?
                          precio : precio * (1 + porc));

                    string Inventario = (dRow[Producto.UTILIZA_INVENTARIO].ToString() == "True" ? dRow[Producto.CANTIDAD_EN_INVENTARIO].ToString() : "Idefinido");

                    string EstadoInv = (Inventario == "Idefinido" ? "Idefinido" :
                        (Convert.ToDouble(dRow[Producto.CANTIDAD_MINIMA].ToString()) >= Convert.ToDouble(dRow[Producto.CANTIDAD_EN_INVENTARIO].ToString()) ? "Alerta" : "Normal"));

                    double Total = Math.Round(precioNormal * cantidad);
                    double SubTotal = (precioNormal / (porc + 1));
                    dtVentaActual.Rows.Add(dRow[Producto.ID], dRow[Producto.SUCURSAL], dRow[Producto.EMPRESA_DISTRIBUIDORA], 
                        dRow[Producto.MARCA], dRow[Producto.PRESENTACION], dRow[Producto.CATEGORÍA], dRow[Producto.UNIDAD_DE_MEDIDA],
                        dRow[Producto.IMPUESTO], dRow[Producto.CÓDIGO], dRow[Producto.NOMBRE], dRow[Producto.DESCRIPCION], dRow[Producto.IMAGEN], dRow[Producto.PRECIO_COMPRA], "$" + precioNormal, precioNormal, 
                        precioMayor, precioMenor, cantidad, 0, Inventario, EstadoInv, SubTotal, "$" + Total);
                    CalcularTotal();
                    txVentasCodigoBarras.Clear();
                    txVentasCodigoBarras.Focus();
                }
                else
                {
                    MessageBoxEx.Show("Producto no hay unidades suficientes");
                }
            }
            else
            {
                MessageBoxEx.Show("Producto no encontrado");
            }
        }
        void CalcularTotal()
        {
            Total = 0;
            Cantidad = 0;
            SubTotal = 0;
            for (int i = 0; i < dtVentaActual.RowCount; i++)
            {
                string prec = GetCell(i, IMPORTE).ToString();
                Total += Convert.ToInt64(prec.Substring(1, prec.Length - 1));
                Cantidad += Convert.ToDouble(GetCell(i, CANTIDAD));
                SubTotal += (long)Math.Round(Convert.ToDouble(GetCell(i, SUB_TOTAL))*Cantidad);
            }
            txTotal.Text = "$" +AccionesSistema.addSeparadoresLong(Total);
            txSubTotal.Text = "Subtotal: $" + AccionesSistema.addSeparadoresLong(SubTotal);
            lbArticulos.Text = Cantidad + " Atrículos en la venta actual";
        }
        void AumentarCantidadVenta(int row, double cant)
        {
            double precio = Convert.ToDouble(GetCell(row, PRECIO_VENTA).ToString().Substring(1, GetCell(row,PRECIO_VENTA).ToString().Length - 1));
            cant = Convert.ToDouble(GetCell(row, CANTIDAD)) + cant;
            double subTotal = precio / (1 + Convert.ToDouble(GetCell(row, IMPUESTO).ToString()))/100;
            SetCell(row, CANTIDAD, cant);
            SetCell(row, IMPORTE,"$" + (cant * precio));

            SetCell(row, SUB_TOTAL,Math.Round(subTotal*cant));
            CalcularTotal();
        }

        public void Fucus()
        {
            txVentasCodigoBarras.Clear();
            txVentasCodigoBarras.Focus();
            txVentasCodigoBarras.SelectionStart = txVentasCodigoBarras.Text.Length;
            txVentasCodigoBarras.SelectionLength = 0;
        }
        private void txVentasCodigoBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AgregarProducto();
            }
        }
        private void bnCobrar_Click(object sender, EventArgs e)
        {
            if(Cantidad < 0)
            {
                MessageBoxEx.Show("No hay artículos para vender");
                return;
            }
            if (new frmTipoPago(Convert.ToDouble(txTotal.Text.Substring(1, txTotal.Text.Length - 1))).ShowDialog() != DialogResult.OK)
            {

                ImprimirFactura();
            }
        }
        private void bnAbrirCaja_Click(object sender, EventArgs e)
        {
            new ProfessionalTicketEPSON(Settings.Default.Impresora).AbrirCajon();
        }

        private void bnBorrarArticulo_Click(object sender, EventArgs e)
        {
            if (dtVentaActual.Rows.Count > 0)
            {
                dtVentaActual.Rows.Remove(dtVentaActual.CurrentRow);
                CalcularTotal();
            }
        }

        private void bnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProducto fBuscarProd = new frmBuscarProducto(false, true);
            if (fBuscarProd.ShowDialog() == DialogResult.OK)
            {
                int cant = Convert.ToInt32(fBuscarProd.Drow[19]);
                if (cant > 0) {

                    InputEx inp = new InputEx("Cantidad", "Ingresa la cantidad a añadir del producto seleccionado", ValidatingType.uDouble, "1", 0, cant);
                    if (inp.ShowDialog() == DialogResult.OK && inp.Value!="0")
                    {
                        txVentasCodigoBarras.Text = inp.Value + "*" + fBuscarProd.Drow[8].ToString();
                        AgregarProducto();
                    }
                }
                else
                {
                    MessageBoxEx.Show("No hay unidades suficientes.", "Error de selección");
                    bnBuscarProducto.PerformClick();
                }
            }
        }

        private void bnIngresarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        private void dtVentaActual_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = dtVentaActual.CurrentCell.ColumnIndex, row = dtVentaActual.CurrentCell.RowIndex;
            object val = dtVentaActual.CurrentCell.Value;
            if (dtVentaActual.CurrentCell.ColumnIndex == CANTIDAD) {
                InputEx inp = new InputEx("Cantidad", "Ingresa la cantidad a añadir del producto seleccionado", ValidatingType.uDouble, val.ToString(), 0,Convert.ToDouble(GetCell(row,EXISTENCIA)) );
                if (inp.ShowDialog() == DialogResult.OK && inp.Value!="0")
                {
                    dtVentaActual.CurrentCell.Value = inp.Value;
                    CalcRowDat(row);
                    CalcularTotal();
                }
            }
        }
        
    }
}
