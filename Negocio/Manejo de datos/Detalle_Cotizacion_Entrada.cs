#region Librerías
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos;
using System.Data;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using Negocio.Lógica;
#endregion

#region Manejo de datos
namespace Negocio.Manejo_de_datos
{
    #region Class
    public class Detalle_Cotizacion_Entrada
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Detalle_Cotizacion_Entrada { get; set; }
        public long Id_Cotizacion_Entrada { get; set; }
        public long Id_Producto { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
       
        #endregion

        #region Constructores
        public Detalle_Cotizacion_Entrada()
        {
        }
        public Detalle_Cotizacion_Entrada(long pId_Detalle_Cotizacion_Entrada, long pId_Cotizacion_Entrada, 
        long pId_Producto, double pCantidad, double pPrecio)
        {
            Id_Detalle_Cotizacion_Entrada = pId_Detalle_Cotizacion_Entrada;
            Id_Cotizacion_Entrada = pId_Cotizacion_Entrada;
            Id_Producto = pId_Producto;
            Cantidad = pCantidad;
            Precio = pPrecio;
            
        }
        #endregion

        #region Métodos
       
        #endregion
    }
    #endregion
}
#endregion
