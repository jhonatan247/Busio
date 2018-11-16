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
    public class Detalle_Cotizacion_Saida
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Detalle_Cotizacion_Saida { get; set; }
        public long Id_Cotizacion_Saida { get; set; }
        public string Id_Producto { get; set; }
        public string Cantidad { get; set; }
        public string Precio { get; set; }
        
        #endregion

        #region Constructores
        public Detalle_Cotizacion_Saida()
        {
        }
        public Detalle_Cotizacion_Saida(long pId_Detalle_Cotizacion_Saida, long pId_Cotizacion_Saida, string pId_Producto,
        string pCantidad, string pPrecio)
        {
            Id_Detalle_Cotizacion_Saida = pId_Detalle_Cotizacion_Saida;
            Id_Cotizacion_Saida = pId_Cotizacion_Saida;
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
