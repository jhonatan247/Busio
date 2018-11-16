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
    public class Detalle_Promocion
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Detalle_Promocion { get; set; }
        public long Id_Promocion { get; set; }
        public long Id_Producto { get; set; }
        
        #endregion

        #region Constructores
        public Detalle_Promocion()
        {
        }
        public Detalle_Promocion(long pId_Detalle_Promocion, long pId_Promocion, long pId_Producto)
        {
            Id_Detalle_Promocion = pId_Detalle_Promocion;
            Id_Promocion = pId_Promocion;
            Id_Producto = pId_Producto;
            
        }
        #endregion

        #region Métodos
       
        #endregion
    }
    #endregion
}
#endregion
