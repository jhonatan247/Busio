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
    public class Detalle_Entrada
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Detalle_Entrada { get; set; }
        public long Id_Entrada { get; set; }
        public long Id_Producto { get; set; }
        public double Cantidad { get; set; }
        public double Precio { get; set; }
        public bool Recibido { get; set; }
        
        #endregion

        #region Constructores
        public Detalle_Entrada()
        {
        }
        public Detalle_Entrada(long pId_Detalle_Entrada, long pId_Entrada, long pId_Producto, double pCantidad, double pPrecio,
         bool pRecibido)
        {
            Id_Detalle_Entrada = pId_Detalle_Entrada;
            Id_Entrada = pId_Entrada;
            Id_Producto = pId_Producto;
            Cantidad = pCantidad;
            Precio = pPrecio;
            Recibido = pRecibido;
            
        }
        #endregion

        #region Métodos
        
        #endregion
    }
    #endregion
}
#endregion
