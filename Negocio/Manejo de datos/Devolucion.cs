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
    public class Devolucion
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Devolucion { get; set; }
        public long Id_Detalle_Venta { get; set; }
        public string Tipo_Devolucion { get; set; }
        public double Cantidad { get; set; }
        
        #endregion

        #region Constructores
        public Devolucion()
        {
        }
        public Devolucion(long pId_Devolucion, long pId_Detalle_Venta, string pTipo_Devolucion, double pCantidad)
        {
            Id_Devolucion = pId_Devolucion;
            Id_Detalle_Venta = pId_Detalle_Venta;
            Tipo_Devolucion = pTipo_Devolucion;
            Cantidad = pCantidad;
            
        }
        #endregion

        #region Métodos
        
        #endregion
    }
    #endregion
}
#endregion
