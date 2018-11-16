using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Lógica;
using Presentacion.Properties;

namespace Presentacion.Vistas
{
    public partial class viewProducto : UserControl
    {
        public viewProducto(DataRow Drow)
        {
            InitializeComponent();
            lbEmpresaDistribuidora.Text = Drow[2].ToString();
            lbMarca.Text = Drow[3].ToString();
            lbPresentacion.Text = Drow[4].ToString();
            lbCategoria.Text = Drow[5].ToString();
            lbUnidad.Text = Drow[6].ToString();
            lbImpuesto.Text = Drow[7].ToString();
            lbCodigoBarr.Text = Drow[8].ToString();
            lbNombre.Text = Drow[9].ToString() + " (" + Drow[1].ToString() + ")";
            lbDescripcion.Text = Drow[10].ToString();
            if (Drow[11].ToString() != "")
            {
                pbImagen.Image = AccionesSistema.ObtenerImagen(Drow[11]);
            }
            else
            {
                pbImagen.Image = Resources.producto;
            }
            lbPrecioCompra.Text = Drow[12].ToString();


            decimal
                   valor = Convert.ToDecimal(Drow[12].ToString()),
                   impuesto = Convert.ToDecimal(Drow[7].ToString()),
                   ganancia = Convert.ToDecimal(Drow[13].ToString()),
                   dinero = valor * ganancia / 100,
                   total = Math.Round(valor + dinero, 2),
                   valorImpuesto = total * impuesto / 100;

            bool imp = Convert.ToBoolean(Drow[16].ToString());

            lbGananciaDetalPorc.Text = ganancia.ToString();
            lbGananciaDetalDinero.Text = dinero.ToString();
            lbGananciaDetalPrecio.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());


            ganancia = Convert.ToDecimal(Drow[14].ToString());
            dinero = valor * ganancia / 100;
            total = Math.Round(valor + dinero, 2);
            valorImpuesto = total * impuesto / 100;

            lbGananciaMayorPorc.Text = ganancia.ToString();
            lbGananciaMinimDinero.Text = dinero.ToString();
            lbGananciaMayorPrecio.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());


            ganancia = Convert.ToDecimal(Drow[15].ToString());
            dinero = valor * ganancia / 100;
            total = Math.Round(valor + dinero, 2);
            valorImpuesto = total * impuesto / 100;

            lbGananciaMinimPorc.Text = ganancia.ToString();
            lbGananciaMinimDinero.Text = dinero.ToString();
            lbGananciaMinimPrecio.Text = (imp ? total.ToString() : (total + valorImpuesto).ToString());

            lbImpuestoIncluido.Text = (Convert.ToBoolean(Drow[16].ToString()) ? "Impuesto aplicado en el precio de compra" : "Impuesto no aplicado en el precio de compra");
            if (Convert.ToBoolean(Drow[17].ToString()))
            {
                double minim = Convert.ToDouble(Drow[18].ToString());
                double actual = Convert.ToDouble(Drow[19].ToString());
                lbInventario.Text += actual + " En la sucursal.";
                lbEstadoInv.Text = (minim >= actual ? "Alerta" : "Normal");
            }
            else
            {
                lbInventario.Hide();
                lbTitEstadoInv.Hide();
                lbEstadoInv.Hide();
            }
        }
    }
}
