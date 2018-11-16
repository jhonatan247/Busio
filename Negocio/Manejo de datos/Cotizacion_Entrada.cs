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
    public class Cotizacion_Entrada
    {
        #region Atributos
        private DataConnection ED = new DataConnection();
        #endregion

        #region Propiedades
        SqlCommand Comando { get; set; }
        public long Id_Cotizacion_Entrada { get; set; }
        public long Id_Proveedor { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public bool Estado { get; set; }
        
        #endregion
        
        #region Constructores
        public Cotizacion_Entrada()
        {
        }
        public Cotizacion_Entrada(long pId_Cotizacion_Entrada, long pId_Proveedor, DateTime pFecha_Registro, bool pEstado)
        {
            Id_Cotizacion_Entrada = pId_Cotizacion_Entrada;
            Id_Proveedor = pId_Proveedor;
            Fecha_Registro = pFecha_Registro;
            Estado = pEstado;
           
        }
        #endregion

        #region Métodos
       
        #endregion
    }
    #endregion
}
#endregion
